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
        public ColectivoNormal()
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
    }
}
