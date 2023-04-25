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
    public partial class frmVentanaPrincipal : Form
    {
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datosDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDesarrollador DatosDesarrollador = new frmDatosDesarrollador();
            DatosDesarrollador.ShowDialog();
        }
        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola EDCola = new frmCola();
            EDCola.ShowDialog();
        }
        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila EDPila = new frmPila(); 
            EDPila.ShowDialog();
        }
        private void árbolBinarioDeBusquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbolBinarioBusqueda ArbolBinarioBusqueda = new frmArbolBinarioBusqueda();
            ArbolBinarioBusqueda.ShowDialog();
        }
        private void grafoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrafo ERGrafo = new frmGrafo();
            ERGrafo.ShowDialog();
        }
        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaEnlazadaSimple ListaEnlazadaSimple = new frmListaEnlazadaSimple();
            ListaEnlazadaSimple.ShowDialog();
        }
        private void listaDobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaEnlazadaDoble ListaEnlazadaDoble = new frmListaEnlazadaDoble();
            ListaEnlazadaDoble.ShowDialog();
        }
    }
}
