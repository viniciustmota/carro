namespace Carro
{
    partial class Form1
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
            this.lblCarros = new System.Windows.Forms.Label();
            this.lblCores = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEscolha = new System.Windows.Forms.Button();
            this.cboCarros = new System.Windows.Forms.ComboBox();
            this.cboCores = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCarros
            // 
            this.lblCarros.AutoSize = true;
            this.lblCarros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarros.Location = new System.Drawing.Point(145, 99);
            this.lblCarros.Name = "lblCarros";
            this.lblCarros.Size = new System.Drawing.Size(71, 24);
            this.lblCarros.TabIndex = 0;
            this.lblCarros.Text = "Carros";
            // 
            // lblCores
            // 
            this.lblCores.AutoSize = true;
            this.lblCores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCores.Location = new System.Drawing.Point(366, 99);
            this.lblCores.Name = "lblCores";
            this.lblCores.Size = new System.Drawing.Size(65, 24);
            this.lblCores.TabIndex = 2;
            this.lblCores.Text = "Cores";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(148, 239);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(108, 36);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnEscolha
            // 
            this.btnEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscolha.Location = new System.Drawing.Point(410, 239);
            this.btnEscolha.Name = "btnEscolha";
            this.btnEscolha.Size = new System.Drawing.Size(162, 36);
            this.btnEscolha.TabIndex = 5;
            this.btnEscolha.Text = "SUA ESCOLHA";
            this.btnEscolha.UseVisualStyleBackColor = true;
            this.btnEscolha.Click += new System.EventHandler(this.BtnEscolha_Click);
            // 
            // cboCarros
            // 
            this.cboCarros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCarros.FormattingEnabled = true;
            this.cboCarros.Items.AddRange(new object[] {
            "Impala",
            "Opala",
            "Fusca",
            "Uno",
            "BMW 320i",
            "lamborghini urus"});
            this.cboCarros.Location = new System.Drawing.Point(148, 126);
            this.cboCarros.Name = "cboCarros";
            this.cboCarros.Size = new System.Drawing.Size(166, 32);
            this.cboCarros.TabIndex = 6;
            // 
            // cboCores
            // 
            this.cboCores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCores.FormattingEnabled = true;
            this.cboCores.Items.AddRange(new object[] {
            "Vermelho",
            "Amarelo",
            "Bege",
            "Cinza",
            "Preto",
            "Branco",
            "Azul Royal"});
            this.cboCores.Location = new System.Drawing.Point(370, 126);
            this.cboCores.Name = "cboCores";
            this.cboCores.Size = new System.Drawing.Size(202, 32);
            this.cboCores.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboCores);
            this.Controls.Add(this.cboCarros);
            this.Controls.Add(this.btnEscolha);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblCores);
            this.Controls.Add(this.lblCarros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarros;
        private System.Windows.Forms.Label lblCores;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEscolha;
        private System.Windows.Forms.ComboBox cboCarros;
        private System.Windows.Forms.ComboBox cboCores;
    }
}

