using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CestaLoja
{

    
    public partial class Form2 : Form
    {

        Listas lista;

        public Form2()
        {
            InitializeComponent();
            lista = new Listas();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            configuraListView();
        }

        void configuraListView()
        {
            listItens.View = View.Details;
            listItens.Columns.Add("ID");
            listItens.Columns.Add("Nome");
            listItens.Columns.Add("Preço");
            AtualizaListView(); //chama a função para atulizar o listview

            listCesta.View = View.Details;
            listCesta.Columns.Add("ID");
            listCesta.Columns.Add("Nome");
            listCesta.Columns.Add("Preço");
            AtualizaListView(); //chama a função para atulizar o listview
        }

        void AtualizaListView() //recebe cada produto por paramentro
        {
            // Limpa os itens da lista
            listItens.Items.Clear();
            listCesta.Items.Clear();

            // Percorre os itens da lista, adicionando no list View
            foreach (Produto produto in lista.Lista_produtos)
            {
                AdicionarItemListView(produto);
            }

            foreach (Produto produto in lista.Lista_cesta)
            {
                AdicionarItemListViewCesta(produto);
            }
        }   

        void AdicionarItemListView(Produto produto)
        {
            ListViewItem item = new ListViewItem(produto.Id.ToString());
            item.SubItems.Add(produto.Nome);
            item.SubItems.Add(produto.Preco.ToString("c"));
            listItens.Items.Add(item);
           
        }

        void AdicionarItemListViewCesta(Produto produto)
        {
            ListViewItem item = new ListViewItem(produto.Id.ToString());
            item.SubItems.Add(produto.Nome);
            item.SubItems.Add(produto.Preco.ToString("c"));
            listCesta.Items.Add(item);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listItens.SelectedItems)
            {
                int id = int.Parse(item.Text);

                Produto produto = lista.Lista_produtos.Find(prod => prod.Id == id);

                lista.Lista_cesta.Add(produto);
                lista.Lista_produtos.Remove(produto);
                CalcularCesta(produto);
            }

            btnRemover.Enabled = true;
            AtualizaListView();

        }

        string CalcularCesta(Produto produto)
        {
            decimal somaDosValores = 0;
            foreach (Produto item in lista.Lista_cesta)
            {
                somaDosValores += item.Preco;
            }

            // Atualize o campo textValor com a soma dos valores dos produtos
            return textValor.Text = somaDosValores.ToString("c");
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listCesta.SelectedItems)
            {
                int id = int.Parse(item.Text);

                Produto produto = lista.Lista_cesta.Find(prod => prod.Id == id);

                lista.Lista_cesta.Remove(produto);
                lista.Lista_produtos.Add(produto);
                CalcularCesta(produto);
            }

            AtualizaListView();
        }
    }
}
