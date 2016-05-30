using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Pasajero
    {
        /*Atributo*/
        private eTipoPasajero _TipoDePasajero;

        /*Propiedad*/
        public eTipoPasajero TipoDePasajero
        {
            get { return this._TipoDePasajero; }
            set { this._TipoDePasajero = value; }
        }

        /*Constructor*/
        public Pasajero(eTipoPasajero TipoDePasajero)
        {
            this._TipoDePasajero = TipoDePasajero;
        }
    }

    public enum eTipoPasajero
    {
        PasajeroNormal, PasajeroEscolar, PasajeroConDiscapacidadMotriz, XXXXLLM
    }
}
