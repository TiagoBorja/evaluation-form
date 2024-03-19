﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {
            Perguntas f = Utility.formExists(typeof(Perguntas)) as Perguntas;
            if (f == null)
                f = new Perguntas();
            this.Hide();
            f.ShowDialog();
        }
    }
}
