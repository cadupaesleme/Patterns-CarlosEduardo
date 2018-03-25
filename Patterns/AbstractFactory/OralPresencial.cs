using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
    class OralPresencial : IOral
    {
        public string Nome()
        {
            return "Presencial Oral";
        }
    }
}
