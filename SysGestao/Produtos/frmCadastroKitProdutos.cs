using SysAux.Interfaces;
using SysGestao.Configuracoes.Marketplaces;
using SysGestao_BE.Configuracoes;
using SysGestao_BE.Produto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestao.Produtos
{
    public partial class frmCadastroKitProdutos : frmDefault
    {
        public Produto KitProdutos { get; set; }
        private bool IsNovo { get; set; }

        public frmCadastroKitProdutos()
        {
            InitializeComponent();

            KitProdutos = new Produto()
            {
                IsKit = true,
                ItensKit = new List<ItemKitProduto>()
            };
            IsNovo = true;
        }


        public frmCadastroKitProdutos(Produto kitProdutos, bool isNovo = false)
        {
            InitializeComponent();

            KitProdutos = kitProdutos;
            IsNovo = isNovo;
        }



        private void btBuscarItem_Click(object sender, EventArgs e)
        {
            using (frmConsultarProdutos frm = new frmConsultarProdutos(true))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    AdicionarItem(frm.ProdutoSelecionado);
                }
            }
        }

        private void AdicionarItem(Produto produto)
        {
            if (produto != null)
            {
                ItemKitProduto item = new ItemKitProduto { IdItemKit = produto.Id, ItemKit = produto };

                if (KitProdutos.ItensKit.Any(param => param.IdItemKit == item.IdItemKit))
                {
                    MessageBox.Show("Este Item já foi adicionado!\r\nVocê pode alterar a quantidade na coluna respectiva do item desejado para adicionar ou subtrair unidades.",
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    KitProdutos.ItensKit.Add(item);
                    dgvProdutos.Rows.Add(item.IdItemKit, produto.CodigoSKU, produto.Cor, produto.Tamanho, 1, produto.Variacao, produto.Descricao, item);
                }
            }
        }

        private void RemoverItem()
        {
            if (dgvProdutos.RowCount > 0 && KitProdutos.ItensKit.Any())
            {
                var itemSelect = dgvProdutos.SelectedCells[colObj.Index].Value as ItemKitProduto;

                if (itemSelect != null)
                {
                    if (MessageBox.Show($"Deseja remover o item: {itemSelect.ItemKit.Nome} - {itemSelect.ItemKit.CodigoSKU} ", "Excluir item ?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (KitProdutos.RemoverItemKit(itemSelect))
                        {
                            KitProdutos.ItensKit.Remove(itemSelect);
                            dgvProdutos.Rows.RemoveAt(dgvProdutos.CurrentRow.Index);
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível excluir o item do KIT, pois este KIT está associado a uma venda !\r\n\r\nExclua todas s vendas associadas a este kit para poder prosseguir.",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RemoverItem();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btConfiguracaoSKUMarketplace_Click(object sender, EventArgs e)
        {
            if (KitProdutos?.Id > 0)
            {
                using (frmConfiguraSKUMarketplace frm =
                    new frmConfiguraSKUMarketplace(ConfiguracoesMarketplaceBE.GetMarketplaces(), KitProdutos.Id))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                if (MessageBox.Show("O produto precisa estar salvo para poder configurar as informações de Marketplace's !\r\n\r\n" +
                    "Deseja salvar o produto agora ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    btSalvar.PerformClick();
                }
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (Salvar())
                MessageBox.Show("Dados salvos com sucesso !", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool Salvar()
        {
            try
            {
                if (KitProdutos == null)
                    KitProdutos = new Produto() { IsKit = true, ItensKit = new List<ItemKitProduto>() };

                KitProdutos.Nome = txtNome.Text.Trim();
                KitProdutos.CodigoSKU = txtCodigoSKU.Text.Trim();
                KitProdutos.Localizacao = txtLocalizacao.Text.Trim();
                KitProdutos.Variacao = txtVariacao.Text.Trim();

                int qtd;
                if (int.TryParse(txtQuantidade.Value.ToString(), out qtd))
                    KitProdutos.Quantidade = qtd;

                KitProdutos.Descricao = txtDescricao.Text.Trim();

                if (!KitProdutos.InsertOrUpdate())
                    throw new Exception("Ocorreu um erro ao salvar o KIT de produtos !\r\n\r\n");

                KitProdutos.LimparItensKit();
                KitProdutos.ItensKit = ObterItens();
                

                foreach (var item in KitProdutos.ItensKit)
                {
                    item.IdKitProduto = KitProdutos.Id;
                    KitProdutos.InserirItemKit(item);
                }

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao salvar o produto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private List<ItemKitProduto> ObterItens()
        {
            var result = new List<ItemKitProduto>();


            foreach (DataGridViewRow row in dgvProdutos.Rows)
            {
                ItemKitProduto item = new ItemKitProduto();

                item = row.Cells[colObj.Index].Value as ItemKitProduto;

                int qtd;
                if (int.TryParse(row.Cells[colQuantidade.Index].Value.ToString(), out qtd))
                    item.Quantidade = qtd;

                result.Add(item);
            }


            return result;
        }

        private void frmCadastroKitProdutos_Load(object sender, EventArgs e)
        {
            if (!IsNovo && KitProdutos != null)
                PreencherCampos();
        }

        private void PreencherCampos()
        {
            txtNome.Text = KitProdutos.Nome;
            txtCodigoSKU.Text = KitProdutos.CodigoSKU;
            txtLocalizacao.Text = KitProdutos.Localizacao;
            txtVariacao.Text = KitProdutos.Variacao;
            txtQuantidade.Value = KitProdutos.Quantidade;
            txtDescricao.Text = KitProdutos.Descricao;

            dgvProdutos.Rows.Clear();
            foreach (var item in KitProdutos.ItensKit)
            {
                dgvProdutos.Rows.Add(item.IdItemKit, item.ItemKit.CodigoSKU, item.ItemKit.Cor,
                    item.ItemKit.Tamanho, item.Quantidade, item.ItemKit.Variacao, item.ItemKit.Descricao, item);

            }

        }
    }
}
