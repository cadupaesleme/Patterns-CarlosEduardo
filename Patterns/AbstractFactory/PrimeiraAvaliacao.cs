using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
    class PrimeiraAvaliacao : IAvaliacaoFactory
    {
        public IEscrita GetEscrita(string escritaModalidade)
        {
            switch (escritaModalidade)
            {
                case "Presencial":
                    return new EscritaPresencial();
                case "Online":
                    return new EscritaOnline();
                default:
                    throw new ApplicationException("Modalidade " + escritaModalidade + " não pode ser criada.");
            }
        }

        public IOral GetOral(string oralModalidade)
        {
            switch (oralModalidade)
            {
                case "Presencial":
                    return new OralPresencial();
                case "Online":
                    return new OralOnline();
                default:
                    throw new ApplicationException("Modalidade " + oralModalidade + " não pode ser criada.");
            }
        }
    }
}
