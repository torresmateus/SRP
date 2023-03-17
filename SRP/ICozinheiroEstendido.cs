using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public interface ICozinheiroEstendido
    {
        // Interface para demonstrar que apesar de varios metodos todos dizem respeito a mesma responsabilidade. ("fazerPrato")
        void cortarLegumes();
        void salgarCarne();
        void cozinharMassa();
        void temperar();
        void montarPrato();
    }
}
