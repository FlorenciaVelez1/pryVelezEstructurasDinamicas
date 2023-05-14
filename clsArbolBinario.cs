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
        public clsNodo Raiz
        {
            get { return Inicio; }
            set { Inicio = value; }
        }
        public clsNodo BuscarCodigo(Int32 CODIGO)
        {
            clsNodo Aux = Raiz;
            while (Aux != null)
            {
                if (CODIGO == Aux.Codigo)
                {
                    break;
                }
                if (CODIGO < Aux.Codigo)
                {
                    Aux = Aux.Izquierdo;
                }
                else
                {
                    Aux = Aux.Derecho;
                } 
            }
            return Aux;
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
        private clsNodo[] Vector = new clsNodo[100];
        private Int32 IndVector = 0;
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
        public void Eliminar(Int32 CODIGO)
        {
            IndVector = 0;
            GrabarVectorEnOrden(Raiz, CODIGO);
            Raiz = null;
            EquilibrarArbol(0, IndVector - 1);
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
        public void RecorrerCB(ComboBox CbCodigo)
        {
            CbCodigo.Items.Clear();
            EnOrdenAsc(CbCodigo, Raiz);
        }
        private void EnOrdenAsc(ComboBox CbCodigo, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                EnOrdenAsc(CbCodigo, R.Izquierdo);
            }
            CbCodigo.Items.Add(R.Codigo);
            if (R.Derecho != null)
            {
                EnOrdenAsc(CbCodigo, R.Derecho);
            }
        }
        public void ListarLst(ListBox lstListado)
        {
            lstListado.Items.Clear();
            EnOrdenAsc(lstListado, Raiz);
        }
        public void EnOrdenAsc(ListBox lstListado, clsNodo RAIZ)
        {
            if (RAIZ.Izquierdo != null)
            {
                EnOrdenAsc(lstListado, RAIZ.Izquierdo);
            }
            lstListado.Items.Add(RAIZ.Codigo);
            if (RAIZ.Derecho != null)
            {
                EnOrdenAsc(lstListado, RAIZ.Derecho);
            }
        }
        public void EnOrdenDesc(ListBox lstListado, clsNodo RAIZ)
        {
            if (RAIZ.Derecho != null)
            {
                EnOrdenDesc(lstListado, RAIZ.Derecho);
            }
            lstListado.Items.Add(RAIZ.Codigo);
            if (RAIZ.Izquierdo != null)
            {
                EnOrdenDesc(lstListado, RAIZ.Izquierdo);
            }
        }
        public void PreOrden(ListBox lstListado, clsNodo RAIZ)
        {
            lstListado.Items.Add(RAIZ.Codigo);
            if (RAIZ.Izquierdo != null)
            {
                PreOrden(lstListado, RAIZ.Izquierdo);
            }
            if (RAIZ.Derecho != null)
            {
                PreOrden(lstListado, RAIZ.Derecho);
            }
        }
        public void PostOrden(ListBox lstListado, clsNodo RAIZ)
        {
            if (RAIZ.Izquierdo != null)
            {
                PostOrden(lstListado, RAIZ.Izquierdo);

            }
            if (RAIZ.Derecho != null)
            {
                PostOrden(lstListado, RAIZ.Derecho);
            }
            lstListado.Items.Add(RAIZ.Codigo);
        }
    }
}
