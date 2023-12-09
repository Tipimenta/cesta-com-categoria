namespace CestaLoja
{
    partial class Form3
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
            this.radioNatal = new System.Windows.Forms.RadioButton();
            this.radioPais = new System.Windows.Forms.RadioButton();
            this.radioMaes = new System.Windows.Forms.RadioButton();
            this.radioNamorados = new System.Windows.Forms.RadioButton();
            this.radioAniversario = new System.Windows.Forms.RadioButton();
            this.listDefinidas = new System.Windows.Forms.ListView();
            this.listProdutos = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioNatal
            // 
            this.radioNatal.AutoSize = true;
            this.radioNatal.Checked = true;
            this.radioNatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNatal.ForeColor = System.Drawing.SystemColors.Control;
            this.radioNatal.Location = new System.Drawing.Point(32, 426);
            this.radioNatal.Name = "radioNatal";
            this.radioNatal.Size = new System.Drawing.Size(223, 29);
            this.radioNatal.TabIndex = 0;
            this.radioNatal.TabStop = true;
            this.radioNatal.Text = "CESTA DE NATAL";
            this.radioNatal.UseVisualStyleBackColor = true;
            this.radioNatal.CheckedChanged += new System.EventHandler(this.radioNatal_CheckedChanged);
            // 
            // radioPais
            // 
            this.radioPais.AutoSize = true;
            this.radioPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPais.ForeColor = System.Drawing.SystemColors.Control;
            this.radioPais.Location = new System.Drawing.Point(32, 461);
            this.radioPais.Name = "radioPais";
            this.radioPais.Size = new System.Drawing.Size(262, 29);
            this.radioPais.TabIndex = 0;
            this.radioPais.TabStop = true;
            this.radioPais.Text = "CESTA DIA DOS PAIS";
            this.radioPais.UseVisualStyleBackColor = true;
            this.radioPais.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioMaes
            // 
            this.radioMaes.AutoSize = true;
            this.radioMaes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMaes.ForeColor = System.Drawing.SystemColors.Control;
            this.radioMaes.Location = new System.Drawing.Point(32, 496);
            this.radioMaes.Name = "radioMaes";
            this.radioMaes.Size = new System.Drawing.Size(272, 29);
            this.radioMaes.TabIndex = 0;
            this.radioMaes.TabStop = true;
            this.radioMaes.Text = "CESTA DIA DAS MAES";
            this.radioMaes.UseVisualStyleBackColor = true;
            this.radioMaes.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioNamorados
            // 
            this.radioNamorados.AutoSize = true;
            this.radioNamorados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNamorados.ForeColor = System.Drawing.SystemColors.Control;
            this.radioNamorados.Location = new System.Drawing.Point(32, 531);
            this.radioNamorados.Name = "radioNamorados";
            this.radioNamorados.Size = new System.Drawing.Size(311, 29);
            this.radioNamorados.TabIndex = 0;
            this.radioNamorados.TabStop = true;
            this.radioNamorados.Text = "CESTA DOS NAMORADOS";
            this.radioNamorados.UseVisualStyleBackColor = true;
            this.radioNamorados.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioAniversario
            // 
            this.radioAniversario.AutoSize = true;
            this.radioAniversario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAniversario.ForeColor = System.Drawing.SystemColors.Control;
            this.radioAniversario.Location = new System.Drawing.Point(32, 566);
            this.radioAniversario.Name = "radioAniversario";
            this.radioAniversario.Size = new System.Drawing.Size(298, 29);
            this.radioAniversario.TabIndex = 0;
            this.radioAniversario.TabStop = true;
            this.radioAniversario.Text = "CESTA DE ANIVERSARIO";
            this.radioAniversario.UseVisualStyleBackColor = true;
            this.radioAniversario.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // listDefinidas
            // 
            this.listDefinidas.HideSelection = false;
            this.listDefinidas.Location = new System.Drawing.Point(32, 76);
            this.listDefinidas.Name = "listDefinidas";
            this.listDefinidas.Size = new System.Drawing.Size(313, 268);
            this.listDefinidas.TabIndex = 2;
            this.listDefinidas.UseCompatibleStateImageBehavior = false;
            this.listDefinidas.SelectedIndexChanged += new System.EventHandler(this.listDefinidas_SelectedIndexChanged);
            // 
            // listProdutos
            // 
            this.listProdutos.HideSelection = false;
            this.listProdutos.Location = new System.Drawing.Point(606, 76);
            this.listProdutos.Name = "listProdutos";
            this.listProdutos.Size = new System.Drawing.Size(361, 558);
            this.listProdutos.TabIndex = 3;
            this.listProdutos.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(36, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "CESTAS PRÉ-DEFINIDAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(395, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 103);
            this.button1.TabIndex = 4;
            this.button1.Text = "< --- Adicionar a Cesta";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(395, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 103);
            this.button2.TabIndex = 4;
            this.button2.Text = "--- > Remover da Cesta";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 665);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listProdutos);
            this.Controls.Add(this.listDefinidas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioAniversario);
            this.Controls.Add(this.radioNamorados);
            this.Controls.Add(this.radioMaes);
            this.Controls.Add(this.radioPais);
            this.Controls.Add(this.radioNatal);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioNatal;
        private System.Windows.Forms.RadioButton radioPais;
        private System.Windows.Forms.RadioButton radioMaes;
        private System.Windows.Forms.RadioButton radioNamorados;
        private System.Windows.Forms.RadioButton radioAniversario;
        private System.Windows.Forms.ListView listDefinidas;
        private System.Windows.Forms.ListView listProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}