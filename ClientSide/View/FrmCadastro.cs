﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSide.View
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro(string titulo)
        {
            InitializeComponent();
            LbTitle.Text = titulo;
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void pnCima_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
