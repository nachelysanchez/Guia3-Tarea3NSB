using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia3_Tarea3NSB
{
    public partial class Form2 : Form
    {
        private SqlConnection conn;
        private SqlCommand insert1;
        private string sCn;
        public Form2()
        {
            InitializeComponent();

            Conexion conexion = new Conexion();
            conexion.conectar();

            sCn = conexion.cadena;

            conn = new SqlConnection(sCn);

            conn.Open();
        }
    }
}
