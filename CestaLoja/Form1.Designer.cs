namespace CestaLoja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCriarCesta = new System.Windows.Forms.Button();
            this.btnCestaMontada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(712, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEJA BEM-VINDO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCriarCesta
            // 
            this.btnCriarCesta.BackColor = System.Drawing.Color.Transparent;
            this.btnCriarCesta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCriarCesta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarCesta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnCriarCesta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCriarCesta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCriarCesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarCesta.ForeColor = System.Drawing.Color.White;
            this.btnCriarCesta.Location = new System.Drawing.Point(26, 321);
            this.btnCriarCesta.Name = "btnCriarCesta";
            this.btnCriarCesta.Size = new System.Drawing.Size(212, 113);
            this.btnCriarCesta.TabIndex = 1;
            this.btnCriarCesta.Text = "Criar Cesta";
            this.btnCriarCesta.UseVisualStyleBackColor = false;
            this.btnCriarCesta.Click += new System.EventHandler(this.btnCriarCesta_Click);
            // 
            // btnCestaMontada
            // 
            this.btnCestaMontada.BackColor = System.Drawing.Color.Transparent;
            this.btnCestaMontada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCestaMontada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCestaMontada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnCestaMontada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCestaMontada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCestaMontada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCestaMontada.ForeColor = System.Drawing.Color.White;
            this.btnCestaMontada.Location = new System.Drawing.Point(553, 321);
            this.btnCestaMontada.Name = "btnCestaMontada";
            this.btnCestaMontada.Size = new System.Drawing.Size(268, 113);
            this.btnCestaMontada.TabIndex = 1;
            this.btnCestaMontada.Text = "Cestas Comemorativas";
            this.btnCestaMontada.UseVisualStyleBackColor = false;
            this.btnCestaMontada.Click += new System.EventHandler(this.btnCestaMontada_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 518);
            this.Controls.Add(this.btnCestaMontada);
            this.Controls.Add(this.btnCriarCesta);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCriarCesta;
        private System.Windows.Forms.Button btnCestaMontada;
    }
}

