using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVelezEstructurasDinamicas
{
    internal class clsListaSimple
    {
        public clsNodo Primero;
        public void Agregar(clsNodo Nuevo)

        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo <= Primero.Codigo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero = Nuevo;
                }
                else
                {
                    clsNodo aux = Primero;
                    clsNodo anterior = Primero;
                    while (Nuevo.Codigo > aux.Codigo)
                    {
                        anterior = aux;
                        aux = aux.Siguiente;
                        if (aux == null)
                        {
                            break;
                        }
                    }
                    anterior.Siguiente = Nuevo;
                    Nuevo.Siguiente = aux;
                }
            }

        }
        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo)
            {
                Primero = Primero.Siguiente;
            }
            else
            {
                clsNodo anterior = Primero;
                clsNodo aux = Primero;
                while (aux.Codigo != Codigo)
                {
                    anterior = aux;
                    aux = aux.Siguiente;
                }
                anterior.Siguiente = aux.Siguiente;

            }
        }
        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer( ListBox Lista)
        {
            clsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ComboBox Combo)
        {
            clsNodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
    }
}
