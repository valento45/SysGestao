using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.PostgresSQL
{
    public class Config
    {
        public static string IPServer { get; set; } = "localhost";
        public static int Port { get; set; } = 5432;
        public static string DBName { get; set; } = "sysgestao";
        public static int MaxPool { get; set; } = 100;
        public static int TimeOut { get; set; } = 0;
        public static string UserID { get; set; } = "postgres";
        public static string UserPassword { get; set; } = "admin";
        public static string Host { get; set; } = "localhost";
    }
}
