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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            this.MouseDown += FrmLogin_MouseDown;
            this.MouseMove += FrmLogin_MouseMove;
            this.MouseUp += FrmLogin_MouseUp;
        }

        private bool isDragging = false;
        private Point offset;

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                offset = e.Location;
            }
        }

        private void FrmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newLocation = this.PointToScreen(new Point(e.X, e.Y));
                newLocation.Offset(-offset.X, -offset.Y);
                this.Location = newLocation;
            }
        }

        private void FrmLogin_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }


        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkAjuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            this.Hide();
            frm.ShowDialog();
        }
    }
}

/*
 O código que você fornecido pertence a uma classe chamada `FrmLogin` que parece ser um formulário de login em um aplicativo Windows Forms. 
Explicação da função de várias partes do código:

1. Construtor `FrmLogin():
   - Este é o construtor da classe `FrmLogin`, que é chamado quando um novo objeto `FrmLogin` é criado.
   - `InitializeComponent();`: Este método é gerado automaticamente pelo Designer de Formulários do Visual Studio e é usado para inicializar todos os controles e componentes no formulário.
   - `this.FormBorderStyle = FormBorderStyle.None;`: Isso remove a borda do formulário, tornando-o um formulário sem borda.

2. Manipulação de eventos de mouse:
   - Os métodos `FrmLogin_MouseDown`, `FrmLogin_MouseMove` e `FrmLogin_MouseUp` são manipuladores de eventos de mouse que permitem arrastar o formulário quando o botão esquerdo do mouse é pressionado e movido.
   - `isDragging` é uma variável booleana que controla se o formulário está sendo arrastado ou não.
   - `offset` é usado para armazenar a posição do mouse quando o botão é pressionado para calcular o deslocamento do mouse durante o movimento.
   - Esses eventos são associados aos eventos do formulário no construtor usando `this.MouseDown += FrmLogin_MouseDown;`, `this.MouseMove += FrmLogin_MouseMove;` e `this.MouseUp += FrmLogin_MouseUp;`.

3. Os outros métodos vazios, como `guna2Panel1_Paint`, `guna2TextBox1_TextChanged`, `FrmLogin_Load`, `linkAjuda_LinkClicked` e `guna2CheckBox1_CheckedChanged`, são métodos de manipulação de eventos associados a vários controles no seu formulário. 
Eles estão vazios por enquanto, mas será implementado no código apropriado neles conforme necessário para responder a ações do usuário em controles específicos, como clique de botão, alteração de texto, etc.

Em resumo, este código cria um formulário de login sem borda que pode ser arrastado pela tela usando o mouse e possui métodos vazios para manipular eventos de controles específicos. 
Sera aplicado metodos personalizado para adicionar o comportamento desejado dentro do formulário de login.
  
 */