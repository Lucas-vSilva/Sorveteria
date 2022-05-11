using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SorveteriaTI13N
{
    public partial class MenuLogin : Form
    {
        public MenuLogin()
        {
            InitializeComponent();
        }

        private void MenuLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightYellow;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.LightYellow;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;



            if (!char.IsLetterOrDigit(e.KeyChar) && tecla != 08)
            {
                e.Handled = true;



                MessageBox.Show("Digite apenas letras ou números.", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Warning);



                textBox1.SelectionStart = 0;
                textBox1.SelectionLength = textBox1.Text.Length;



                textBox1.Focus();
            }

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Equals("guimarco") && textBox2.Text.Equals("1234"))
                {
                    //Ir para a tela incial , depois do login.
                    var menu = new MenuSorvete();
                    menu.Show();




                    this.Visible = false;
                }//Fim do If.
                else
                {
                    MessageBox.Show("Usuário ou Senha incorretos.",
                    "Desculpe.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);



                    textBox1.Focus();
                    textBox2.Text = "";



                }//Fim do Else.




            }//Fim Try.
            catch (Exception ex)
            {
                MessageBox.Show("Usuário ou Senha incorretos.",
                "Desculpe.",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
    }
}
