using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
   
    public class Contacto
    {

        #region ------------- Trabajamos Contactos con SP -------------------

        #endregion


        private AccesoSP.CD_Contactos objetoContacto  = new AccesoSP.CD_Contactos();


        #region Metodos de Contactos
        

        public DataTable MostrarContacto()
        {
            DataTable tablaClientes = new DataTable();
            tablaClientes = objetoContacto.MostrarCliente();
            return tablaClientes;
        }

        public void InsertarContacto(string ID_Cliente, string Nombre, string Apellido, string Telefono, string Mail)
        {
            objetoContacto.InsertarContacto(ID_Cliente, Nombre, Apellido, Telefono, Mail);
        }

        public void EditarContacto(string ID_Cliente, string Nombre, string Apellido, string Telefono, string Mail)
        {
            objetoContacto.EditarContacto(ID_Cliente, Nombre, Apellido, Telefono, Mail);
        }

        public void EliminarContacto(string ID_Cliente)
        {
            objetoContacto.EliminarCliente(ID_Cliente);
        }

        #endregion




    }
}
