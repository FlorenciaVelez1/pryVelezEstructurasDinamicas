using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVelezEstructurasDinamicas
{
    internal class clsArbolBinario
    {
        //Creo el campo inicial del arbol
        private clsNodo Inicio;
        private clsNodo[] Vector = new clsNodo[100];
        private Int32 IndVector = 0;
        public clsNodo Raiz
        {
            get { return Inicio; }
            set { Inicio = value; }
        }
        public void Agregar(clsNodo nuevo)
        {
            nuevo.Izquierdo = null;
            nuevo.Derecho = null;
            if (Raiz == null)
            {
                Raiz = nuevo;
            }
            else
            {
                clsNodo NodoPadre = Raiz;
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    NodoPadre = Aux;
                    if (nuevo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }
                if (nuevo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = nuevo;
                }
                else
                {
                    NodoPadre.Derecho = nuevo;
                }
            }
        }
        public void Eliminar(Int32 CODIGO)
        {
            IndVector = 0;
            GrabarVectorEnOrden(Raiz, CODIGO);
            Raiz = null;
            EquilibrarArbol(0, IndVector - 1);
        }
        public void Equilibrar()
        {
            IndVector = 0;
            GrabarVectorEnOrden(Raiz);
            Raiz = null;
            EquilibrarArbol(0, IndVector - 1);
        }
        private void EquilibrarArbol(Int32 inicio, Int32 fin)
        {
            Int32 medir = (inicio + fin) / 2;
            if (inicio <= fin)
            {
                Agregar(Vector[medir]);
                EquilibrarArbol(inicio, medir - 1);
                EquilibrarArbol(medir + 1, fin);
            }
        }
        private void GrabarVectorEnOrden(clsNodo NodoPadre)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorEnOrden(NodoPadre.Izquierdo);
            }
            Vector[IndVector] = NodoPadre;
            IndVector = IndVector + 1;
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorEnOrden(NodoPadre.Derecho);
            }
        }
        private void GrabarVectorEnOrden(clsNodo NodoPadre, Int32 CODIGO)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorEnOrden(NodoPadre.Izquierdo, CODIGO);
            }
            if (NodoPadre.Codigo != CODIGO)
            {
                Vector[IndVector] = NodoPadre;
                IndVector = IndVector + 1;
            }
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorEnOrden(NodoPadre.Derecho, CODIGO);
            }
        }
        //Acomodar los elementos de combo
        public void OrdenarAsc(ComboBox CbCodigo)
        {
            CbCodigo.Items.Clear();
            InOrdenAsc(CbCodigo, Raiz);
        }
        private void InOrdenAsc(ComboBox CbCodigo, clsNodo RAIZ)
        {
            if (RAIZ.Izquierdo != null)
            {
                InOrdenAsc(CbCodigo, RAIZ.Izquierdo);
            }
            CbCodigo.Items.Add(RAIZ.Codigo);
            if (RAIZ.Derecho != null)
            {
                InOrdenAsc(CbCodigo, RAIZ.Derecho);
            }
        }
        public void OrdenarDes(ComboBox CbCodigo)
        {
            CbCodigo.Items.Clear();
            InOrdenDes(CbCodigo, Raiz);
        }
        public void InOrdenDes(ComboBox CbCodigo, clsNodo RAIZ)
        {
            if (RAIZ.Derecho != null) InOrdenDes(CbCodigo, RAIZ.Derecho); 
            CbCodigo.Items.Add(RAIZ.Codigo); 
            if (RAIZ.Izquierdo != null) InOrdenDes(CbCodigo, RAIZ.Izquierdo); 
        }
        //Ordenar post
        public void OrdenarPostAsc(ComboBox CbCodigo)
        {
            CbCodigo.Items.Clear();
            PostOrdenAsc(CbCodigo, Raiz);
        }
        public void PostOrdenAsc(ComboBox CbCodigo, clsNodo RAIZ)
        {
            if (RAIZ.Izquierdo != null)
            {
                PostOrdenAsc(CbCodigo, RAIZ.Izquierdo); 
            }
            if (RAIZ.Derecho != null)
            { 
                PostOrdenAsc(CbCodigo, RAIZ.Derecho); 
            }
            CbCodigo.Items.Add(RAIZ.Codigo);
        }
        public void OrdenarPostDesc(ComboBox CbCodigo)
        {
            CbCodigo.Items.Clear();
            PostOrdenDesc(CbCodigo, Raiz);
        }
        public void PostOrdenDesc(ComboBox CbCodigo, clsNodo RAIZ)
        {
            if (RAIZ.Derecho != null)
            { 
                PostOrdenDesc(CbCodigo, RAIZ.Derecho); 
            }
            if (RAIZ.Izquierdo != null) 
            {
                PostOrdenDesc(CbCodigo, RAIZ.Izquierdo); 
            }
            CbCodigo.Items.Add(RAIZ.Codigo);
        }
        //Ordenar pre
        public void OrdenarPreAsc(ComboBox CbCodigo)
        {
            CbCodigo.Items.Clear();
            PreOrdenAsc(CbCodigo, Raiz);
        }
        public void PreOrdenAsc(ComboBox CbCodigo, clsNodo RAIZ)
        {
            CbCodigo.Items.Add(RAIZ.Codigo);
            if (RAIZ.Izquierdo != null)
            { 
                PreOrdenAsc(CbCodigo, RAIZ.Izquierdo);
            }
            if (RAIZ.Derecho != null) 
            { 
                PreOrdenAsc(CbCodigo, RAIZ.Derecho);
            }
        }
        public void OrdenarPreDesc(ComboBox CbCodigo)
        {
            CbCodigo.Items.Clear();
            PreOrdenDesc(CbCodigo, Raiz);
        }
        public void PreOrdenDesc(ComboBox CbCodigo, clsNodo RAIZ)
        {
            CbCodigo.Items.Add(RAIZ.Codigo);
            if (RAIZ.Derecho != null) 
            { 
                PreOrdenDesc(CbCodigo, RAIZ.Derecho); 
            }
            if (RAIZ.Izquierdo != null) 
            {
                PreOrdenDesc(CbCodigo, RAIZ.Izquierdo);
            }
        }
        //Listar en listbox--------------------------
        public void ListarAsc(ListBox lstListado)
        {
            lstListado.Items.Clear();
            InOrdenAsc(lstListado, Raiz);
        }
        //Ascendente
        public void InOrdenAsc(ListBox lstListado, clsNodo RAIZ)
        {
            if (RAIZ.Izquierdo != null)
            {
                InOrdenAsc(lstListado, RAIZ.Izquierdo);
            }
            lstListado.Items.Add(RAIZ.Codigo + " " + RAIZ.Nombre + " " + RAIZ.Tramite);
            if (RAIZ.Derecho != null)
            {
                InOrdenAsc(lstListado, RAIZ.Derecho);
            }
        }
        //Descendente
        public void ListarDesc(ListBox lstListado)
        {
            lstListado.Items.Clear();
            InOrdenDesc(lstListado, Raiz);
        }
        public void InOrdenDesc(ListBox lstListado, clsNodo RAIZ)
        {
            if (RAIZ.Derecho != null)
            {
                InOrdenDesc(lstListado, RAIZ.Derecho);
            }
            lstListado.Items.Add(RAIZ.Codigo);
            if (RAIZ.Izquierdo != null)
            {
                InOrdenDesc(lstListado, RAIZ.Izquierdo);
            }
        }
        //Listar post
        public void ListarPostAsc(ListBox lstListado)
        {
            lstListado.Items.Clear();
            PostOrdenAsc(lstListado, Raiz);
        }
        public void PostOrdenAsc(ListBox lstListado, clsNodo RAIZ)
        {
            if (RAIZ.Izquierdo != null)
            {
                PostOrdenAsc(lstListado, RAIZ.Izquierdo);
            }
            if (RAIZ.Derecho != null) 
            { 
                PostOrdenAsc(lstListado, RAIZ.Derecho);
            }
            lstListado.Items.Add(RAIZ.Codigo + " " + RAIZ.Nombre + " " + RAIZ.Tramite);
        }
        public void ListarPostDesc(ListBox lstListado)
        {
            lstListado.Items.Clear();
            PostOrdenDesc(lstListado, Raiz);
        }
        public void PostOrdenDesc(ListBox lstListado, clsNodo RAIZ)
        {
            if (RAIZ.Derecho != null)
            {
                PostOrdenDesc(lstListado, RAIZ.Derecho);
            }
            if (RAIZ.Izquierdo != null) 
            {
                PostOrdenDesc(lstListado, RAIZ.Izquierdo);
            }
            lstListado.Items.Add(RAIZ.Codigo + " " + RAIZ.Nombre + " " + RAIZ.Tramite);
        }
        //Listar pre
        public void ListarPreAsc(ListBox lstListado)
        {
            lstListado.Items.Clear();
            PreOrdenAsc(lstListado, Raiz);
        }
        public void PreOrdenAsc(ListBox lstListado, clsNodo RAIZ)
        {
            lstListado.Items.Add(RAIZ.Codigo + " " + RAIZ.Nombre + " " + RAIZ.Tramite);
            if (RAIZ.Izquierdo != null)
            { 
                PreOrdenAsc(lstListado, RAIZ.Izquierdo); 
            }
            if (RAIZ.Derecho != null) 
            {
                PreOrdenAsc(lstListado, RAIZ.Derecho); 
            }
        }
        public void ListarPreDesc(ListBox lstListado)
        {
            lstListado.Items.Clear();
            PreOrdenDesc(lstListado, Raiz);
        }
        public void PreOrdenDesc(ListBox lstListado, clsNodo RAIZ)
        {
            lstListado.Items.Add(RAIZ.Codigo + " " + RAIZ.Nombre + " " + RAIZ.Tramite);
            if (RAIZ.Derecho != null)
            { 
                PreOrdenDesc(lstListado, RAIZ.Derecho); 
            }
            if (RAIZ.Izquierdo != null)
            { 
                PreOrdenDesc(lstListado, RAIZ.Izquierdo); 
            }
        }
        //Listar en grilla----------------------
        public void ListarGrilla(DataGridView GrillaArbolBinario)
        {
            GrillaArbolBinario.Rows.Clear();
            InOrdenAsc(GrillaArbolBinario, Raiz);
        }
        //Ascendente
        public void InOrdenAsc(DataGridView GrillaArbolBinario, clsNodo RAIZ)
        {
            if (RAIZ.Izquierdo != null)
            {
                InOrdenAsc(GrillaArbolBinario, RAIZ.Izquierdo);
            }
            GrillaArbolBinario.Rows.Add(RAIZ.Codigo, RAIZ.Nombre, RAIZ.Tramite);
            if (RAIZ.Derecho != null)
            {
                InOrdenAsc(GrillaArbolBinario, RAIZ.Derecho);
            }
        }
        //Descendente
        public void ListarDesc(DataGridView GrillaArbolBinario)
        {
            GrillaArbolBinario.Rows.Clear();
            InOrdenDes(GrillaArbolBinario, Raiz);
        }
        public void InOrdenDes(DataGridView GrillaArbolBinario, clsNodo RAIZ)
        {
            if (RAIZ.Derecho != null)
            {
                InOrdenDes(GrillaArbolBinario, RAIZ.Derecho);
            }
            GrillaArbolBinario.Rows.Add(RAIZ.Codigo, RAIZ.Nombre, RAIZ.Tramite);
            if (RAIZ.Izquierdo != null)
            {
                InOrdenDes(GrillaArbolBinario, RAIZ.Izquierdo);
            }
        }
        //Listar post
        public void ListarPostAsc(DataGridView GrillaArbolBinario)
        {
            GrillaArbolBinario.Rows.Clear();
            PostOrdenAsc(GrillaArbolBinario, Raiz);
        }
        public void PostOrdenAsc(DataGridView GrillaArbolBinario, clsNodo RAIZ)
        {
            if (RAIZ.Izquierdo != null)
            {
                PreOrdenAsc(GrillaArbolBinario, RAIZ.Izquierdo);
            }
            if (RAIZ.Derecho != null)
            {
                PreOrdenAsc(GrillaArbolBinario, RAIZ.Derecho);
            }
            GrillaArbolBinario.Rows.Add(RAIZ.Codigo, RAIZ.Nombre, RAIZ.Tramite);
        }
        public void ListarPostDesc(DataGridView GrillaArbolBinario)
        {
            GrillaArbolBinario.Rows.Clear();
            PostOrdenDesc(GrillaArbolBinario, Raiz);
        }
        public void PostOrdenDesc(DataGridView GrillaArbolBinario, clsNodo RAIZ)
        {
            if (RAIZ.Derecho != null)
            {
                PostOrdenDesc(GrillaArbolBinario, RAIZ.Derecho);
            }
            if (RAIZ.Izquierdo != null)
            {
                PostOrdenDesc(GrillaArbolBinario, RAIZ.Izquierdo);
            }
            GrillaArbolBinario.Rows.Add(RAIZ.Codigo, RAIZ.Nombre, RAIZ.Tramite);
        }
        //Listar pre
        public void ListarPreAsc(DataGridView GrillaArbolBinario)
        {
            GrillaArbolBinario.Rows.Clear();
            PreOrdenAsc(GrillaArbolBinario, Raiz);
        }
        public void PreOrdenAsc(DataGridView GrillaArbolBinario, clsNodo RAIZ)
        {
            GrillaArbolBinario.Rows.Add(RAIZ.Codigo, RAIZ.Nombre, RAIZ.Tramite);
            if (RAIZ.Izquierdo != null)
            { 
                PreOrdenAsc(GrillaArbolBinario, RAIZ.Izquierdo);
            }
            if (RAIZ.Derecho != null) 
            { 
                PreOrdenAsc(GrillaArbolBinario, RAIZ.Derecho); 
            }
        }
        public void ListarPreDesc(DataGridView GrillaArbolBinario)
        {
            GrillaArbolBinario.Rows.Clear();
            PreOrdenDesc(GrillaArbolBinario, Raiz);
        }
        public void PreOrdenDesc(DataGridView GrillaArbolBinario, clsNodo RAIZ)
        {
            GrillaArbolBinario.Rows.Add(RAIZ.Codigo, RAIZ.Nombre, RAIZ.Tramite);
            if (RAIZ.Derecho != null) 
            { 
                PreOrdenDesc(GrillaArbolBinario, RAIZ.Derecho); 
            }
            if (RAIZ.Izquierdo != null) 
            { 
                PreOrdenDesc(GrillaArbolBinario, RAIZ.Izquierdo); 
            }
        }
        //Listar treeview----------------------------------------
     
        public void ListarTVAsc(TreeView TreeView)
        {
            TreeView.Nodes.Clear();
            OrdenAsc(TreeView.Nodes, Raiz);
        }
        public void OrdenAsc(TreeNodeCollection NodoPadre, clsNodo RAIZ)
        {
            TreeNode NuevoNodoTv = NodoPadre.Add(RAIZ.Codigo.ToString());
            if (RAIZ.Izquierdo != null)
            {
                OrdenAsc(NuevoNodoTv.Nodes, RAIZ.Izquierdo);
            }
            if (RAIZ.Derecho != null)
            {
                OrdenAsc(NuevoNodoTv.Nodes, RAIZ.Derecho);
            }
        }
        public void ListarTVDes(TreeView TreeView)
        {
            TreeView.Nodes.Clear();
            OrdenDesc(TreeView.Nodes, Raiz);
        }
        public void OrdenDesc(TreeNodeCollection NodoPadre, clsNodo RAIZ)
        {
            TreeNode NuevoNodoTv = NodoPadre.Add(RAIZ.Codigo.ToString());
            if (RAIZ.Derecho != null) 
            {
                OrdenDesc(NuevoNodoTv.Nodes, RAIZ.Derecho); 
            }
            if (RAIZ.Izquierdo != null)
            {
                OrdenDesc(NuevoNodoTv.Nodes, RAIZ.Izquierdo);
            }
        }
    }
}
