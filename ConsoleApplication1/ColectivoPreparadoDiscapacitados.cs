using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ColectivoPreparadoDiscapacitados:Colectivo
    {
        /*Atributo*/
        private bool _lugarDiscapacitadoDisponible;

        /*Constructor*/
        public ColectivoPreparadoDiscapacitados(int NumeroDeLinea, int NumeroDeMovil):base(NumeroDeLinea, NumeroDeMovil)
        { }

        /*Implementacion de la clase abstracta*/
        public override void SacarBoleto(Pasajero unPasajero)
        {
            if (unPasajero.TipoDePasajero == eTipoPasajero.PasajeroConDiscapacidadMotriz)
            {
                if (this._lugarDiscapacitadoDisponible == true)
                {
                    this._listPasajeros.Add(unPasajero);
                    this._lugarDiscapacitadoDisponible = false;
                }
                else
                {
                    Console.WriteLine("No hay lugar");
                }
            }
            else
            {
                this._listPasajeros.Add(unPasajero);
            }
        }

        public override void SolicitanBajar(Pasajero unPasajero)
        {
            if (unPasajero.TipoDePasajero == eTipoPasajero.PasajeroConDiscapacidadMotriz)
            {
                Console.WriteLine("Bajar rampa discapacitados y desciende pasajero");
                this._listPasajeros.Remove(unPasajero);
                this._lugarDiscapacitadoDisponible = true;
            }
            else
            {
                Console.WriteLine("Desciende pasajero");
                this._listPasajeros.Remove(unPasajero);
            }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
