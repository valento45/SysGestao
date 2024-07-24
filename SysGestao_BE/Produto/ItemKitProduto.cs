using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao_BE.Produto
{
    public class ItemKitProduto : IEqualityComparer<ItemKitProduto>
    {


        private Produto _kit { get; set; }
        private Produto _itemKit { get; set; }


        /// <summary>
        /// ID do Produto que seja o KIT
        /// </summary>
        public int IdKitProduto { get; set; }


        /// <summary>
        /// ID do produto contido no KIT 
        /// </summary>
        public int IdItemKit { get; set; }

        public int Quantidade { get; set; }



        public Produto Kit
        {
            get
            {
                if (IdKitProduto > 0)
                {
                    _kit = Produto.GetById(IdKitProduto);
                }
                return _kit;
            }
            set
            {

                _kit = value;
            }
        }


        public Produto ItemKit
        {
            get
            {
                if (IdItemKit > 0 && _itemKit == null)
                {
                    _itemKit = Produto.GetById(IdItemKit);
                }

                return _itemKit;
            }
            set
            {

                _itemKit = value;
            }
        }

        #region Construtores
        public ItemKitProduto()
        {

        }

        public ItemKitProduto(DataRow dr)
        {
            IdKitProduto = int.Parse(dr["id_produto_kit"].ToString());
            IdItemKit = int.Parse(dr["id_produto_item"].ToString());
            Quantidade = int.Parse(dr["quantidade"].ToString());
        }
        #endregion

        #region Metodos Publicos

        public bool Equals(ItemKitProduto x, ItemKitProduto y)
        {
            return x.IdItemKit == y.IdItemKit;
        }

        public int GetHashCode(ItemKitProduto obj)
        {
            return
                obj.IdItemKit.GetHashCode() +
                obj.IdKitProduto.GetHashCode();
        }

        #endregion
    }
}
