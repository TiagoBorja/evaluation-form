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
    public partial class Perguntas : Form
    {
        public Perguntas()
        {
            InitializeComponent();          
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {
            Avaliacao f = new Avaliacao();
            this.Hide();
            f.ShowDialog();
        }
        private void Perguntas_Load(object sender, EventArgs e)
        {
           
        }

        private void pbVoltar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }
    }
}
