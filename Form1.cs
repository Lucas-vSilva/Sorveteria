using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SorveteriaTI13N
{
    public partial class MenuSorvete : Form
    {
      

        public MenuSorvete()
        {
            InitializeComponent();
           
           
        }
    

        private void bttCadastrar_Click(object sender, EventArgs e)
        {
            lstSorvete.Items.Add(txtBusca.Text);
            txtBusca.Clear();
            txtBusca.Focus();
        }

        private void bttDeletar_Click(object sender, EventArgs e)
        {
            if (lstSorvete.SelectedIndex > -1)
                lstSorvete.Items.RemoveAt(lstSorvete.SelectedIndex);
            MessageBox.Show("Item deletado.");
            txtBusca.Clear();
        }


        private void bttAtualizar_Click(object sender, EventArgs e)
        {
            if (lstSorvete.SelectedIndex > -1)
                lstSorvete.Items[lstSorvete.SelectedIndex] = txtBusca.Text;
            else
                MessageBox.Show("Atualizado.");
            txtBusca.Clear();
        }

        private void bttBuscar_Click(object sender, EventArgs e)
        {
           
            lstSorvete.Items.Add("Produto: Picolé de Chocolate;" +
                " Preço: R$1,90; " +
                " Quantidades: 5;");
            lstSorvete.Items.Add("Produto: Picolé de Chiclete" +
                " Preço: R$1,90; " +
                " Quantidades: 5;");
             lstSorvete.Items.Add("Produto: Picolé de Limão" +
                " Preço: R$1,90; " +
                " Quantidades: 5;");
             lstSorvete.Items.Add("Produto: Paleta de Ninho com Nutella" +
                " Preço: R$6,90; " +
                " Quantidades: 10;");
             lstSorvete.Items.Add("Produto: Paleta de Morango" +
                " Preço: R$6,90; " +
                " Quantidades: 10;");
             lstSorvete.Items.Add("Produto: Paleta de Oreo" +
                " Preço: R$6,90; " +
                " Quantidades: 10;");
             lstSorvete.Items.Add("Produto: Sorvete de Açai" +
                " Preço: R$11,90; " +
                " Quantidades: 10;");
             lstSorvete.Items.Add("Produto: Sorvete de Chocolate" +
                " Preço: R$11,90; " +
                " Quantidades: 10;");
             lstSorvete.Items.Add("Produto: Sorvete de Morango" +
                " Preço: R$11,90; " +
                " Quantidades: 10;");
        }

        private void bttSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstSorvete_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
    

}
