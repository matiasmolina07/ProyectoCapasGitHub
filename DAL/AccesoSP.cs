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
    public class AccesoSP
    {
        #region --------------  ACCESO UTILIZADO PARA SP ---------------

        //Cadena de Conexion para SP
        public class CD_Conexion
        {

        

            private SqlConnection Conexion = new SqlConnection(@"Server=DESKTOP-GV1UE1D\SQLEXPRESS;Initial Catalog= BD-TP1-LUG;Integrated Security = True;");
            //private SqlConnection Conexion = new SqlConnection(@"Server =.\SQLEXPRESS; DataBase = BD-TP1-LUG;Trusted_Connection = True;");
            public SqlConnection AbrirConexion()
            {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }
                return Conexion;
            }
            public SqlConnection CerrarConexion()
            {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
                return Conexion;
            }

        }

        #region Metodos de Contactos con SP
        public class CD_Contactos
        {
            private CD_Conexion conexion = new CD_Conexion();

            SqlDataReader leer;
            DataTable tablaCliente = new DataTable();
            SqlCommand comando = new SqlCommand();

            public DataTable MostrarCliente()
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SelectALLClientes";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tablaCliente.Load(leer);
                conexion.CerrarConexion();
                return tablaCliente;
            }

            public void InsertarContacto(string ID_Cliente, string Nombre, string Apellido, string Telefono, string Mail)
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "InsertarContacto";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@ID_Cliente", ID_Cliente);
                comando.Parameters.AddWithValue("@Nombre", Nombre);
                comando.Parameters.AddWithValue("@Apellido", Apellido);
                comando.Parameters.AddWithValue("@Telefono", Telefono);
                comando.Parameters.AddWithValue("@Mail", Mail);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }

            public void EditarContacto(string ID_Cliente, string Nombre, string Apellido, string Telefono, string Mail)
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "EditarContacto";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@ID_Cliente", ID_Cliente);
                comando.Parameters.AddWithValue("@Nombre", Nombre);
                comando.Parameters.AddWithValue("@Apellido", Apellido);
                comando.Parameters.AddWithValue("@Telefono", Telefono);
                comando.Parameters.AddWithValue("@Mail", Mail);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }

            public void EliminarCliente(string ID_Cliente)
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "EliminarCliente";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@ID_Cliente", ID_Cliente);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }
        }

        #endregion

        #endregion

    }
}
