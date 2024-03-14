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
            this.Close();
        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {
            Avaliacao f = new Avaliacao();
            f.ShowDialog();
        }
    }
}
