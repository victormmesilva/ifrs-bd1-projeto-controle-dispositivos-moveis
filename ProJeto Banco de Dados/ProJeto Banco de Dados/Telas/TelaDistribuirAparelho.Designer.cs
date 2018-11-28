using System;

namespace ProJeto_Banco_de_Dados
{
    partial class TelaDistribuirAparelho
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
            System.Windows.Forms.Label label10;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDistribuirAparelho));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.cbxLinha = new System.Windows.Forms.ComboBox();
            this.cbxModelo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.mTxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxDDD = new System.Windows.Forms.ComboBox();
            this.lblDDD = new System.Windows.Forms.Label();
            this.cbxDDI = new System.Windows.Forms.ComboBox();
            this.lblDDI = new System.Windows.Forms.Label();
            this.cbxOperadora = new System.Windows.Forms.ComboBox();
            this.lblOperadora = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblArmazenamento = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblRam = new System.Windows.Forms.Label();
            this.lblSO = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblChipset = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNumChips = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new System.Drawing.Point(6, 106);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(100, 13);
            label10.TabIndex = 6;
            label10.Text = "Armazenamento:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(522, 413);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Modelo";
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
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nome:";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(604, 413);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 20;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // cbxLinha
            // 
            this.cbxLinha.Enabled = false;
            this.cbxLinha.FormattingEnabled = true;
            this.cbxLinha.Location = new System.Drawing.Point(149, 71);
            this.cbxLinha.Name = "cbxLinha";
            this.cbxLinha.Size = new System.Drawing.Size(101, 21);
            this.cbxLinha.TabIndex = 21;
            this.cbxLinha.Text = "SELECIONE";
            // 
            // cbxModelo
            // 
            this.cbxModelo.Enabled = false;
            this.cbxModelo.FormattingEnabled = true;
            this.cbxModelo.Location = new System.Drawing.Point(9, 80);
            this.cbxModelo.Name = "cbxModelo";
            this.cbxModelo.Size = new System.Drawing.Size(321, 21);
            this.cbxModelo.TabIndex = 23;
            this.cbxModelo.Text = "SELECIONE";
            this.cbxModelo.SelectedIndexChanged += new System.EventHandler(this.cbxModelo_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProJeto_Banco_de_Dados.Properties.Resources.logo_fotografia_1;
            this.pictureBox1.Location = new System.Drawing.Point(52, 25);
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
            this.cbxMarca.Enabled = false;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(9, 33);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(156, 21);
            this.cbxMarca.TabIndex = 25;
            this.cbxMarca.Text = "SELECIONE";
            this.cbxMarca.SelectedIndexChanged += new System.EventHandler(this.cbxMarca_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.mTxtCPF);
            this.groupBox1.Controls.Add(this.lblCPF);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(335, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 89);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Funcionário";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(57, 49);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 13);
            this.lblNome.TabIndex = 25;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(159, 17);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(60, 20);
            this.btnOK.TabIndex = 26;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // mTxtCPF
            // 
            this.mTxtCPF.Location = new System.Drawing.Point(60, 17);
            this.mTxtCPF.Mask = "000.000.000-00";
            this.mTxtCPF.Name = "mTxtCPF";
            this.mTxtCPF.Size = new System.Drawing.Size(88, 20);
            this.mTxtCPF.TabIndex = 24;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(9, 20);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(34, 13);
            this.lblCPF.TabIndex = 23;
            this.lblCPF.Text = "CPF:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxMarca);
            this.groupBox2.Controls.Add(this.lblMarca);
            this.groupBox2.Controls.Add(this.cbxModelo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(335, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 152);
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
            this.groupBox3.Location = new System.Drawing.Point(335, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 107);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados da Linha";
            // 
            // cbxDDD
            // 
            this.cbxDDD.Enabled = false;
            this.cbxDDD.FormattingEnabled = true;
            this.cbxDDD.Location = new System.Drawing.Point(9, 71);
            this.cbxDDD.Name = "cbxDDD";
            this.cbxDDD.Size = new System.Drawing.Size(121, 21);
            this.cbxDDD.TabIndex = 27;
            this.cbxDDD.Text = "SELECIONE";
            this.cbxDDD.SelectedIndexChanged += new System.EventHandler(this.cbxDDD_SelectedIndexChanged);
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
            // cbxDDI
            // 
            this.cbxDDI.Enabled = false;
            this.cbxDDI.FormattingEnabled = true;
            this.cbxDDI.Location = new System.Drawing.Point(9, 32);
            this.cbxDDI.Name = "cbxDDI";
            this.cbxDDI.Size = new System.Drawing.Size(121, 21);
            this.cbxDDI.TabIndex = 25;
            this.cbxDDI.Text = "SELECIONE";
            this.cbxDDI.SelectedIndexChanged += new System.EventHandler(this.cbxDDI_SelectedIndexChanged);
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
            // cbxOperadora
            // 
            this.cbxOperadora.Enabled = false;
            this.cbxOperadora.FormattingEnabled = true;
            this.cbxOperadora.Location = new System.Drawing.Point(149, 31);
            this.cbxOperadora.Name = "cbxOperadora";
            this.cbxOperadora.Size = new System.Drawing.Size(121, 21);
            this.cbxOperadora.TabIndex = 23;
            this.cbxOperadora.Text = "SELECIONE";
            this.cbxOperadora.SelectedIndexChanged += new System.EventHandler(this.cbxOperadora_SelectedIndexChanged);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblArmazenamento);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.lblRam);
            this.groupBox4.Controls.Add(label10);
            this.groupBox4.Controls.Add(this.lblSO);
            this.groupBox4.Controls.Add(this.lbl);
            this.groupBox4.Controls.Add(this.lblChipset);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.lblNumChips);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(23, 289);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(272, 147);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ficha técnica";
            // 
            // lblArmazenamento
            // 
            this.lblArmazenamento.AutoSize = true;
            this.lblArmazenamento.Location = new System.Drawing.Point(112, 106);
            this.lblArmazenamento.Name = "lblArmazenamento";
            this.lblArmazenamento.Size = new System.Drawing.Size(37, 13);
            this.lblArmazenamento.TabIndex = 9;
            this.lblArmazenamento.Text = "32 GB";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(112, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Android";
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.Location = new System.Drawing.Point(112, 68);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(31, 13);
            this.lblRam.TabIndex = 7;
            this.lblRam.Text = "2 GB";
            // 
            // lblSO
            // 
            this.lblSO.AutoSize = true;
            this.lblSO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSO.Location = new System.Drawing.Point(6, 87);
            this.lblSO.Name = "lblSO";
            this.lblSO.Size = new System.Drawing.Size(28, 13);
            this.lblSO.TabIndex = 5;
            this.lblSO.Text = "SO:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(6, 68);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(38, 13);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "RAM:";
            // 
            // lblChipset
            // 
            this.lblChipset.AutoSize = true;
            this.lblChipset.Location = new System.Drawing.Point(112, 49);
            this.lblChipset.Name = "lblChipset";
            this.lblChipset.Size = new System.Drawing.Size(142, 13);
            this.lblChipset.TabIndex = 3;
            this.lblChipset.Text = "Snapdragon 660 Qualcomm ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Chipset:";
            // 
            // lblNumChips
            // 
            this.lblNumChips.AutoSize = true;
            this.lblNumChips.Location = new System.Drawing.Point(112, 31);
            this.lblNumChips.Name = "lblNumChips";
            this.lblNumChips.Size = new System.Drawing.Size(13, 13);
            this.lblNumChips.TabIndex = 1;
            this.lblNumChips.Text = "2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nº de CHIPS:";
            // 
            // TelaDistribuirAparelho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 485);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaDistribuirAparelho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MobileControl - Distribuição  de Aparelho";
            this.Load += new System.EventHandler(this.TelaCadastrarAparelho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ComboBox cbxLinha;
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblChipset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNumChips;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.Label lblSO;
        private System.Windows.Forms.Label lblArmazenamento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mTxtCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblNome;
    }
}