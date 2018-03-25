using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Composite
{
    public interface IQuestao
    {
        string Enunciado { get; set; }
        TipoQuestao TipoQuestao { get; set; }

        void Adicionar(IQuestao questao);        
        void Remover(IQuestao questao);        
        void Exibir(int i, string pai, int iterador);
    }

    //QuestaoComposta é uma questão que possui subitens 
    public enum TipoQuestao { Discursiva, Objetiva, Questão_Composta };
}
