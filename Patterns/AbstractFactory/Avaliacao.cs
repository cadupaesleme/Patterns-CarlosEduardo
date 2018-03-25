using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
    class Avaliacao
    {
        IEscrita escrita;
        IOral oral;

        public Avaliacao(IAvaliacaoFactory avaliacaoFactory, string modalidade)
        {
            escrita = avaliacaoFactory.GetEscrita(modalidade);
            oral = avaliacaoFactory.GetOral(modalidade);
        }

        public string GetAvaliacaoEscrita()
        {
            return escrita.Nome();
        }

        public string GetAvaliacaoOral()
        {
            return oral.Nome();
        }
    }
}
