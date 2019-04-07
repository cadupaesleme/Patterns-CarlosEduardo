using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Composite
{
    public abstract class Prova
    {
        public IList<IQuestao> Questoes { get; set; }
        //const double tempoBase = 20;
        private string materia;

        public string Materia
        {
            get
            {
                return materia;
            }
            protected set
            {
                materia = value;
            }
        }



        public Prova()
        {
            Questoes = new List<IQuestao>();
        }

        //dependendo da materia aumenta a complexidade da prova e aumenta o tempo 
        public abstract double calculaComplexidade();

        public double calculaTempoProva()
        {
            return 20 * calculaComplexidade();
        }

        public void ExibirProva()
        {
            int pai = 0;

            foreach (IQuestao q in Questoes)
            {
                pai++;
                q.Exibir(1,pai.ToString(),0);
            }
        }
    }
}
