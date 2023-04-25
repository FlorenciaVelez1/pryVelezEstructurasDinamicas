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
        }
        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (EstructuraCola.Primero != null)
            {
                lblCodigoEE.Text = EstructuraCola.Primero.Codigo.ToString();
                lblNombreEE.Text = EstructuraCola.Primero.Nombre;
                lblTramiteEE.Text = EstructuraCola.Primero.Tramite;
                EstructuraCola.Eliminar();
                EstructuraCola.Recorrer(GrillaCola);
                EstructuraCola.Recorrer(lstListado);
            }
            else
            {
                lblCodigoEE.Text = "";
                lblNombreEE.Text = "";
                lblTramiteEE.Text = "";
            }
        }
    }
}
