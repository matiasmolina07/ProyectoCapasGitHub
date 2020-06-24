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
    public partial class Form1 : Form
    {
        Producto pProd = new Producto();
        public Form1()
        {
            InitializeComponent();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aBMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSQL formSQL = new FormSQL();
            formSQL.MdiParent = this;
            formSQL.Show();
            formSQL.BringToFront();
            

        }

        private void aBMSPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSP formSP = new FormSP();
            formSP.MdiParent = this;
            formSP.Show();
            formSP.BringToFront();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTestCon_Click(object sender, EventArgs e)
        {
            { MessageBox.Show(pProd.ProbarConexion()); }
        }



       

    }
}
