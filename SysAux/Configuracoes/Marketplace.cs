using SysAux.Configuracoes.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAux.Configuracoes
{
    public class Marketplace : IConfiguracaoMarketplaces, IEqualityComparer<Marketplace>
    {
        public int ID { get; set; }
        public string NomeMarketplace { get; set; }
       

        public Marketplace()
        {
            
        }

        public Marketplace(DataRow dr)
        {
            ID = int.Parse(dr["id_marketplace"].ToString());
            NomeMarketplace = dr["marketplace"].ToString();
        }

        public bool Equals(Marketplace x, Marketplace y)
        {
            return x.ID == y.ID;
        }

        public int GetHashCode(Marketplace obj)
        {
            return obj.ID.GetHashCode();
        }
    }
}
