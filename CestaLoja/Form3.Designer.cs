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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.listDefinidas = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(27, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "CESTAS PRÉ-DEFINIDAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton1.Location = new System.Drawing.Point(32, 461);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(262, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "CESTA DIA DOS PAIS";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton2.Location = new System.Drawing.Point(32, 496);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(272, 29);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "CESTA DIA DAS MAES";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton3.Location = new System.Drawing.Point(32, 531);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(311, 29);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "CESTA DOS NAMORADOS";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton4.Location = new System.Drawing.Point(32, 566);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(298, 29);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "CESTA DE ANIVERSARIO";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // listDefinidas
            // 
            this.listDefinidas.HideSelection = false;
            this.listDefinidas.Location = new System.Drawing.Point(32, 28);
            this.listDefinidas.Name = "listDefinidas";
            this.listDefinidas.Size = new System.Drawing.Size(313, 316);
            this.listDefinidas.TabIndex = 2;
            this.listDefinidas.UseCompatibleStateImageBehavior = false;
            this.listDefinidas.SelectedIndexChanged += new System.EventHandler(this.listDefinidas_SelectedIndexChanged);
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(606, 28);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(361, 606);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 665);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listDefinidas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioNatal);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioNatal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.ListView listDefinidas;
        private System.Windows.Forms.ListView listView2;
    }
}