using System;
using System.Collections;
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


    public partial class Form3 : Form
    {
        Listas lista;

        List<Produto> radio;
        public Form3()
        {
            InitializeComponent();
            lista = new Listas();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radio = lista.Lista_pais;
        }

        private void listDefinidas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            configuraListView();
        }

        void configuraListView()
        {
            listDefinidas.View = View.Details;
            listDefinidas.Columns.Add("ID");
            listDefinidas.Columns.Add("Nome");
            listDefinidas.Columns.Add("Preço");
            AtualizaListView(); //chama a função para atulizar o listview
        }

        void AtualizaListView() //recebe cada produto por paramentro
        {
            // Limpa os itens da lista
            listDefinidas.Items.Clear();


            // Percorre os itens da lista, adicionando no list View
            foreach (Produto produto in radio)
            {
                AdicionarItemListView(produto);
            }
        }

        void AdicionarItemListView(Produto produto)
        {
            ListViewItem item = new ListViewItem(produto.Id.ToString());
            item.SubItems.Add(produto.Nome);
            item.SubItems.Add(produto.Preco.ToString("c"));
            listDefinidas.Items.Add(item);

        }

        private void radioNatal_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radio = lista.Lista_maes;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radio = lista.Lista_namorados;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radio = lista.Lista_aniversario;
        }
    }
}