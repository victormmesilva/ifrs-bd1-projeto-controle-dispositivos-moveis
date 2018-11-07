namespace ProJeto_Banco_de_Dados.Telas
{
    partial class IncluirFoto
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
            this.btnInserirImagem = new System.Windows.Forms.Button();
            this.txtImagem = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbxAparelhosemfoto = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInserirImagem
            // 
            this.btnInserirImagem.Location = new System.Drawing.Point(36, 337);
            this.btnInserirImagem.Name = "btnInserirImagem";
            this.btnInserirImagem.Size = new System.Drawing.Size(214, 19);
            this.btnInserirImagem.TabIndex = 5;
            this.btnInserirImagem.Text = "Inserir Imagem";
            this.btnInserirImagem.UseVisualStyleBackColor = true;
            this.btnInserirImagem.Click += new System.EventHandler(this.btnInserirImagem_Click);
            // 
            // txtImagem
            // 
            this.txtImagem.Location = new System.Drawing.Point(36, 311);
            this.txtImagem.Name = "txtImagem";
            this.txtImagem.Size = new System.Drawing.Size(214, 20);
            this.txtImagem.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(286, 333);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cbxAparelhosemfoto
            // 
            this.cbxAparelhosemfoto.FormattingEnabled = true;
            this.cbxAparelhosemfoto.Location = new System.Drawing.Point(286, 127);
            this.cbxAparelhosemfoto.Name = "cbxAparelhosemfoto";
            this.cbxAparelhosemfoto.Size = new System.Drawing.Size(121, 21);
            this.cbxAparelhosemfoto.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProJeto_Banco_de_Dados.Properties.Resources.logo_fotografia_1;
            this.pictureBox1.Location = new System.Drawing.Point(36, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(286, 73);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(56, 20);
            this.txtFiltro.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 387);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.cbxAparelhosemfoto);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnInserirImagem);
            this.Controls.Add(this.txtImagem);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserirImagem;
        private System.Windows.Forms.TextBox txtImagem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbxAparelhosemfoto;
        private System.Windows.Forms.TextBox txtFiltro;
    }
}