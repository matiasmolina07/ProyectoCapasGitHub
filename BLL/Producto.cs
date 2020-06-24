using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class Producto 
    {
        #region ------------- Trabajamos Productos con SQL Emb. -------------------

        #endregion

        //Definimos las propiedades
        public int ID_Producto { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }


        //Metodo que lista Productos
        public DataTable ListarProducto()
        {
            Acceso datosAcc = new Acceso();
            string sql = "Select * from Productos";
            return datosAcc.Leer(sql);
        }

        //Metodo Alta de Productos
        public void AltaProducto(Producto pProd)
        {
            Acceso datosAcc = new Acceso();
            string sql = "Insert into Productos (ID_Producto, Categoria, Descripcion) values ('" + pProd.ID_Producto + "','" + pProd.Categoria + "','" + pProd.Descripcion + "') ";
            datosAcc.Escribir(sql);
        }

        //Metodo que modifica Producto
        public void ModificarProducto(Producto pProd)
        {
            Acceso datosAcc = new Acceso();
            string sql = "Update Productos Set Categoria='"+pProd.Categoria+"', Descripcion ='"+pProd.Descripcion +"' where ID_Producto='"+pProd.ID_Producto+ "'";
            datosAcc.Escribir(sql);
        }

        //Metodo para Borrar Producto
        public void BorrarProducto(Producto pProd)
        {
            Acceso datosAcc = new Acceso();
            string sql = "Delete From Productos where ID_Producto= '"+pProd.ID_Producto+"'";
            datosAcc.Escribir(sql);
        }

        //Metodo Testear Conexion
        public string ProbarConexion()
        {
            Acceso datosAcc = new Acceso();
            return datosAcc.TestConexion();
        }

    }

  

}
