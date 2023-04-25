using SysAux.Interfaces;
using SysAux.ObjetosDestinatario;
using SysAux.Response;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SysAux.Util.Xml
{
    public class XmlDocumentUtil
    {
        private static List<char> _separadores = new List<char>() { ',' };



        private static Destinatario GetDestinatario(XmlDocument xmlDocument)
        {
            Destinatario destinatario = null;
            XmlNodeList xmlNodeList = xmlDocument.GetElementsByTagName("dest");

            if (xmlNodeList?.Count > 0)
            {
                destinatario = new Destinatario();
                foreach (XmlNode elem in xmlNodeList[0].ChildNodes)
                {

                    if (elem.Name == "xNome")
                        destinatario.Nome = elem.InnerText;

                    else if (elem.Name == "CPF")
                        destinatario.CpfCnpj = long.Parse(elem.InnerText);

                    else if (elem.Name == "enderDest")
                        destinatario.Endereco = GetEndereco(elem);

                }
            }

            return destinatario;
        }

        private static string GetEndereco(XmlNode xmlNode)
        {
            string endereco = "", nmr = "", bairro = "", cidade = "", UF = "", CEP = "";

            foreach (XmlNode elem in xmlNode.ChildNodes)
            {
                if (elem.Name == "xLgr")
                    endereco = elem.InnerText;

                else if (elem.Name == "nro")
                    nmr = elem.InnerText;

                else if (elem.Name == "xBairro")
                    bairro = elem.InnerText;

                else if (elem.Name == "xMun")
                    cidade = elem.InnerText;

                else if (elem.Name == "UF")
                    UF = elem.InnerText;

                else if (elem.Name == "CEP")
                    CEP = elem.InnerText;
            }


            return $"{endereco}, {nmr} - {bairro} - {cidade} - {UF}, {CEP}";
        }

        private static List<ProdutoResponse> GetProdutos(XmlDocument xmlDocument)
        {
            var result = new List<ProdutoResponse>();

            XmlNodeList xmlNodeList = xmlDocument.GetElementsByTagName("infNFe");

            foreach (XmlNode elem in xmlNodeList[0].ChildNodes)
            {
                ///Verifica se o nome do elemento é o nome esperado para a tag produto (det)
                if (elem.Name == "det")
                {
                    var xmlNodeProduto = elem.FirstChild;
                    var prd = new ProdutoResponse();

                    foreach (XmlNode subElem in xmlNodeProduto.ChildNodes)
                    {
                        if (subElem.Name == "cProd")
                            prd.CodigoSKU = subElem.InnerText;

                        else if (subElem.Name == "xProd")
                        {
                            prd.Descricao = subElem.InnerText.Trim();
                            prd.Variacao = TrataDescricaoProduto(prd.Descricao, _separadores);
                        }

                        else if (subElem.Name == "qCom")
                            prd.Quantidade = int.Parse(subElem.InnerText.Substring(0, subElem.InnerText.IndexOf(".")));
                    }
                    result.Add(prd);
                }
            }

            return result;
        }



        public static Solicitacao LerXML(string caminhoArquivo)
        {
            Solicitacao solicitacao = new Solicitacao();

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(caminhoArquivo);

            solicitacao.Destinatario = GetDestinatario(xmlDocument);
            solicitacao.Produtos = GetProdutos(xmlDocument);
            return solicitacao;
        }

        public static string TrataDescricaoProduto(string informacoes, List<char> separadores)
        {
            var infos_separators = informacoes.Split(separadores.ToArray());
            infos_separators = infos_separators.Where(x => x != "Tamanho").ToArray();

            string variacao = "";
            variacao = infos_separators.Length > 0 ? string.Join(",", infos_separators.Where(x => x != infos_separators?[0]).ToArray())
               : variacao;

            return variacao;
        }
    }
}
