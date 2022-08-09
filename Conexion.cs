using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia3_Tarea3NSB
{
    class Conexion
    {
        public string servidor, db;
        public bool security;
        public string cadena;

        public void conectar()
        {
            servidor = "DESKTOP-K8OJCDL\\SQLEXPRESS";
            db = "DB_Sucarnet";
            security = true;
            cadena = "Server = " + servidor + "; Initial Catalog = " + db + ";Integrated Security = " + security;
        }
    }
}
