namespace BRQ.Avaliacao.WinForms.RodrigoNettoOliveira
{
    partial class frmLeitorDeArquivos
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnIniciar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnParar = new System.Windows.Forms.ToolStripButton();
            this.lblArquivoEntrada = new System.Windows.Forms.Label();
            this.lblDiretorioSaida = new System.Windows.Forms.Label();
            this.lblLogExecucao = new System.Windows.Forms.Label();
            this.txtArquivoEntrada = new System.Windows.Forms.TextBox();
            this.txtDiretorioSaida = new System.Windows.Forms.TextBox();
            this.rtbLogExecucao = new System.Windows.Forms.RichTextBox();
            this.btnSelecione = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnIniciar,
            this.tsbtnParar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnIniciar
            // 
            this.tsbtnIniciar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnIniciar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnIniciar.Name = "tsbtnIniciar";
            this.tsbtnIniciar.Size = new System.Drawing.Size(43, 22);
            this.tsbtnIniciar.Text = "Iniciar";
            // 
            // tsbtnParar
            // 
            this.tsbtnParar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnParar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnParar.Name = "tsbtnParar";
            this.tsbtnParar.Size = new System.Drawing.Size(38, 22);
            this.tsbtnParar.Text = "Parar";
            // 
            // lblArquivoEntrada
            // 
            this.lblArquivoEntrada.AutoSize = true;
            this.lblArquivoEntrada.Location = new System.Drawing.Point(36, 38);
            this.lblArquivoEntrada.Name = "lblArquivoEntrada";
            this.lblArquivoEntrada.Size = new System.Drawing.Size(98, 13);
            this.lblArquivoEntrada.TabIndex = 1;
            this.lblArquivoEntrada.Text = "Arquivo de Entrada";
            // 
            // lblDiretorioSaida
            // 
            this.lblDiretorioSaida.AutoSize = true;
            this.lblDiretorioSaida.Location = new System.Drawing.Point(36, 85);
            this.lblDiretorioSaida.Name = "lblDiretorioSaida";
            this.lblDiretorioSaida.Size = new System.Drawing.Size(93, 13);
            this.lblDiretorioSaida.TabIndex = 2;
            this.lblDiretorioSaida.Text = "Diretório de Saída";
            // 
            // lblLogExecucao
            // 
            this.lblLogExecucao.AutoSize = true;
            this.lblLogExecucao.Location = new System.Drawing.Point(36, 140);
            this.lblLogExecucao.Name = "lblLogExecucao";
            this.lblLogExecucao.Size = new System.Drawing.Size(91, 13);
            this.lblLogExecucao.TabIndex = 3;
            this.lblLogExecucao.Text = "Log de Execução";
            // 
            // txtArquivoEntrada
            // 
            this.txtArquivoEntrada.Location = new System.Drawing.Point(36, 55);
            this.txtArquivoEntrada.Name = "txtArquivoEntrada";
            this.txtArquivoEntrada.ReadOnly = true;
            this.txtArquivoEntrada.Size = new System.Drawing.Size(560, 20);
            this.txtArquivoEntrada.TabIndex = 4;
            // 
            // txtDiretorioSaida
            // 
            this.txtDiretorioSaida.Location = new System.Drawing.Point(36, 102);
            this.txtDiretorioSaida.Name = "txtDiretorioSaida";
            this.txtDiretorioSaida.Size = new System.Drawing.Size(560, 20);
            this.txtDiretorioSaida.TabIndex = 5;
            // 
            // rtbLogExecucao
            // 
            this.rtbLogExecucao.Location = new System.Drawing.Point(36, 156);
            this.rtbLogExecucao.Name = "rtbLogExecucao";
            this.rtbLogExecucao.ReadOnly = true;
            this.rtbLogExecucao.Size = new System.Drawing.Size(607, 256);
            this.rtbLogExecucao.TabIndex = 6;
            this.rtbLogExecucao.Text = "";
            // 
            // btnSelecione
            // 
            this.btnSelecione.Location = new System.Drawing.Point(608, 52);
            this.btnSelecione.Name = "btnSelecione";
            this.btnSelecione.Size = new System.Drawing.Size(75, 23);
            this.btnSelecione.TabIndex = 7;
            this.btnSelecione.Text = "Selecione";
            this.btnSelecione.UseVisualStyleBackColor = true;
            // 
            // frmLeitorDeArquivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSelecione);
            this.Controls.Add(this.rtbLogExecucao);
            this.Controls.Add(this.txtDiretorioSaida);
            this.Controls.Add(this.txtArquivoEntrada);
            this.Controls.Add(this.lblLogExecucao);
            this.Controls.Add(this.lblDiretorioSaida);
            this.Controls.Add(this.lblArquivoEntrada);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmLeitorDeArquivos";
            this.Text = "Leitor de Arquivos";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnIniciar;
        private System.Windows.Forms.ToolStripButton tsbtnParar;
        private System.Windows.Forms.Label lblArquivoEntrada;
        private System.Windows.Forms.Label lblDiretorioSaida;
        private System.Windows.Forms.Label lblLogExecucao;
        private System.Windows.Forms.TextBox txtArquivoEntrada;
        private System.Windows.Forms.TextBox txtDiretorioSaida;
        private System.Windows.Forms.RichTextBox rtbLogExecucao;
        private System.Windows.Forms.Button btnSelecione;
    }
}

