using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAux.Util
{
    public class FilesMetodosUtil
    {

        public static string ConvertFileToBase64(string filename)
        {
            if (filename != string.Empty && File.Exists(filename))
            {
                var bytes = File.ReadAllBytes(filename);
                return Convert.ToBase64String(bytes);
            }
            return "";
        }
    }
}
