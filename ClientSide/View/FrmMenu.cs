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
            GridProducts.Rows.Add("2", "Banana", "72", "127.20", "08-10-2023");
            GridProducts.Rows.Add("3", "Maçã", "120", "198.24", "08-10-2023");
            GridProducts.Rows.Add("4", "Linguiça", "310", "540.00", "08-10-2023");
            GridProducts.Rows.Add("5", "Picanha", "98", "720.30", "08-10-2023");
            GridProducts.Rows.Add("6", "Pão de Alho", "236", "147.00", "08-10-2023");
            GridProducts.Rows.Add("7", "Bolacha Bauducco", "34", "250.00", "08-10-2023");
            GridProducts.Rows.Add("8", "Vinho Tinto", "287", "620.00", "08-10-2023");
            GridProducts.Rows.Add("9", "Panetone", "144", "95.87", "08-10-2023");
            GridProducts.Rows.Add("10", "Queijo Provolone", "68", "360.00", "08-10-2023");
        }

        private void BtnnNovo_Click(object sender, EventArgs e)
        {
            FrmCadastro frm = new FrmCadastro("Novo Produto");
            frm.ShowDialog();
        }

        private void GridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string coluna = GridProducts.Columns[e.ColumnIndex].Name;
            if(coluna == "Edit")
            {
                FrmCadastro frm = new FrmCadastro("Editar Produto");
                frm.ShowDialog();
            }
        }
    }
}



