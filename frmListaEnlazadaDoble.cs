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
    public partial class frmListaEnlazadaDoble : Form
    {
        public frmListaEnlazadaDoble()
        {
            InitializeComponent();
        }
        clsListaDoble ListaDoble = new clsListaDoble();
        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (ListaDoble.Primero != null)
            {
                Int32 codigo = Convert.ToInt32(cbCodigo.Text);
                ListaDoble.Eliminar(codigo);
                ListaDoble.RecorrerAsc(GrillaListaDoble);
                ListaDoble.RecorrerAsc(lstListado);
                ListaDoble.RecorrerAsc(cbCodigo);
            }
            cbCodigo.SelectedIndex = -1;
            cmdEliminar.Enabled = false;
        }
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(mskCodigoNE.Text);
            objNodo.Nombre = txtNombreNE.Text;
            objNodo.Tramite = txtTramiteNE.Text;
            ListaDoble.Agregar(objNodo);
            ListaDoble.RecorrerAsc(GrillaListaDoble);
            ListaDoble.RecorrerAsc(lstListado);
            ListaDoble.RecorrerAsc(cbCodigo);
            mskCodigoNE.Text = "";
            txtNombreNE.Text = "";
            txtTramiteNE.Text = "";
        }
        private void rbtnAscendete_CheckedChanged(object sender, EventArgs e)
        {
            ListaDoble.RecorrerAsc(GrillaListaDoble);
            ListaDoble.RecorrerAsc(lstListado);
            ListaDoble.RecorrerAsc(cbCodigo);
        }
        private void rtnDescendente_CheckedChanged(object sender, EventArgs e)
        {
            ListaDoble.RecorrerDes(GrillaListaDoble);
            ListaDoble.RecorrerDes(lstListado);
            ListaDoble.RecorrerDes(cbCodigo);
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
        private void txtTramiteNE_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void txtNombreNE_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void mskCodigoNE_TextChanged(object sender, EventArgs e)
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
