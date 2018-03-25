using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
    class EscritaOnline : IEscrita
    {
        public string Nome()
        {
            return "Online Escrita";
        }
    }
}
