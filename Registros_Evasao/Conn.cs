﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_registros_para_Hospitais
{
    internal class Conn
    {
        private static string server = @"DESKTOP-JTN552H\SQLEXPRESS";
        private static string dataBase = "CADASTRO_HOSPITAL";
        private static string user = "sa";
        private static string password = "05092002";

        public static string Strcon
        {
            get { return $"Data Source= {server}; Integrated Security=False; Initial Catalog= {dataBase};User ID={user}; Password={password}"; }
        }
    }
}
