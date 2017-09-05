namespace estatistica
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_menor = new System.Windows.Forms.TextBox();
            this.tb_maior = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tx_selecionados = new System.Windows.Forms.ToolStripStatusLabel();
            this.dg_numeros = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_separador = new System.Windows.Forms.TextBox();
            this.tb_entrada = new System.Windows.Forms.RichTextBox();
            this.tx_soma = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_numeros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entrada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Menor:";
            // 
            // tb_menor
            // 
            this.tb_menor.Location = new System.Drawing.Point(12, 139);
            this.tb_menor.Name = "tb_menor";
            this.tb_menor.ReadOnly = true;
            this.tb_menor.Size = new System.Drawing.Size(53, 20);
            this.tb_menor.TabIndex = 3;
            this.tb_menor.TabStop = false;
            // 
            // tb_maior
            // 
            this.tb_maior.Location = new System.Drawing.Point(83, 139);
            this.tb_maior.Name = "tb_maior";
            this.tb_maior.ReadOnly = true;
            this.tb_maior.Size = new System.Drawing.Size(53, 20);
            this.tb_maior.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Maior:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Gerar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tx_selecionados,
            this.tx_soma});
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tx_selecionados
            // 
            this.tx_selecionados.Name = "tx_selecionados";
            this.tx_selecionados.Size = new System.Drawing.Size(0, 17);
            // 
            // dg_numeros
            // 
            this.dg_numeros.AllowUserToAddRows = false;
            this.dg_numeros.AllowUserToDeleteRows = false;
            this.dg_numeros.AllowUserToResizeColumns = false;
            this.dg_numeros.AllowUserToResizeRows = false;
            this.dg_numeros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_numeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_numeros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dg_numeros.Location = new System.Drawing.Point(0, 165);
            this.dg_numeros.Name = "dg_numeros";
            this.dg_numeros.ReadOnly = true;
            this.dg_numeros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dg_numeros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_numeros.Size = new System.Drawing.Size(284, 235);
            this.dg_numeros.TabIndex = 5;
            this.dg_numeros.SelectionChanged += new System.EventHandler(this.dg_numeros_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Separador:";
            // 
            // tb_separador
            // 
            this.tb_separador.Location = new System.Drawing.Point(219, 29);
            this.tb_separador.MaxLength = 1;
            this.tb_separador.Name = "tb_separador";
            this.tb_separador.Size = new System.Drawing.Size(64, 20);
            this.tb_separador.TabIndex = 1;
            this.tb_separador.Text = ";";
            // 
            // tb_entrada
            // 
            this.tb_entrada.Location = new System.Drawing.Point(12, 29);
            this.tb_entrada.Name = "tb_entrada";
            this.tb_entrada.Size = new System.Drawing.Size(201, 62);
            this.tb_entrada.TabIndex = 0;
            this.tb_entrada.Text = "";
            // 
            // tx_soma
            // 
            this.tx_soma.Name = "tx_soma";
            this.tx_soma.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 422);
            this.Controls.Add(this.tb_entrada);
            this.Controls.Add(this.tb_separador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dg_numeros);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_maior);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_menor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Estatística";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_numeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_menor;
        private System.Windows.Forms.TextBox tb_maior;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tx_selecionados;
        private System.Windows.Forms.DataGridView dg_numeros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_separador;
        private System.Windows.Forms.RichTextBox tb_entrada;
        private System.Windows.Forms.ToolStripStatusLabel tx_soma;
    }
}

