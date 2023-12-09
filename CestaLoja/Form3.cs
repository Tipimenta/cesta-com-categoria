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
            AtualizaListView(lista.Lista_pais);
            AtualizaListViewProdutos(lista.Lista_produtos, lista.Lista_pais);
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

            listProdutos.View = View.Details;
            listProdutos.Columns.Add("ID");
            listProdutos.Columns.Add("Nome");
            listProdutos.Columns.Add("Preço");

        }

        void AtualizaListView(List<Produto> lista) //recebe cada produto por paramentro
        {
            // Limpa os itens da lista
            listDefinidas.Items.Clear();

            // Percorre os itens da lista, adicionando no list View
            foreach (Produto produto in lista)
            {
                AdicionarItemListView(produto);
            }

        }

        void AtualizaListViewProdutos(List<Produto> listaproduto, List<Produto> lista) //recebe cada produto por paramentro
        {
            // Limpa os itens da lista
            listProdutos.Items.Clear();

            // Percorre os itens da lista, adicionando no list View
            foreach (Produto produto in listaproduto)
            {
                foreach (Produto definida in lista)
                {
                    if (produto.Id != definida.Id)
                    {
                        AdicionarItemListViewProdutos(produto);
                    }
                    else
                    {
                        break;
                    }
                    
                }
            }

        }

            void AdicionarItemListView(Produto produto)
        {
            ListViewItem item = new ListViewItem(produto.Id.ToString());
            item.SubItems.Add(produto.Nome);
            item.SubItems.Add(produto.Preco.ToString("c"));
            listDefinidas.Items.Add(item);

        }

        void AdicionarItemListViewProdutos(Produto produto)
        {
            
            ListViewItem item2 = new ListViewItem(produto.Id.ToString());
            item2.SubItems.Add(produto.Nome);
            item2.SubItems.Add(produto.Preco.ToString("c"));
            listProdutos.Items.Add(item2);
        }

        private void radioNatal_CheckedChanged(object sender, EventArgs e)
        {
            AtualizaListView(lista.Lista_natal);
            AtualizaListViewProdutos(lista.Lista_produtos, lista.Lista_natal);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            AtualizaListView(lista.Lista_maes);
            AtualizaListViewProdutos(lista.Lista_produtos, lista.Lista_maes);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
          AtualizaListView(lista.Lista_namorados);
          AtualizaListViewProdutos(lista.Lista_produtos, lista.Lista_namorados);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
          AtualizaListView(lista.Lista_aniversario);
          AtualizaListViewProdutos(lista.Lista_produtos, lista.Lista_aniversario);
        }
    }
}