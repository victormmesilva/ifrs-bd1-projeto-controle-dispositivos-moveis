namespace ProJeto_Banco_de_Dados
{
    partial class TelaConsultarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaConsultarFuncionario));
            this.button1 = new System.Windows.Forms.Button();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.btnConsultaAparelho = new System.Windows.Forms.Button();
            this.btnConsultaLinhas = new System.Windows.Forms.Button();
            this.btnRelatorioGeral = new System.Windows.Forms.Button();
            this.btnAparelhosFuncionarios = new System.Windows.Forms.Button();
            this.tbnFila = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Consulta Funcionarios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgView
            // 
            this.dgView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(138, 12);
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(650, 426);
            this.dgView.TabIndex = 2;
            // 
            // btnConsultaAparelho
            // 
            this.btnConsultaAparelho.Location = new System.Drawing.Point(12, 70);
            this.btnConsultaAparelho.Name = "btnConsultaAparelho";
            this.btnConsultaAparelho.Size = new System.Drawing.Size(120, 23);
            this.btnConsultaAparelho.TabIndex = 3;
            this.btnConsultaAparelho.Text = "Consulta Aparelhos";
            this.btnConsultaAparelho.UseVisualStyleBackColor = true;
            this.btnConsultaAparelho.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConsultaLinhas
            // 
            this.btnConsultaLinhas.Location = new System.Drawing.Point(12, 99);
            this.btnConsultaLinhas.Name = "btnConsultaLinhas";
            this.btnConsultaLinhas.Size = new System.Drawing.Size(120, 23);
            this.btnConsultaLinhas.TabIndex = 4;
            this.btnConsultaLinhas.Text = "Consulta Linhas";
            this.btnConsultaLinhas.UseVisualStyleBackColor = true;
            this.btnConsultaLinhas.Click += new System.EventHandler(this.btnConsultaLinhas_Click);
            // 
            // btnRelatorioGeral
            // 
            this.btnRelatorioGeral.Location = new System.Drawing.Point(12, 128);
            this.btnRelatorioGeral.Name = "btnRelatorioGeral";
            this.btnRelatorioGeral.Size = new System.Drawing.Size(120, 23);
            this.btnRelatorioGeral.TabIndex = 5;
            this.btnRelatorioGeral.Text = "Relatorio Geral";
            this.btnRelatorioGeral.UseVisualStyleBackColor = true;
            this.btnRelatorioGeral.Click += new System.EventHandler(this.btnRelatorioGeral_Click);
            // 
            // btnAparelhosFuncionarios
            // 
            this.btnAparelhosFuncionarios.Location = new System.Drawing.Point(12, 41);
            this.btnAparelhosFuncionarios.Name = "btnAparelhosFuncionarios";
            this.btnAparelhosFuncionarios.Size = new System.Drawing.Size(120, 23);
            this.btnAparelhosFuncionarios.TabIndex = 7;
            this.btnAparelhosFuncionarios.Text = "Aparelhos e Funcionarios";
            this.btnAparelhosFuncionarios.UseVisualStyleBackColor = true;
            this.btnAparelhosFuncionarios.Click += new System.EventHandler(this.btnAparelhosFuncionarios_Click);
            // 
            // tbnFila
            // 
            this.tbnFila.Location = new System.Drawing.Point(12, 157);
            this.tbnFila.Name = "tbnFila";
            this.tbnFila.Size = new System.Drawing.Size(120, 23);
            this.tbnFila.TabIndex = 8;
            this.tbnFila.Text = "Fila de Espera";
            this.tbnFila.UseVisualStyleBackColor = true;
            this.tbnFila.Click += new System.EventHandler(this.tbnFila_Click);
            // 
            // TelaConsultarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProJeto_Banco_de_Dados.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbnFila);
            this.Controls.Add(this.btnAparelhosFuncionarios);
            this.Controls.Add(this.btnRelatorioGeral);
            this.Controls.Add(this.btnConsultaLinhas);
            this.Controls.Add(this.btnConsultaAparelho);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaConsultarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MobileControl - Consultar Funcionario";
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.Button btnConsultaAparelho;
        private System.Windows.Forms.Button btnConsultaLinhas;
        private System.Windows.Forms.Button btnRelatorioGeral;
        private System.Windows.Forms.Button btnAparelhosFuncionarios;
        private System.Windows.Forms.Button tbnFila;
    }
}