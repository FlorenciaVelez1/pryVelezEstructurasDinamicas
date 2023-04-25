using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryVelezEstructurasDinamicas
{
    internal class clsNodo
    {
        private Int32 varCodigo;
        private String varNombre;
        private String varTramite;
        private clsNodo varSiguiente;
        private clsNodo varAnterior;
        public Int32 Codigo
        {
            get { return varCodigo; }
            set { varCodigo = value; }
        }
        public String Nombre
        {
            get { return varNombre; }
            set { varNombre = value; }
        }
        public String Tramite
        {
            get { return varTramite; }
            set { varTramite = value; }
        }
        public clsNodo Siguiente
        {
            get { return varSiguiente; }
            set { varSiguiente = value; }
        }
        public clsNodo Anterior
        {
            get { return varAnterior; }
            set { varAnterior = value; }
        }

    }
}
