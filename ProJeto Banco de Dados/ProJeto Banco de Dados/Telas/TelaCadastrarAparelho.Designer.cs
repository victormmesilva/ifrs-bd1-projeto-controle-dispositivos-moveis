using System;

namespace ProJeto_Banco_de_Dados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastrarAparelho));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImei = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroSerie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMacAdress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.cbxLinha = new System.Windows.Forms.ComboBox();
            this.cbxFuncionario = new System.Windows.Forms.ComboBox();
            this.cbxModelo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblOperadora = new System.Windows.Forms.Label();
            this.cbxOperadora = new System.Windows.Forms.ComboBox();
            this.lblDDI = new System.Windows.Forms.Label();
            this.cbxDDI = new System.Windows.Forms.ComboBox();
            this.lblDDD = new System.Windows.Forms.Label();
            this.cbxDDD = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(459, 405);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(167, 162);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(94, 20);
            this.txtSenha.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "IMEI";
            // 
            // txtImei
            // 
            this.txtImei.Enabled = false;
            this.txtImei.Location = new System.Drawing.Point(9, 121);
            this.txtImei.Name = "txtImei";
            this.txtImei.Size = new System.Drawing.Size(143, 20);
            this.txtImei.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Número de Série";
            // 
            // txtNumeroSerie
            // 
            this.txtNumeroSerie.Enabled = false;
            this.txtNumeroSerie.Location = new System.Drawing.Point(167, 121);
            this.txtNumeroSerie.Name = "txtNumeroSerie";
            this.txtNumeroSerie.Size = new System.Drawing.Size(180, 20);
            this.txtNumeroSerie.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "MAC Address";
            // 
            // txtMacAdress
            // 
            this.txtMacAdress.Enabled = false;
            this.txtMacAdress.Location = new System.Drawing.Point(9, 162);
            this.txtMacAdress.Name = "txtMacAdress";
            this.txtMacAdress.Size = new System.Drawing.Size(143, 20);
            this.txtMacAdress.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Modelo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Linhas Disponíveis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nome";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(541, 405);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 20;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // cbxLinha
            // 
            this.cbxLinha.FormattingEnabled = true;
            this.cbxLinha.Location = new System.Drawing.Point(149, 71);
            this.cbxLinha.Name = "cbxLinha";
            this.cbxLinha.Size = new System.Drawing.Size(101, 21);
            this.cbxLinha.TabIndex = 21;
            this.cbxLinha.Text = "SELECIONE";
            this.cbxLinha.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbxFuncionario
            // 
            this.cbxFuncionario.FormattingEnabled = true;
            this.cbxFuncionario.Location = new System.Drawing.Point(9, 33);
            this.cbxFuncionario.Name = "cbxFuncionario";
            this.cbxFuncionario.Size = new System.Drawing.Size(338, 21);
            this.cbxFuncionario.TabIndex = 22;
            this.cbxFuncionario.Text = "SELECIONE";
            // 
            // cbxModelo
            // 
            this.cbxModelo.FormattingEnabled = true;
            this.cbxModelo.Location = new System.Drawing.Point(9, 80);
            this.cbxModelo.Name = "cbxModelo";
            this.cbxModelo.Size = new System.Drawing.Size(338, 21);
            this.cbxModelo.TabIndex = 23;
            this.cbxModelo.Text = "SELECIONE";
            this.cbxModelo.SelectedIndexChanged += new System.EventHandler(this.cbxModelo_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProJeto_Banco_de_Dados.Properties.Resources.logo_fotografia_1;
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(6, 16);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 24;
            this.lblMarca.Text = "Marca";
            this.lblMarca.UseWaitCursor = true;
            // 
            // cbxMarca
            // 
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(9, 33);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(156, 21);
            this.cbxMarca.TabIndex = 25;
            this.cbxMarca.Text = "SELECIONE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbxFuncionario);
            this.groupBox1.Location = new System.Drawing.Point(264, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 69);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Funcionário";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxMarca);
            this.groupBox2.Controls.Add(this.txtSenha);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblMarca);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbxModelo);
            this.groupBox2.Controls.Add(this.txtImei);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNumeroSerie);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMacAdress);
            this.groupBox2.Location = new System.Drawing.Point(264, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 199);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Aparelho";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxDDD);
            this.groupBox3.Controls.Add(this.lblDDD);
            this.groupBox3.Controls.Add(this.cbxDDI);
            this.groupBox3.Controls.Add(this.lblDDI);
            this.groupBox3.Controls.Add(this.cbxOperadora);
            this.groupBox3.Controls.Add(this.lblOperadora);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cbxLinha);
            this.groupBox3.Location = new System.Drawing.Point(264, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 107);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados da Linha";
            // 
            // lblOperadora
            // 
            this.lblOperadora.AutoSize = true;
            this.lblOperadora.Location = new System.Drawing.Point(146, 16);
            this.lblOperadora.Name = "lblOperadora";
            this.lblOperadora.Size = new System.Drawing.Size(57, 13);
            this.lblOperadora.TabIndex = 22;
            this.lblOperadora.Text = "Operadora";
            // 
            // cbxOperadora
            // 
            this.cbxOperadora.FormattingEnabled = true;
            this.cbxOperadora.Location = new System.Drawing.Point(149, 31);
            this.cbxOperadora.Name = "cbxOperadora";
            this.cbxOperadora.Size = new System.Drawing.Size(121, 21);
            this.cbxOperadora.TabIndex = 23;
            this.cbxOperadora.Text = "SELECIONE";
            // 
            // lblDDI
            // 
            this.lblDDI.AutoSize = true;
            this.lblDDI.Location = new System.Drawing.Point(6, 16);
            this.lblDDI.Name = "lblDDI";
            this.lblDDI.Size = new System.Drawing.Size(57, 13);
            this.lblDDI.TabIndex = 24;
            this.lblDDI.Text = "DDI - País";
            // 
            // cbxDDI
            // 
            this.cbxDDI.FormattingEnabled = true;
            this.cbxDDI.Location = new System.Drawing.Point(9, 32);
            this.cbxDDI.Name = "cbxDDI";
            this.cbxDDI.Size = new System.Drawing.Size(121, 21);
            this.cbxDDI.TabIndex = 25;
            this.cbxDDI.Text = "SELECIONE";
            // 
            // lblDDD
            // 
            this.lblDDD.AutoSize = true;
            this.lblDDD.Location = new System.Drawing.Point(6, 56);
            this.lblDDD.Name = "lblDDD";
            this.lblDDD.Size = new System.Drawing.Size(74, 13);
            this.lblDDD.TabIndex = 26;
            this.lblDDD.Text = "DDD - Região";
            // 
            // cbxDDD
            // 
            this.cbxDDD.FormattingEnabled = true;
            this.cbxDDD.Location = new System.Drawing.Point(9, 71);
            this.cbxDDD.Name = "cbxDDD";
            this.cbxDDD.Size = new System.Drawing.Size(121, 21);
            this.cbxDDD.TabIndex = 27;
            this.cbxDDD.Text = "SELECIONE";
            // 
            // TelaCadastrarAparelho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(646, 442);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCadastrarAparelho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Aparelho";
            this.Load += new System.EventHandler(this.TelaCadastrarAparelho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImei;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeroSerie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMacAdress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ComboBox cbxLinha;
        private System.Windows.Forms.ComboBox cbxFuncionario;
        private System.Windows.Forms.ComboBox cbxModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxOperadora;
        private System.Windows.Forms.Label lblOperadora;
        private System.Windows.Forms.ComboBox cbxDDD;
        private System.Windows.Forms.Label lblDDD;
        private System.Windows.Forms.ComboBox cbxDDI;
        private System.Windows.Forms.Label lblDDI;
    }
}