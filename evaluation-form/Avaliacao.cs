using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evaluation_form
{
    public partial class Avaliacao : Form
    {
        public Avaliacao()
        {
            InitializeComponent();
        }

        int numeroBtn;
        Form1 dadosSimples = Utility.formExists(typeof(Form1)) as Form1; //Nome, apelido...
        Perguntas questionario = Utility.formExists(typeof (Perguntas)) as Perguntas; //Atividades, qual mais gostou...

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pbVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Perguntas p = new Perguntas();
            p.ShowDialog();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                using(MySqlConnection conexao = BD.ConectarBD())
                {
                    if(conexao != null)
                    {
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            cmd.Connection = conexao;
                            cmd.CommandText = @"INSERT INTO perguntas_avaliacao (nome,apelido,ano,escola,curso_frequentado,atividade_gostou,porque_gostou,nota_final)
                                                VALUES (@nome,@apelido,@ano,@escola,@curso_frequentado,@atividade_gostou,@porque_gostou,@nota_final)";

                            cmd.Parameters.AddWithValue("@nome",dadosSimples.txtNome.Text);
                            cmd.Parameters.AddWithValue("@apelido",dadosSimples.txtApelido.Text);
                            cmd.Parameters.AddWithValue("@escola",dadosSimples.txtEscola.Text);
                            cmd.Parameters.AddWithValue("@ano", dadosSimples.cbAno.Text);

                            cmd.Parameters.AddWithValue("@curso_frequentado", questionario.cbCurso.Text);
                            cmd.Parameters.AddWithValue("@atividade_gostou", questionario.txtAtividade.Text);
                            cmd.Parameters.AddWithValue("@porque_gostou", questionario.txtPq.Text);
                            cmd.Parameters.AddWithValue("@nota_final", numeroBtn);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Obrigado por tirar seu tempo a responder!!!");
                            Application.Exit();
                        }
                    }
                    MessageBox.Show("MySql está desligado!","Alerta!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void img5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Recebe o "número" do btn clicado
            numeroBtn = int.Parse(btn.Name.Substring(3)); // Inicia a busca a partir do 4º caractér

            // Inverte a ordem do btn, selecionando todos os seus antecessores
            for (int i = numeroBtn; i >= 1; i--)
            {
                Button btnAtual = (Button)this.Controls.Find("img" + i, true)[0];
                btnAtual.BackgroundImage = Properties.Resources.estrala_avaliacao;
            }
        }
    }
}
