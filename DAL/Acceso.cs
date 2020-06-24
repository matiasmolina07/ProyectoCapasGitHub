using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace DAL
{
    public class Acceso
    {

        #region -------------   ACCESO UTILIZADO PARA  SQL EMB   --------------- 
        

        //Declaro el objeto de conexion
        private SqlConnection conexion;


        //Metodo para Abrir la conexion
        public void Abrir()
        {
            conexion = new SqlConnection();

            conexion.ConnectionString = @"Data Source=DESKTOP-GV1UE1D\SQLEXPRESS;Initial Catalog=BD-TP1-LUG;Integrated Security=True";
            conexion.Open();
        }

        //Metodo para Cerrar La conexion y limpiarla
        public void Cerrar()
        {
            conexion.Close(); //cerramos la conexion y la limpiamos
            conexion.Dispose();
            conexion = null;
            GC.Collect();
        }

        //Metodo de Testing de conexion
        public string TestConexion()
        {
            Abrir();
            if(conexion.State == ConnectionState.Open)
            {
                return "Conexion Abierta Correctamente";
            }
            else
            {
                return "La Conexion no esta Abierta";
            }

        }

        //Funcion para el DataTable
        public DataTable Leer (string consulta)
        {
            DataTable dt = new DataTable();
            try
            {
                //Abrimos la conexion
                Abrir();

                //Creamos el Data Adapter y le pasamos los datos
                SqlDataAdapter Da = new SqlDataAdapter(consulta, conexion);
                
                //Llenamos la Tabla
                Da.Fill(dt);
                
                //Cerramos la conexion
                Cerrar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
            return dt;
        }

        //Creamos Metodo generico para Escribir la BD 
        public int Escribir(string SQL)
        {
            int filaAfect = 0;

            Abrir();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;
            cmd.CommandText = SQL;

            try
            {
                filaAfect = cmd.ExecuteNonQuery();
            }
            catch { filaAfect = -1; }

            Cerrar();

            return filaAfect;
        }

        #endregion

      
    }

 



}
