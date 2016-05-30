using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ColectivoNormal:Colectivo
    {
        /*Atributos*/
        public ColectivoNormal(int NumeroDeLinea, int NumeroDeMovil):base(NumeroDeLinea, NumeroDeMovil)
        { }

        /*Implementacion de la clase abstracta*/

        public override void SacarBoleto(Pasajero unPasajero)
        {
            if (unPasajero.TipoDePasajero == eTipoPasajero.PasajeroConDiscapacidadMotriz)
            {
                throw new Exception("Debe ser colectivo para Discapacitados");
            }
            else
            {
                this._listPasajeros.Add(unPasajero);
            }
        }

        public override void SolicitanBajar(Pasajero unPasajero)
        {
            Console.WriteLine("Desciende pasajero");
            this._listPasajeros.Remove(unPasajero);
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
