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
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(mskCodigoNE.Text);
            objNodo.Nombre = txtNombreNE.Text;
            objNodo.Tramite = txtTramiteNE.Text;
        }
        private void cmdEliminar_Click(object sender, EventArgs e)
        {

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
    }
}
