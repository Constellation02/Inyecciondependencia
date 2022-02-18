using System;

namespace Inyecciondependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            IBebida nCubaLibre = new CubaLibre();
            Bartender nBartender = new Bartender(nCubaLibre);
            nBartender.Preparar();
            
        }
    }
}
