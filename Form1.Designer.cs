namespace Sistema_Gerador_de_Relatorios_de_Produtos_Pre_Vencidos
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Relatorio_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtb_Nome_Produto = new System.Windows.Forms.TextBox();
            this.txtb_Cod_Produto = new System.Windows.Forms.TextBox();
            this.txtb_Lote = new System.Windows.Forms.TextBox();
            this.txtb_Quantidade = new System.Windows.Forms.TextBox();
            this.txtb_Validade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCadastrar_Produto = new System.Windows.Forms.Button();
            this.dadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarDados_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.dadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Relatorio_ToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // Relatorio_ToolStripMenuItem
            // 
            this.Relatorio_ToolStripMenuItem.Name = "Relatorio_ToolStripMenuItem";
            this.Relatorio_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.Relatorio_ToolStripMenuItem.Text = "Abrir Relatório";
            this.Relatorio_ToolStripMenuItem.Click += new System.EventHandler(this.Relatorio_ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Produto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código do Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lote:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantidade:";
            // 
            // txtb_Nome_Produto
            // 
            this.txtb_Nome_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Nome_Produto.Location = new System.Drawing.Point(153, 51);
            this.txtb_Nome_Produto.MaxLength = 200;
            this.txtb_Nome_Produto.Name = "txtb_Nome_Produto";
            this.txtb_Nome_Produto.Size = new System.Drawing.Size(268, 23);
            this.txtb_Nome_Produto.TabIndex = 0;
            // 
            // txtb_Cod_Produto
            // 
            this.txtb_Cod_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Cod_Produto.Location = new System.Drawing.Point(153, 90);
            this.txtb_Cod_Produto.MaxLength = 7;
            this.txtb_Cod_Produto.Name = "txtb_Cod_Produto";
            this.txtb_Cod_Produto.Size = new System.Drawing.Size(268, 23);
            this.txtb_Cod_Produto.TabIndex = 1;
            // 
            // txtb_Lote
            // 
            this.txtb_Lote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Lote.Location = new System.Drawing.Point(70, 125);
            this.txtb_Lote.MaxLength = 200;
            this.txtb_Lote.Name = "txtb_Lote";
            this.txtb_Lote.Size = new System.Drawing.Size(351, 23);
            this.txtb_Lote.TabIndex = 2;
            // 
            // txtb_Quantidade
            // 
            this.txtb_Quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Quantidade.Location = new System.Drawing.Point(116, 159);
            this.txtb_Quantidade.MaxLength = 30000;
            this.txtb_Quantidade.Name = "txtb_Quantidade";
            this.txtb_Quantidade.Size = new System.Drawing.Size(83, 23);
            this.txtb_Quantidade.TabIndex = 3;
            this.txtb_Quantidade.TextChanged += new System.EventHandler(this.txtb_Quantidade_TextChanged);
            // 
            // txtb_Validade
            // 
            this.txtb_Validade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Validade.Location = new System.Drawing.Point(97, 196);
            this.txtb_Validade.MaxLength = 10;
            this.txtb_Validade.Name = "txtb_Validade";
            this.txtb_Validade.Size = new System.Drawing.Size(123, 23);
            this.txtb_Validade.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Validade:";
            // 
            // btnCadastrar_Produto
            // 
            this.btnCadastrar_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar_Produto.Location = new System.Drawing.Point(27, 257);
            this.btnCadastrar_Produto.Name = "btnCadastrar_Produto";
            this.btnCadastrar_Produto.Size = new System.Drawing.Size(154, 23);
            this.btnCadastrar_Produto.TabIndex = 5;
            this.btnCadastrar_Produto.Text = "Cadastrar Produto";
            this.btnCadastrar_Produto.UseVisualStyleBackColor = true;
            this.btnCadastrar_Produto.Click += new System.EventHandler(this.Cadastrar_Produto_Click);
            // 
            // dadosToolStripMenuItem
            // 
            this.dadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apagarDados_Click});
            this.dadosToolStripMenuItem.Name = "dadosToolStripMenuItem";
            this.dadosToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.dadosToolStripMenuItem.Text = "Dados";
            // 
            // apagarDados_Click
            // 
            this.apagarDados_Click.Name = "apagarDados_Click";
            this.apagarDados_Click.Size = new System.Drawing.Size(180, 22);
            this.apagarDados_Click.Text = "Apagar dados...";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 305);
            this.Controls.Add(this.btnCadastrar_Produto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtb_Validade);
            this.Controls.Add(this.txtb_Quantidade);
            this.Controls.Add(this.txtb_Lote);
            this.Controls.Add(this.txtb_Cod_Produto);
            this.Controls.Add(this.txtb_Nome_Produto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gerador de Relatórios de Produtos Pré-Vencidos - SGRPPV";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Relatorio_ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtb_Nome_Produto;
        private System.Windows.Forms.TextBox txtb_Cod_Produto;
        private System.Windows.Forms.TextBox txtb_Lote;
        private System.Windows.Forms.TextBox txtb_Quantidade;
        private System.Windows.Forms.TextBox txtb_Validade;
        private System.Windows.Forms.Button btnCadastrar_Produto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem dadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apagarDados_Click;
    }
}

