using System;
using System.Collections.Generic;
using System.Text;

namespace Inyecciondependencia
{
  public class Mojito : IBebida
    {
        public void Preparar()
        {
            Console.WriteLine("Se hace un mojito");
        }
    }
}
