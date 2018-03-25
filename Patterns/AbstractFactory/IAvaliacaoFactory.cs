using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
    interface IAvaliacaoFactory
    {
        IEscrita GetEscrita(string escritaModalidade);
        IOral GetOral(string oralModalidade);
    }
}
