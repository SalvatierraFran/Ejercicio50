using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class Colectivo
    {
        /*Atributos*/
        protected List<Pasajero> _listPasajeros;
        private int _numeroDeLinea;
        private int _numeroDeMovil;

        /*Constructor*/
        public Colectivo()
        { }

        /*Metodos*/
        public abstract void SacarBoleto();

        public abstract void SolicitanBajar();

        public abstract string ToString();
    }
}
