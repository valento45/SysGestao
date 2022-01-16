using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Access.Segurança
{

    public class Security
    {
        private static Security instance;

        private RijndaelManaged Algorithm;

        private Security()
        {
            Algorithm = new RijndaelManaged();
            Algorithm.GenerateKey();
        }

        public string Encrypt(string s)
        {
            if (s == null || s.Trim().Length == 0)
                return string.Empty;

            MemoryStream memStream;
            ICryptoTransform EncryptorDecryptor;
            CryptoStream crStream;
            StreamWriter strWriter;
            string pwd_str;
            byte[] pwd_byte;

            memStream = new MemoryStream();

            EncryptorDecryptor = Algorithm.CreateEncryptor();

            crStream = new CryptoStream(memStream, EncryptorDecryptor, CryptoStreamMode.Write);

            strWriter = new StreamWriter(crStream);

            strWriter.Write(s);

            strWriter.Flush();
            crStream.FlushFinalBlock();

            pwd_byte = new byte[memStream.Length];
            memStream.Position = 0;
            memStream.Read(pwd_byte, 0, (int)pwd_byte.Length);

            pwd_str = new UnicodeEncoding().GetString(pwd_byte);

            return pwd_str;
        }

        public void NewKey()
        {
            Algorithm.GenerateKey();
        }

        public string Decrypt(string s)
        {
            if (s == null || s.Trim().Length == 0)
                return string.Empty;
            MemoryStream memStream = new MemoryStream(new UnicodeEncoding().GetBytes(s));

            ICryptoTransform EncryptorDecryptor = Algorithm.CreateDecryptor();
            memStream.Position = 0;
            CryptoStream crStream = new CryptoStream(memStream, EncryptorDecryptor, CryptoStreamMode.Read);
            StreamReader strReader = new StreamReader(crStream);

            return strReader.ReadToEnd();
        }

        public static Security Cryption
        {
            get
            {
                if (instance == null)
                {
                    instance = new Security();
                }
                return instance;
            }
        }
    }
}
