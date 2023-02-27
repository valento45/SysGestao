using Newtonsoft.Json;
using SysAux.LOGS;
using SysGestao_BE.Autenticacao.Enums;
using SysGestao_BE.Auxx;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using SysAux.Util;

namespace SysGestao_BE.Autenticacao
{
    public class Licensa : Path7<Licensa>
    {
        public static Licensa DadosLicensa;
        public static readonly string ContactLinkedinURL = "https://www.linkedin.com/in/igor-carvalho-022b9818b/";
        public static readonly string ContactGitHubURL = "";
        public string CodigoLicensa { get; set; }
        public DateTime DataExpiracao { get; set; }
        public TipoLicensa TipoLicensa { get; set; }


        public static string EncryptCodigoLicensa(string pass)
        {
            string EncryptionKey = "stv4!@#";
            byte[] clearBytes = Encoding.Unicode.GetBytes(pass);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    pass = Convert.ToBase64String(ms.ToArray());
                }
            }
            return pass;
        }

        public static string DecryptCodigoLicensa(string pass)
        {
            string EncryptionKey = "stv4!@#";
            //pass = pass.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(pass);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    pass = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return pass;
        }


        public static Licensa ObterLicensa()
        {
            Licensa result;
            try
            {
                string filename = GetFullPath();
                string base64 = File.ReadAllText(filename);

                if (base64 != string.Empty)
                {
                    var json = DecryptCodigoLicensa(base64);

                    result = JsonConvert.DeserializeObject<Licensa>(json);
                    return result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }



        public static bool AtualizarLicensa(Licensa licensa)
        {
            try
            {

                var json = JsonConvert.SerializeObject(licensa);

                var crypt = EncryptCodigoLicensa(json);

                File.WriteAllText(GetFullPath(), crypt);
                return true;
            }
            catch (Exception ex)
            {

                ExceptionLog.Insert(ex, "Falha ao atualizar licença!");
            }
            return false;
        }

        public bool IsValido() => DataExpiracao >= DateTime.Now;
    }
}
