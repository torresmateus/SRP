using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class CozinheiroErrado
    {
        public void fazerPrato(Prato prato)
        {
            prato.Fazer();   
        }

        public double valorDoPrato(Prato prato)
        {
            return prato.valor;
        }

        public void servirPratos()
        {
            Console.WriteLine("Bon Appetit");
        }
    }
}
