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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }
        clsCola EstructuraCola = new clsCola();
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(mskCodigoNE.Text);
            objNodo.Nombre = txtNombreNE.Text;
            objNodo.Tramite = txtTramiteNE.Text;
            EstructuraCola.Agregar(objNodo);
            EstructuraCola.Recorrer(GrillaCola);
            EstructuraCola.Recorrer(lstListado);
            mskCodigoNE.Text = "";
            txtNombreNE.Text = "";
            txtTramiteNE.Text = "";
            cmdEliminar.Enabled = true;
        }
        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (EstructuraCola.Primero != null)
            {
                lblCodigoInfo.Text = EstructuraCola.Primero.Codigo.ToString();
                lblNombreInfo.Text = EstructuraCola.Primero.Nombre;
                lblTramiteInfo.Text = EstructuraCola.Primero.Tramite;
                EstructuraCola.Eliminar();
                EstructuraCola.Recorrer(GrillaCola);
                EstructuraCola.Recorrer(lstListado);
            }
            else
            {
                lblCodigoInfo.Text = "";
                lblNombreInfo.Text = "";
                lblTramiteInfo.Text = "";
                cmdEliminar.Enabled=false;
            }
        }
        private void frmCola_Load(object sender, EventArgs e)
        {
          if(EstructuraCola.Primero == null)
            {
                cmdEliminar.Enabled = false;
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
