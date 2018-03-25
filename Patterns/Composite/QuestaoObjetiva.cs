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

        //constroi questao discursiva
        public QuestaoObjetiva() { TipoQuestao = TipoQuestao.Objetiva; }

        public void Adicionar(IQuestao questao)
        {
            //Console.WriteLine("Cannot add to a PrimitiveElement");
        }

        public void Remover(IQuestao questao)
        {
            //Console.WriteLine("Cannot remove from a PrimitiveElement");
        }

        public void Exibir(int i, string pai, int iterador)
        {
            string enunciado = ") " + Enunciado + " - (" + TipoQuestao + ")";

            //se for o primeiro iterador nao exibe pois é 0
            if (iterador == 0)
                Console.WriteLine(new String(' ', i) + pai + enunciado);
            else
                Console.WriteLine(new String(' ', i) + pai + "." + iterador + enunciado);

        }
    }
}
