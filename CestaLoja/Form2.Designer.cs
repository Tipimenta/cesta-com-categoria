namespace CestaLoja
{
    partial class Form2
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
            this.listItens = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.listCesta = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.textValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listItens
            // 
            this.listItens.HideSelection = false;
            this.listItens.Location = new System.Drawing.Point(13, 93);
            this.listItens.Name = "listItens";
            this.listItens.Size = new System.Drawing.Size(344, 573);
            this.listItens.TabIndex = 0;
            this.listItens.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(386, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor Cesta";
            // 
            // listCesta
            // 
            this.listCesta.HideSelection = false;
            this.listCesta.Location = new System.Drawing.Point(615, 94);
            this.listCesta.Name = "listCesta";
            this.listCesta.Size = new System.Drawing.Size(344, 573);
            this.listCesta.TabIndex = 0;
            this.listCesta.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(29, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "ITENS DISPONIVEIS";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(393, 163);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(186, 120);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar Item";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Enabled = false;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(393, 301);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(186, 111);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "Remover Item";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // textValor
            // 
            this.textValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValor.ForeColor = System.Drawing.Color.Green;
            this.textValor.Location = new System.Drawing.Point(396, 554);
            this.textValor.Name = "textValor";
            this.textValor.ReadOnly = true;
            this.textValor.Size = new System.Drawing.Size(171, 53);
            this.textValor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Location = new System.Drawing.Point(616, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "ITENS SELECIONADOS";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(971, 679);
            this.Controls.Add(this.textValor);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listCesta);
            this.Controls.Add(this.listItens);
            this.Name = "Form2";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listItens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listCesta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.Label label3;
    }
}