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
        public Colectivo(int NumeroDeLinea, int NumeroDeMovil)
        {
            this._numeroDeLinea = NumeroDeLinea;
            this._numeroDeMovil = NumeroDeMovil;

            this._listPasajeros = new List<Pasajero>();
        }

        /*Metodos*/
        public abstract void SacarBoleto(Pasajero unPasajero);

        public abstract void SolicitanBajar(Pasajero unPasajero);

        public abstract string ToString();
    }
}
