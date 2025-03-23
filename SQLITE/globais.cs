using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLITE
{
    class Globais
    {
        public static string version = "1.0.0";
        public static string nameUser = "";
        public static bool logados = false;
        public static int nivel = 0;  // 0 = basic, 1 = user, 2 = admin
        public static string path = System.Environment.CurrentDirectory;
        public static string db = "bd_estudo.db";
        public static string dbPath = path +@"\banco\";

    }
}
