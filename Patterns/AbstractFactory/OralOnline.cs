using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
    class OralOnline : IOral
    {
        public string Nome()
        {
            return "Online Oral";
        }
    }
}
