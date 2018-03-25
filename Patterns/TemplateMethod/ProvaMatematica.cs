using Patterns.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.TemplateMethod
{
    class ProvaMatematica : Prova
    {
        public ProvaMatematica()
        {
            Materia = "Matemática";
        }


        public override double calculaComplexidade()
        {
            return 3;
        }
    }
}
