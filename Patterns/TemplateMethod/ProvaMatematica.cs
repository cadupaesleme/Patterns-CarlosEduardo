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
        //const double complexidade = 3;

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
