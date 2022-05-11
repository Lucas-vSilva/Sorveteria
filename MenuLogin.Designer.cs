
namespace SorveteriaTI13N
{
    partial class MenuLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuLogin));
            this.formlogin = new System.Windows.Forms.GroupBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.logar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelsenha = new System.Windows.Forms.Label();
            this.labeluser = new System.Windows.Forms.Label();
            this.formlogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // formlogin
            // 
            this.formlogin.Controls.Add(this.cancelar);
            this.formlogin.Controls.Add(this.logar);
            this.formlogin.Controls.Add(this.textBox2);
            this.formlogin.Controls.Add(this.textBox1);
            this.formlogin.Controls.Add(this.labelsenha);
            this.formlogin.Controls.Add(this.labeluser);
            this.formlogin.Location = new System.Drawing.Point(12, 12);
            this.formlogin.Name = "formlogin";
            this.formlogin.Size = new System.Drawing.Size(329, 139);
            this.formlogin.TabIndex = 0;
            this.formlogin.TabStop = false;
            this.formlogin.Text = "Login";
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(174, 116);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 5;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // logar
            // 
            this.logar.Location = new System.Drawing.Point(255, 116);
            this.logar.Name = "logar";
            this.logar.Size = new System.Drawing.Size(75, 23);
            this.logar.TabIndex = 4;
            this.logar.Text = "Logar";
            this.logar.UseVisualStyleBackColor = true;
            this.logar.Click += new System.EventHandler(this.logar_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.UseSystemPasswordChar = true;
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // labelsenha
            // 
            this.labelsenha.AutoSize = true;
            this.labelsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsenha.Location = new System.Drawing.Point(18, 71);
            this.labelsenha.Name = "labelsenha";
            this.labelsenha.Size = new System.Drawing.Size(52, 15);
            this.labelsenha.TabIndex = 1;
            this.labelsenha.Text = "Senha:";
            // 
            // labeluser
            // 
            this.labeluser.AutoSize = true;
            this.labeluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeluser.Location = new System.Drawing.Point(18, 23);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(61, 15);
            this.labeluser.TabIndex = 0;
            this.labeluser.Text = "Usuário:";
            // 
            // MenuLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 168);
            this.Controls.Add(this.formlogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuLogin";
            this.Text = "Sorveteria";
            this.Load += new System.EventHandler(this.MenuLogin_Load);
            this.formlogin.ResumeLayout(false);
            this.formlogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox formlogin;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button logar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelsenha;
        private System.Windows.Forms.Label labeluser;
    }
}