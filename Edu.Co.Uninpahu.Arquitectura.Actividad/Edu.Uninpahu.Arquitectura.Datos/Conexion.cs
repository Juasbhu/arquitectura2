using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Edu.Uninpahu.Arquitectura.Datos
{
    public class Conexion
    {
        private string msg;
        SqlConnection conn =  new SqlConnection(
            Properties.Settings.Default.FacturacionConnectionString);
        SqlCommand cmd = new SqlCommand();
        public bool Conectar()
        {
            try
            {
                conn.Open();
                msg = "Conexión Exitosa";
                return true;

            }
            catch (Exception ex)
            {
                msg = "Conexión Fallida: " + ex;
                return false;
            }
        }

        public bool EjecutarQuery(string sql)
        {
            //if (veces == 0)
            //{
            //    conn.Open();
            //    veces = 1;
            //}
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                msg = "Sentencia Ejecutada Exitosamente";
                //conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                msg = "Error al ejecutar instrucción SQL: " + ex;
                return false;
            }
        }

        public bool CerrarConexion()
        {
            try
            {
                conn.Close();
                //this.msg = "Conexión Cerrada";
                return true;
            }
            catch (Exception ex)
            {
                msg = "Conexión Fallida: " + ex;
                return false;
            }
        }

        public void ConsultaDataTable(DataGridView dgv, string sql)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                //CerrarConexion();
            }
            catch (Exception ex)
            {
                msg = "Error al ejecutar consulta: " + ex;
                //CerrarConexion();
            }

        }

        public DataTable ConsultaData(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                msg = "Error al ejecutar consulta: " + ex;
            }
            return dt;
        }

        //public List<Object> ConsultaDatos(string sql)
        //{
        //    cmd = new SqlCommand(sql, conn);
        //    try
        //    {
        //        SqlDataReader lista = cmd.ExecuteReader();

        //        while (lista.Read())
        //        { 

        //        }

        //        List<Object> obList = lista.Read();

        //    }
        //    catch (Exception ex)
        //    {
        //        msg = "Error al ejecutar consulta: " + ex;
        //    }

        //}
        public string GetMessage()
        {
            return msg;
        }
        
        public bool BuscarPorId(string sql)
        {
            //if (veces == 0)
            //{
            //    conn.Open();
            //    veces = 1;
            //}
            //if (veces == 1)
            //{
            //    veces = 0;
            //}
            cmd = new SqlCommand(sql, conn);
            try
            {
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                msg = "Sentencia Ejecutada Exitosamente";
                
                if (count == 0)
                {
                    return false;
                }
                else {
                    //conn.Close();
                    //veces = 0;
                    return true;
                }
                
            }
            catch (Exception ex)
            {
                msg = "Error al ejecutar instrucción SQL: " + ex;
                return false;
            }
        }

        //public bool ValidarPorID(string sql)
        //{
        //    cmd = new SqlCommand(sql, conn);
        //    try
        //    {
        //        if (cmd.ExecuteScalar() != null)
        //        {
        //            msg = "Existe";
        //            CerrarConexion();
        //            return true;
        //        }
        //        else {
        //            msg = "NO Existe";
        //            CerrarConexion();
        //            return false;
        //        }
                
        //    }
        //    catch (Exception ex)
        //    {
        //        if (ex == null) {
        //            return false;
        //        }
        //        msg = "Error al ejecutar instrucción SQL: " + ex;
        //        return false;
        //    }
        //}
        /*
        public string ConectarGetMessage()
        {
            string msg= "";
            switch (this.idmsg)
            {
                case 1:
                    msg = "Conexión Exitosa";
                    break;
                case 2:
                    msg = "Error al conectar";
                    break;
                case 3:
                    msg = "Conexión Finalizada";
                    break;
                default:
                    msg = "";
                    break;
            }
            return msg;
        }*/
    }
}

