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
        public ColectivoPreparadoDiscapacitados()
        { }

        /*Implementacion de la clase abstracta*/
        public override void SacarBoleto()
        {
            throw new NotImplementedException();
        }

        public override void SolicitanBajar()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
