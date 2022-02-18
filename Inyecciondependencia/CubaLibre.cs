using System;
using System.Collections.Generic;
using System.Text;

namespace Inyecciondependencia
{
    class CubaLibre : IBebida
    {
        public void Preparar()
        {
            Console.WriteLine("Se hace un Cuba Libre");
        }
    }
}
