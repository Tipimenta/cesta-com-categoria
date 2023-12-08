using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CestaLoja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCriarCesta_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();

            form2.Closed += (s, args) => this.Show();

            form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCestaMontada_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();

            form3.Closed += (s, args) => this.Show();

            form3.ShowDialog();
        }
    }
}
