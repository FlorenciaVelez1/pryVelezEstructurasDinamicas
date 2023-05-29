using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVelezEstructurasDinamicas
{
    public partial class frmListaEnlazadaSimple : Form
    {
        public frmListaEnlazadaSimple()
        {
            InitializeComponent();
        }
        clsListaSimple ListaSimple = new clsListaSimple();
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(mskCodigoNE.Text);
            objNodo.Nombre = txtNombreNE.Text;
            objNodo.Tramite = txtTramiteNE.Text;
            ListaSimple.Agregar(objNodo);
            ListaSimple.Recorrer(GrillaListaSimple);
            ListaSimple.Recorrer(lstListado);
            ListaSimple.Recorrer(cbCodigo);
            mskCodigoNE.Text = "";
            txtNombreNE.Text = "";
            txtTramiteNE.Text = "";
        }
        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (ListaSimple.Primero != null)
            {
                Int32 codigo = Convert.ToInt32(cbCodigo.Text);
                ListaSimple.Eliminar(codigo);
                ListaSimple.Recorrer(GrillaListaSimple);
                ListaSimple.Recorrer(lstListado);
                ListaSimple.Recorrer(cbCodigo);
            }
            cbCodigo.SelectedIndex = -1;
            cmdEliminar.Enabled = false;
        }
        private void cbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCodigo.SelectedIndex != -1)
            {
                cmdEliminar.Enabled = true;
            }
        }
        private void Chequeo()
        {
            if (mskCodigoNE.Text != "" & txtNombreNE.Text != "" & txtTramiteNE.Text != "")
            {
                cmdAgregar.Enabled = true;
            }
            else
            {
                cmdAgregar.Enabled = false;
            }
        }
        private void mskCodigoNE_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void txtNombreNE_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void txtTramiteNE_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }

        private void txtNombreNE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
