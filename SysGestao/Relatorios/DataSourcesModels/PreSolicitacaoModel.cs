using SysAux.ObjetosDestinatario;
using SysGestao_BE.SolicitacaoProdut;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SysGestao.Relatorios.DataSourcesModels
{
    public class PreSolicitacaoModel
    {
        public int IdSolicitacao { get; set; }
        public Destinatario Destinatario
        {
            get
            {
                if (_destinatario == null)
                {

                }
                return _destinatario;
            }
            set { _destinatario = value; }
        }
        private Destinatario _destinatario { get; set; }
        public List<ItemSolicitacaoModel> Itens
        {
            get
            {
                if (_itens == null)
                {
                    if (IdSolicitacao > 0)
                    {
                        _itens = ItemSolicitacaoModel.GetByIdSolicitacao(IdSolicitacao);
                    }
                }
                return _itens;
            }
            set { _itens = value; }
        }
        private List<ItemSolicitacaoModel> _itens = new List<ItemSolicitacaoModel>();
        public string Status { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public string PeriodoText { get; set; }

        public string GetNomeDestinatario()
        {
            return Destinatario?.Nome;
        }

        public PreSolicitacaoModel()
        {

        }
        public PreSolicitacaoModel(DataRow dr)
        {
            int id;
            if (int.TryParse(dr["id_pre_solicitacao"].ToString(), out id))
                IdSolicitacao = id;

            string nomeCliente = dr["nome_destinatario"].ToString();
            if (nomeCliente.Trim() != string.Empty)
                _destinatario = new Destinatario(nomeCliente);

            if (_itens == null)
                _itens = new List<ItemSolicitacaoModel>();

            _itens.Add(new ItemSolicitacaoModel(dr));
        }
        public static PreSolicitacaoModel GetPreSolicitacao(PreSolicitacao obj)
        {
            if (obj != null)
            {
                PreSolicitacaoModel result = new PreSolicitacaoModel
                {
                    IdSolicitacao = obj.Id,
                    Destinatario = obj.Destinatario,
                    Itens = ItemSolicitacaoModel.ConvertObj(obj.Produtos),
                    DataSolicitacao = obj.DataSolicitacao
                };
                return result;
            }
            return null;
        }
    }
}
