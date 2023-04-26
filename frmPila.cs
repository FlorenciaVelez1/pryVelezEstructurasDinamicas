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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }
        clsPila PilaPersonas = new clsPila();
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(mskCodigoNE.Text);
            ObjNodo.Nombre = txtNombreNE.Text;
            ObjNodo.Tramite = txtTramiteNE.Text;
            PilaPersonas.Agregar(ObjNodo);
            PilaPersonas.Recorrer(GrillaPila);
            PilaPersonas.Recorrer(lstListado);
            mskCodigoNE.Text = "";
            txtNombreNE.Text = "";
            txtTramiteNE.Text = "";
            cmdEliminar.Enabled = true;
        }
        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (PilaPersonas.Primero != null)
            {
                lblCodigoInfo.Text = PilaPersonas.Primero.Codigo.ToString();
                lblNombreInfo.Text = PilaPersonas.Primero.Nombre;
                lblTramiteInfo.Text = PilaPersonas.Primero.Tramite;
                PilaPersonas.Eliminar();
                PilaPersonas.Recorrer(GrillaPila);
                PilaPersonas.Recorrer(lstListado);
            }
            else
            {
                lblCodigoInfo.Text = "";
                lblNombreInfo.Text = "";
                lblTramiteInfo.Text = "";
                cmdEliminar.Enabled = false;
            }
        }
        private void frmPila_Load(object sender, EventArgs e)
        {
            if (PilaPersonas.Primero == null)
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
    }
}
