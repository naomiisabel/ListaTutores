using ListaTutores.modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTutores.DATOS
{
    class TutorCAD
    {
        public static bool Guardar(Tutor e)
        {
            try
            {
                CONEXION con = new CONEXION();
                string sql = "INSERT INTO tb_Tutores values('"+e.ID_TUTOR1+"','"+e.NOMBRES1+"','"+e.APELLIDOS1+"','"+e.TITULO_ACADEMICO1+"','"+e.DIRECCION1+"','"+e.FECHA_NACIMIENTO1+"')";
                SqlCommand comando = new SqlCommand(sql,con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    return true;
                }
                else return false;

                con.desconectar();
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public static DataTable Listar()
        {
            try
            {
                CONEXION con = new CONEXION();
                string sql = "SELECT * FROM tb_Tutores ";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);

                con.desconectar();

                return dt;

                
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static Tutor Consultar(string ID_TUTOR)
        {
            try
            {
                CONEXION con = new CONEXION();
                string sql = "SELECT * FROM tb_Tutores WHERE id_tutor ='" + ID_TUTOR + "';";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader();
                
                Tutor eM = new Tutor();
                if (dr.Read())
                {
                    eM.ID_TUTOR1 = dr["ID_TUTOR"].ToString();
                    eM.NOMBRES1 = dr["NOMBRES"].ToString();
                    eM.APELLIDOS1 = dr["APELLIDOS"].ToString();
                    eM.TITULO_ACADEMICO1 = dr["TITULO_ACADEMICO"].ToString();
                    eM.DIRECCION1 = dr["DIRECCION"].ToString();
                    eM.FECHA_NACIMIENTO1 = dr["FECHA_NACIMIENTO"].ToString();
                    con.desconectar();
                    return eM;
                }
                else
                {

                    con.desconectar();
                    return null;
                }


            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static bool Actualizar(Tutor e)
        {
            try
            {
                CONEXION con = new CONEXION();
                string sql = "UPDATE tb_Tutores SET nombres='" + e.NOMBRES1 + "',APELLIDOS='" + e.APELLIDOS1 + "',TITULO_ACADEMICO='" + e.TITULO_ACADEMICO1 + "',DIRECCION='" + e.DIRECCION1 + "',FECHA_NACIMIENTO='" + e.FECHA_NACIMIENTO1+ "' where ID_TUTOR='" + e.ID_TUTOR1+ "'";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    return true;
                }
                else
                {
                    con.desconectar();
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool Eliminar(string ID_TUTOR)
        {
            try
            {
                CONEXION con = new CONEXION();
                string sql = "DELETE FROM tb_Tutores where ID_TUTOR='" + ID_TUTOR + "'";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    return true;
                }
                else
                {
                    con.desconectar();
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
