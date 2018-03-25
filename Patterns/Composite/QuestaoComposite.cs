using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Composite
{
    class QuestaoComposite : IQuestao
    {
        public string Enunciado { get; set; }
        public TipoQuestao TipoQuestao { get; set; }
        private List<IQuestao> SubQuestoes = new List<IQuestao>();

        //QuestaoComposta é uma questão que possui subitens 
        public QuestaoComposite() { TipoQuestao = TipoQuestao.Questão_Composta; }

        public void Adicionar(IQuestao questao)
        {
            SubQuestoes.Add(questao);
        }

        public void Remover(IQuestao questao)
        {
            SubQuestoes.Remove(questao);
        }

        public void Exibir(int i, string pai, int iterador)
        {
            string enunciado = ") " + Enunciado + " - (" + TipoQuestao + ")";

            //se for o primeiro iterador nao exibe pois é 0
            if (iterador == 0)
                Console.WriteLine(new String(' ', i) + pai + enunciado);
            else
                Console.WriteLine(new String(' ', i) + pai + "." + iterador + enunciado);

            //desce um nivel no pai
            if (this.GetType() == typeof(QuestaoComposite) && iterador != 0)
            {
                pai = pai + "." + iterador;
                iterador = 0;
            }


            //exibe os filhos
            foreach (IQuestao q in SubQuestoes)
            {
                iterador++;
                q.Exibir(i + 1, pai, iterador);
            }
        }
    }
}
