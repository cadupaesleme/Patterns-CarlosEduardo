using Patterns.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.TemplateMethod
{
    class ProvaPortugues : Prova
    {
        public ProvaPortugues()
        {
            Materia = "Português";
        }

        public override double calculaComplexidade()
        {
            return 2;
        }
    }
}
