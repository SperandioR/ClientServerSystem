using System;
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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            GridProducts.Rows.Add("1", "Peixe Porquinho", "34", "250.00", "08-10-2023");
            GridProducts.Rows.Add("2", "Peixe Porquinho", "34", "250.00", "08-10-2023");
            GridProducts.Rows.Add("3", "Peixe Porquinho", "34", "250.00", "08-10-2023");
            GridProducts.Rows.Add("4", "Peixe Porquinho", "34", "250.00", "08-10-2023");
        }

        private void BtnnNovo_Click(object sender, EventArgs e)
        {
            FrmCadastro frm = new FrmCadastro("Novo Produto");
            frm.ShowDialog();
        }
    }
}



