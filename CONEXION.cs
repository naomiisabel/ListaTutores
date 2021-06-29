using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTutores.DATOS
{
    class CONEXION
    {
        SqlConnection con;
        public CONEXION()
        {
            con = new SqlConnection("Server=DESKTOP-P00P1CC;Database=Tutores_db;integrated security=true");
        
        }
        public SqlConnection conectar()
        {
            try
            {
                con.Open();
                return con;
            }
            catch(Exception e)
            {
                return null;
            }
            
        }
        public bool desconectar()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

    }
}
