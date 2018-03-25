using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Composite
{
    public class QuestaoObjetiva : IQuestao
    {
        public string Enunciado { get; set; }
        public TipoQuestao TipoQuestao { get; set; }
        private List<Alternativa> Alternativas = new List<Alternativa>();


        //constroi questao discursiva
        public QuestaoObjetiva() { TipoQuestao = TipoQuestao.Objetiva; }

        public void Adicionar(IQuestao questao)
        {
            Console.WriteLine("Não pode adicionar subquestão");
        }

        public void Remover(IQuestao questao)
        {
            Console.WriteLine("Não pode remover subquestão");
        }

        public void AdicionarAlternativa(Alternativa alternativa)
        {
            Alternativas.Add(alternativa);
        }

        public void RemoverAlternativa(Alternativa alternativa)
        {
            Alternativas.Remove(alternativa);
        }

        public void Exibir(int i, string pai, int iterador)
        {
            string enunciado = ") " + Enunciado + " - (" + TipoQuestao + ")";

            //se for o primeiro iterador nao exibe pois é 0
            if (iterador == 0)
                Console.WriteLine(new String(' ', i) + pai + enunciado);
            else
                Console.WriteLine(new String(' ', i) + pai + "." + iterador + enunciado);

            //coloca as alternativas
            if (Alternativas.Count() > 0)
            {
                Console.WriteLine(new String(' ', i+1) + "Alternativas:");
                Console.WriteLine("");

                char letra = 'a';
                foreach (Alternativa alt in Alternativas)
                {
                    Console.WriteLine(new String(' ', i+1) + letra + ") " + alt.Nome);
                    letra++;
                }
                Console.WriteLine("");

            }

        }
    }
}
