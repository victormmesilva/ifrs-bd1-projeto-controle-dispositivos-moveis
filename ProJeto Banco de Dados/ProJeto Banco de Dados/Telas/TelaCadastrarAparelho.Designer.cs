namespace ProJeto_Banco_de_Dados.Telas
{
    partial class TelaCadastrarAparelho
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.imgModelo = new System.Windows.Forms.PictureBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtImei = new System.Windows.Forms.TextBox();
            this.txtMacAdress = new System.Windows.Forms.TextBox();
            this.txtNumeroSerie = new System.Windows.Forms.TextBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxModelo = new System.Windows.Forms.ComboBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbImei = new System.Windows.Forms.Label();
            this.lbMacAddres = new System.Windows.Forms.Label();
            this.lbNumeroSerie = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbModelo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgModelo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(397, 233);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // imgModelo
            // 
            this.imgModelo.Image = global::ProJeto_Banco_de_Dados.Properties.Resources.logo_fotografia_1;
            this.imgModelo.Location = new System.Drawing.Point(38, 21);
            this.imgModelo.Name = "imgModelo";
            this.imgModelo.Size = new System.Drawing.Size(210, 235);
            this.imgModelo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgModelo.TabIndex = 3;
            this.imgModelo.TabStop = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(397, 181);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 25);
            this.txtSenha.TabIndex = 7;
            // 
            // txtImei
            // 
            this.txtImei.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImei.Location = new System.Drawing.Point(397, 150);
            this.txtImei.Name = "txtImei";
            this.txtImei.Size = new System.Drawing.Size(125, 25);
            this.txtImei.TabIndex = 8;
            // 
            // txtMacAdress
            // 
            this.txtMacAdress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMacAdress.Location = new System.Drawing.Point(397, 119);
            this.txtMacAdress.Name = "txtMacAdress";
            this.txtMacAdress.Size = new System.Drawing.Size(125, 25);
            this.txtMacAdress.TabIndex = 9;
            // 
            // txtNumeroSerie
            // 
            this.txtNumeroSerie.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroSerie.Location = new System.Drawing.Point(397, 88);
            this.txtNumeroSerie.Name = "txtNumeroSerie";
            this.txtNumeroSerie.Size = new System.Drawing.Size(145, 25);
            this.txtNumeroSerie.TabIndex = 10;
            // 
            // cbxMarca
            // 
            this.cbxMarca.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(397, 26);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(145, 25);
            this.cbxMarca.TabIndex = 11;
            this.cbxMarca.SelectedIndexChanged += new System.EventHandler(this.cbxMarca_SelectedIndexChanged);
            // 
            // cbxModelo
            // 
            this.cbxModelo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxModelo.FormattingEnabled = true;
            this.cbxModelo.Location = new System.Drawing.Point(397, 57);
            this.cbxModelo.Name = "cbxModelo";
            this.cbxModelo.Size = new System.Drawing.Size(145, 25);
            this.cbxModelo.TabIndex = 12;
            this.cbxModelo.SelectedIndexChanged += new System.EventHandler(this.cbxModelo_SelectedIndexChanged);
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.Location = new System.Drawing.Point(333, 184);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(50, 17);
            this.lbSenha.TabIndex = 13;
            this.lbSenha.Text = "Senha";
            // 
            // lbImei
            // 
            this.lbImei.AutoSize = true;
            this.lbImei.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImei.Location = new System.Drawing.Point(348, 153);
            this.lbImei.Name = "lbImei";
            this.lbImei.Size = new System.Drawing.Size(35, 17);
            this.lbImei.TabIndex = 14;
            this.lbImei.Text = "Imei";
            // 
            // lbMacAddres
            // 
            this.lbMacAddres.AutoSize = true;
            this.lbMacAddres.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMacAddres.Location = new System.Drawing.Point(291, 122);
            this.lbMacAddres.Name = "lbMacAddres";
            this.lbMacAddres.Size = new System.Drawing.Size(92, 17);
            this.lbMacAddres.TabIndex = 15;
            this.lbMacAddres.Text = "Mac Address";
            // 
            // lbNumeroSerie
            // 
            this.lbNumeroSerie.AutoSize = true;
            this.lbNumeroSerie.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroSerie.Location = new System.Drawing.Point(265, 91);
            this.lbNumeroSerie.Name = "lbNumeroSerie";
            this.lbNumeroSerie.Size = new System.Drawing.Size(118, 17);
            this.lbNumeroSerie.TabIndex = 16;
            this.lbNumeroSerie.Text = "Numero de Serie";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.Location = new System.Drawing.Point(335, 29);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(48, 17);
            this.lbMarca.TabIndex = 17;
            this.lbMarca.Text = "Marca";
            this.lbMarca.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModelo.Location = new System.Drawing.Point(329, 60);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(54, 17);
            this.lbModelo.TabIndex = 18;
            this.lbModelo.Text = "Modelo";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(308, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TelaCadastrarAparelho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 279);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbModelo);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.lbNumeroSerie);
            this.Controls.Add(this.lbMacAddres);
            this.Controls.Add(this.lbImei);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.cbxModelo);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.txtNumeroSerie);
            this.Controls.Add(this.txtMacAdress);
            this.Controls.Add(this.txtImei);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.imgModelo);
            this.Name = "TelaCadastrarAparelho";
            this.Text = "MobileControl - Cadastro de Aparelho";
            this.Load += new System.EventHandler(this.IncluirFoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgModelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imgModelo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtImei;
        private System.Windows.Forms.TextBox txtMacAdress;
        private System.Windows.Forms.TextBox txtNumeroSerie;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxModelo;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbImei;
        private System.Windows.Forms.Label lbMacAddres;
        private System.Windows.Forms.Label lbNumeroSerie;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.Button button1;
    }
}