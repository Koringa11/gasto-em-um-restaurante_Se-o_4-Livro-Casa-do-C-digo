
namespace gasto_em_um_restaurante
{
    partial class FormGastoEmRestaurante
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtDespesa = new System.Windows.Forms.TextBox();
            this.txtTotalDaConta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDespesa
            // 
            this.txtDespesa.Location = new System.Drawing.Point(82, 24);
            this.txtDespesa.Name = "txtDespesa";
            this.txtDespesa.Size = new System.Drawing.Size(100, 20);
            this.txtDespesa.TabIndex = 1;
            this.txtDespesa.TextChanged += new System.EventHandler(this.txtDespesa_TextChanged);
            // 
            // txtTotalDaConta
            // 
            this.txtTotalDaConta.BackColor = System.Drawing.Color.Yellow;
            this.txtTotalDaConta.Enabled = false;
            this.txtTotalDaConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDaConta.Location = new System.Drawing.Point(105, 63);
            this.txtTotalDaConta.Name = "txtTotalDaConta";
            this.txtTotalDaConta.Size = new System.Drawing.Size(158, 20);
            this.txtTotalDaConta.TabIndex = 2;
            this.txtTotalDaConta.TextChanged += new System.EventHandler(this.txtTotalDaConta_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(22, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total com 10%";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Despesa:";
            // 
            // FormGastoEmRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 105);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalDaConta);
            this.Controls.Add(this.txtDespesa);
            this.Controls.Add(this.button1);
            this.Name = "FormGastoEmRestaurante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gasto em Restaurante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDespesa;
        private System.Windows.Forms.TextBox txtTotalDaConta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

