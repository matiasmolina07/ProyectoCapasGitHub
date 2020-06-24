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
    public partial class FormSP : Form
    {
        //Defino instancia
        Contacto pContacto = new Contacto();
        //Variables
        private string ID_Cliente="";
        private bool Editar = false;

        public FormSP()
        {
            InitializeComponent();
        }

        //Mostramos los clientes al abrir el Form
        private void FormSP_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        //Metodo que muestra los clientes
        private void MostrarClientes()
        {
            Contacto objeto = new Contacto();
            dtvgClientes.DataSource = objeto.MostrarContacto();
        }

        //Boton Alta
        private void btnAltaClient_Click(object sender, EventArgs e)
        {
            
            //Editar lo utilizamos para agregar y para modificar
            if (Editar == false)
            {
                try
                {
                    
                    pContacto.InsertarContacto(textBoxIDclient.Text, textBoxNombre.Text, textBoxApellido.Text, textBoxTEL.Text, textBoxMAIL.Text);

                    MessageBox.Show("Se agrego el Cliente correctamente");
                    MostrarClientes();
                    LimpiarForm();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la carga del Cliente por: " + ex);
                }
            }
            if (Editar == true) //Si quiere modificar
            {
                try
                {
                    pContacto.EditarContacto(textBoxIDclient.Text, textBoxNombre.Text, textBoxApellido.Text, textBoxTEL.Text, textBoxMAIL.Text);
                    MessageBox.Show("Cliente modificado correctamente");
                    MostrarClientes();
                    LimpiarForm();
                    Editar = false; //lo volvemos a falso para dejar de modificar
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo modificar por: " + ex);
                }
            }


        }



        //Metodo que limpia los forms
        private void LimpiarForm()
        {
            textBoxIDclient.Clear();
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxTEL.Clear();
            textBoxMAIL.Clear();
        }

        //Boton Modificar
        private void btnModifCliente_Click(object sender, EventArgs e)
        {
            if (dtvgClientes.SelectedRows.Count > 0)
            {
                Editar = true; //Nos permite la modificación
                textBoxIDclient.Text = dtvgClientes.CurrentRow.Cells["ID_Cliente"].Value.ToString();
                textBoxNombre.Text = dtvgClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                textBoxApellido.Text = dtvgClientes.CurrentRow.Cells["Apellido"].Value.ToString();
                textBoxTEL.Text = dtvgClientes.CurrentRow.Cells["Telefono"].Value.ToString();
                textBoxMAIL.Text = dtvgClientes.CurrentRow.Cells["Mail"].Value.ToString();

            }
            else
            { MessageBox.Show("Debe seleccionar una fila"); }
           
        }

        //Boton Borrar
        private void btnRemovClient_Click(object sender, EventArgs e)
        {
            if (dtvgClientes.SelectedRows.Count > 0)
            {

                ID_Cliente = dtvgClientes.CurrentRow.Cells["ID_Cliente"].Value.ToString();

                pContacto.EliminarContacto(ID_Cliente);
                MessageBox.Show("Cliente eliminado correctamente");


            }
            else
            { MessageBox.Show("Debe seleccionar una fila"); }

            MostrarClientes();
        }
    }
}
