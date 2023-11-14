using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using System.Net;

namespace Licoreria_FG
{
    class clsConexion
    {
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        //public void open()
        //{
        //    string nombre_servidor = Dns.GetHostName();
        //    cnx = new SqlConnection("Data Source= "+nombre_servidor+"\\SQLEXPRESS;Initial Catalog=Licoreria;Integrated Security=True");
        //    cnx.Open();
        //    MessageBox.Show("Se creo una conexion");
        //}

        //public void close()
        //{
        //    cnx.Close();
        //}
        public static SqlConnection conBase()
        {
            string nombre_servidor = Dns.GetHostName();
            SqlConnection cnx = new SqlConnection("Data Source= " + nombre_servidor + "\\SQLEXPRESS;Initial Catalog=Licoreria;Integrated Security=True");
            return cnx;
        }
        public void cargar(DataGridView dtgv, String sqlString)
        {
            SqlConnection con = conBase();
            con.Open();
            da = new SqlDataAdapter(sqlString, con);
            dt = new DataTable();
            da.Fill(dt);
            dtgv.DataSource = dt;
            con.Close();


        }
        
        
    }
}
