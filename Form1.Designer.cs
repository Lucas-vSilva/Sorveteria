
namespace SorveteriaTI13N
{
    partial class MenuSorvete
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuSorvete));
            this.bttAtualizar = new System.Windows.Forms.Button();
            this.bttDeletar = new System.Windows.Forms.Button();
            this.bttBuscar = new System.Windows.Forms.Button();
            this.bttCadastrar = new System.Windows.Forms.Button();
            this.grpConsult = new System.Windows.Forms.GroupBox();
            this.bttSair = new System.Windows.Forms.Button();
            this.lblSorvete = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lstSorvete = new System.Windows.Forms.ListBox();
            this.grpConsult.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttAtualizar
            // 
            this.bttAtualizar.Location = new System.Drawing.Point(554, 48);
            this.bttAtualizar.Name = "bttAtualizar";
            this.bttAtualizar.Size = new System.Drawing.Size(75, 23);
            this.bttAtualizar.TabIndex = 3;
            this.bttAtualizar.Text = "Atualizar";
            this.bttAtualizar.UseVisualStyleBackColor = true;
            this.bttAtualizar.Click += new System.EventHandler(this.bttAtualizar_Click);
            // 
            // bttDeletar
            // 
            this.bttDeletar.Location = new System.Drawing.Point(554, 77);
            this.bttDeletar.Name = "bttDeletar";
            this.bttDeletar.Size = new System.Drawing.Size(75, 23);
            this.bttDeletar.TabIndex = 4;
            this.bttDeletar.Text = "Deletar";
            this.bttDeletar.UseVisualStyleBackColor = true;
            this.bttDeletar.Click += new System.EventHandler(this.bttDeletar_Click);
            // 
            // bttBuscar
            // 
            this.bttBuscar.Location = new System.Drawing.Point(554, 19);
            this.bttBuscar.Name = "bttBuscar";
            this.bttBuscar.Size = new System.Drawing.Size(75, 23);
            this.bttBuscar.TabIndex = 2;
            this.bttBuscar.Text = "Buscar";
            this.bttBuscar.UseVisualStyleBackColor = true;
            this.bttBuscar.Click += new System.EventHandler(this.bttBuscar_Click);
            // 
            // bttCadastrar
            // 
            this.bttCadastrar.Location = new System.Drawing.Point(554, 106);
            this.bttCadastrar.Name = "bttCadastrar";
            this.bttCadastrar.Size = new System.Drawing.Size(75, 23);
            this.bttCadastrar.TabIndex = 5;
            this.bttCadastrar.Text = "Cadastrar";
            this.bttCadastrar.UseVisualStyleBackColor = true;
            this.bttCadastrar.Click += new System.EventHandler(this.bttCadastrar_Click);
            // 
            // grpConsult
            // 
            this.grpConsult.Controls.Add(this.lstSorvete);
            this.grpConsult.Controls.Add(this.bttSair);
            this.grpConsult.Controls.Add(this.bttCadastrar);
            this.grpConsult.Controls.Add(this.bttBuscar);
            this.grpConsult.Controls.Add(this.bttDeletar);
            this.grpConsult.Controls.Add(this.bttAtualizar);
            this.grpConsult.Location = new System.Drawing.Point(12, 55);
            this.grpConsult.Name = "grpConsult";
            this.grpConsult.Size = new System.Drawing.Size(635, 294);
            this.grpConsult.TabIndex = 1;
            this.grpConsult.TabStop = false;
            // 
            // bttSair
            // 
            this.bttSair.Location = new System.Drawing.Point(560, 264);
            this.bttSair.Name = "bttSair";
            this.bttSair.Size = new System.Drawing.Size(75, 23);
            this.bttSair.TabIndex = 8;
            this.bttSair.Text = "Sair";
            this.bttSair.UseVisualStyleBackColor = true;
            this.bttSair.Click += new System.EventHandler(this.bttSair_Click);
            // 
            // lblSorvete
            // 
            this.lblSorvete.AutoSize = true;
            this.lblSorvete.Location = new System.Drawing.Point(15, 23);
            this.lblSorvete.Name = "lblSorvete";
            this.lblSorvete.Size = new System.Drawing.Size(129, 13);
            this.lblSorvete.TabIndex = 6;
            this.lblSorvete.Text = "Digite o nome do produto:";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(12, 39);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(635, 20);
            this.txtBusca.TabIndex = 5;
            // 
            // lstSorvete
            // 
            this.lstSorvete.FormattingEnabled = true;
            this.lstSorvete.Location = new System.Drawing.Point(6, 13);
            this.lstSorvete.Name = "lstSorvete";
            this.lstSorvete.Size = new System.Drawing.Size(542, 264);
            this.lstSorvete.TabIndex = 9;
            this.lstSorvete.SelectedIndexChanged += new System.EventHandler(this.lstSorvete_SelectedIndexChanged);
            // 
            // MenuSorvete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(663, 361);
            this.Controls.Add(this.lblSorvete);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.grpConsult);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuSorvete";
            this.Text = "Sorveteria";
            this.grpConsult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttAtualizar;
        private System.Windows.Forms.Button bttDeletar;
        private System.Windows.Forms.Button bttBuscar;
        private System.Windows.Forms.Button bttCadastrar;
        private System.Windows.Forms.GroupBox grpConsult;
        private System.Windows.Forms.Label lblSorvete;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button bttSair;
        private System.Windows.Forms.ListBox lstSorvete;
    }
}

