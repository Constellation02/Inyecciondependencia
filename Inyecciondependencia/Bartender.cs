using System;
using System.Collections.Generic;
using System.Text;

namespace Inyecciondependencia
{
    class Bartender
    {
        IBebida bebida;
        public Bartender(IBebida _bebida)
        {
            this.bebida = _bebida;
        }
        public void Preparar()
        {
            this.bebida.Preparar();
        }
    }
}
