using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class FormSQL : Form
    {
        Producto pProd = new Producto();
        public FormSQL()
        {
            InitializeComponent();
        }

        private void FormSQL_Load_1(object sender, EventArgs e)
        {
            //Carga estado Actual del grid
            Enlazar();
        }

        private void btnAltaProd_Click(object sender, EventArgs e)
        {
            Asignar();
            //llamo al metodo de altaProductos y paso el mismo objeto con los datos
            pProd.AltaProducto(pProd);
            Enlazar();
            Limpiar();

        }

        //Asignamos los valores al objeto de Productos
        void Asignar()
        {
            if (textBoxID.Text != "")
            { pProd.ID_Producto = Convert.ToInt32(textBoxID.Text); }
            else { pProd.ID_Producto = 0; }
            
            pProd.Categoria = textBoxCat.Text;
            pProd.Descripcion = textBoxDESC.Text;
            
        }

        //Listamos el Dtvg - Productos
        void Enlazar()
        {
            dtvgProductos.DataSource = null;
            dtvgProductos.DataSource = pProd.ListarProducto();
        }
        
        //Limpiamos los Textbox
        void Limpiar()
        {
            textBoxID.Text = null;
            textBoxCat.Text = null;
            textBoxDESC.Text = null;
        }


        private void btnRemovProd_Click(object sender, EventArgs e)
        {
            Asignar();
            //Llamamos al metodo de Productos y pasamos el Objeto
            pProd.BorrarProducto(pProd);
            Enlazar();
            Limpiar();
        }

        //Boton Modificar -- Olvide ponerle nombre al boton jaja!
        private void button1_Click(object sender, EventArgs e)
        {
            Asignar();
            //Llamamos al metodo de Productos y pasamos el Objeto
            pProd.ModificarProducto(pProd);
            Enlazar();
            Limpiar();
        }

     

        private void dtvgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //asigno el valor de cada posicion de la grilla a los texbox para que muestre los datos en los textbox
            textBoxID.Text = dtvgProductos.SelectedRows[0].Cells[0].Value.ToString();
            textBoxCat.Text = dtvgProductos.SelectedRows[0].Cells[1].Value.ToString();
            textBoxDESC.Text = dtvgProductos.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void dtvgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                //asigno el valor de cada posicion de la grilla a los texbox para que muestre los datos en los textbox
                textBoxID.Text = dtvgProductos.SelectedRows[0].Cells[0].Value.ToString();
                textBoxCat.Text = dtvgProductos.SelectedRows[0].Cells[1].Value.ToString();
                textBoxDESC.Text = dtvgProductos.SelectedRows[0].Cells[2].Value.ToString();
          
        }
    }
}
