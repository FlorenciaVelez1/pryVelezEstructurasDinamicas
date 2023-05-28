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
    public partial class frmArbolBinarioBusqueda : Form
    {
        public frmArbolBinarioBusqueda()
        {
            InitializeComponent();
        }
        clsArbolBinario objArbolBinario = new clsArbolBinario();
        private void ListarDatos()
        {
            objArbolBinario.ListarAsc(lstListado);
            objArbolBinario.OrdenarAsc(cbCodigo);
            objArbolBinario.ListarGrilla(GrillaArbolBinario);
            objArbolBinario.ListarTVPreDes(treevDatos);
        }
        private void Limpieza()
        {
            txtNombre.Text = "";
            mskCodigo.Text = "";
            txtTramite.Text = "";
        }
        private void Limpiezarbtn()
        {
            rbtnAscendete.Checked = false;
            rbtnDescendente.Checked = false;
            rbtnInOrden.Checked = false;
            rbtnPostOrden.Checked = false;
            rbtnPreOrden.Checked = false;
        }
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(mskCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;
            objArbolBinario.Agregar(objNodo);
            ListarDatos();
            Limpieza();
            Limpiezarbtn();
        }
        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            cmdEliminar.Enabled = false;
            objArbolBinario.Eliminar(Convert.ToInt32(cbCodigo.Text));
            if (objArbolBinario.Raiz != null)
            {
                ListarDatos();
            }
            else
            {
                GrillaArbolBinario.Rows.Clear();
                cbCodigo.Items.Clear();
                cbCodigo.SelectedIndex = -1;
                Limpieza();
                Limpiezarbtn();
            }
        }
        private void Chequeo()
        {
            if (mskCodigo.Text != "" & txtNombre.Text != "" & txtTramite.Text != "")
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
        private void cmdEquilibrar_Click(object sender, EventArgs e)
        {
            if (objArbolBinario.Raiz != null)
            {
                objArbolBinario.Equilibrar();
                ListarDatos();
                MessageBox.Show("Arbol equilibrado");
            }
        }
        private void rbtnInOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (objArbolBinario.Raiz != null)
            {
                rbtnAscendete.Checked = false;
                rbtnDescendente.Checked = false;
            }
        }
        private void rbtnPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (objArbolBinario.Raiz != null)
            {
                rbtnAscendete.Checked = false;
                rbtnDescendente.Checked = false;
            }
        }
        private void rbtnPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (objArbolBinario.Raiz != null)
            {
                rbtnAscendete.Checked = false;
                rbtnDescendente.Checked = false;
            }
        }
        private void rbtnAscendete_CheckedChanged(object sender, EventArgs e)
        {
            if (objArbolBinario.Raiz != null)
            {
                if (rbtnInOrden.Checked == true)
                {
                    ListarDatos();
                }
                if (rbtnPreOrden.Checked == true)
                {
                   objArbolBinario.ListarPreAsc(GrillaArbolBinario);
                   objArbolBinario.ListarPreAsc(lstListado);
                   objArbolBinario.OrdenarPreAsc(cbCodigo);
                   objArbolBinario.ListarTVPreDes(treevDatos);
                }
                if (rbtnPostOrden.Checked == true)
                {
                    objArbolBinario.ListarPostAsc(GrillaArbolBinario);
                    objArbolBinario.ListarPostAsc(lstListado);
                    objArbolBinario.OrdenarPostAsc(cbCodigo);
                    objArbolBinario.ListarTVPreDes(treevDatos);
                }
            }
        }
        private void rbtnDescendente_CheckedChanged(object sender, EventArgs e)
        {
            if (objArbolBinario.Raiz != null)
            {
                if (rbtnInOrden.Checked == true)
                {
                    objArbolBinario.ListarDesc(GrillaArbolBinario);
                    objArbolBinario.ListarDesc(lstListado);
                    objArbolBinario.OrdenarDes(cbCodigo);
                    objArbolBinario.ListarTVPreDes(treevDatos);
                }
                if (rbtnPreOrden.Checked == true)
                {
                    objArbolBinario.ListarPreDesc(GrillaArbolBinario);
                    objArbolBinario.ListarPreDesc(lstListado);
                    objArbolBinario.OrdenarPreDesc(cbCodigo);
                    objArbolBinario.ListarTVPreDes(treevDatos);
                }
                if (rbtnPostOrden.Checked == true)
                {
                    objArbolBinario.ListarPostDesc(GrillaArbolBinario);
                    objArbolBinario.ListarPostDesc(lstListado);
                    objArbolBinario.OrdenarPostDesc(cbCodigo);
                    objArbolBinario.ListarTVPreDes(treevDatos);
                }
            }
        }
        private void cbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCodigo.SelectedIndex != -1)
            {
                cmdEliminar.Enabled = true;
            }
        }
    }
}
