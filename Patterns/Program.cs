using Patterns.AbstractFactory;
using Patterns.Composite;
using Patterns.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {

            //Primeiramente gera as avaliações possiveis para o curso em Primeira Avaliacao e Segunda Avaliacao
            //Utilizado o padrão abstract factory para construir as avaliações
            IAvaliacaoFactory primeiraAvaliacaoFactory = new PrimeiraAvaliacao();
            IAvaliacaoFactory segundaAvaliacaoFactory = new SegundaAvaliacao();

            Console.WriteLine("-------------------------- Gerando os Modos de Avaliação do Curso --------------------------");
            Console.WriteLine("");
            Console.WriteLine("--------- Primeira Avaliação ---------");
            Avaliacao primeiraAvaliacao = new Avaliacao(primeiraAvaliacaoFactory, "Presencial");
            Console.WriteLine(primeiraAvaliacao.GetAvaliacaoEscrita());
            Console.WriteLine(primeiraAvaliacao.GetAvaliacaoOral());

            primeiraAvaliacao = new Avaliacao(primeiraAvaliacaoFactory, "Online");
            Console.WriteLine(primeiraAvaliacao.GetAvaliacaoEscrita());
            Console.WriteLine(primeiraAvaliacao.GetAvaliacaoOral());

            Console.WriteLine("");
            Console.WriteLine("--------- Segunda Avaliação ---------");
            Avaliacao segundaAvaliacao = new Avaliacao(segundaAvaliacaoFactory, "Presencial");
            Console.WriteLine(segundaAvaliacao.GetAvaliacaoEscrita());
            Console.WriteLine(segundaAvaliacao.GetAvaliacaoOral());

            segundaAvaliacao = new Avaliacao(segundaAvaliacaoFactory, "Online");
            Console.WriteLine(segundaAvaliacao.GetAvaliacaoEscrita());
            Console.WriteLine(segundaAvaliacao.GetAvaliacaoOral());


            //Gerar 2 provas escritas (primeira avaliacao e segunda avaliacao)
            Console.WriteLine("");
            Console.WriteLine("-------------------------- Gerando as Provas Escritas do Curso --------------------------");
            Console.WriteLine("");

            GerarProvaMatematica();

            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("");

            GerarProvaPortugues();

            Console.ReadLine();


        }

        private static void GerarProvaPortugues()
        {
            //cria uma prova de Portugues
            Prova provaEscrita2 = new ProvaPortugues();

            Console.WriteLine("Prova de " + provaEscrita2.Materia);
            Console.WriteLine("Tempo Estimado em Minutos: " + provaEscrita2.calculaTempoProva());
            Console.WriteLine("");


            QuestaoComposite questao1Port = new QuestaoComposite { Enunciado = "Enunciado" };
            QuestaoObjetiva questao1PortObj = new QuestaoObjetiva { Enunciado = "Enunciado da Questão" };
            questao1PortObj.AdicionarAlternativa(new Alternativa { Nome = "Alternativa1" });
            questao1PortObj.AdicionarAlternativa(new Alternativa { Nome = "Alternativa2" });
            questao1PortObj.AdicionarAlternativa(new Alternativa { Nome = "Alternativa3" });

            questao1Port.Adicionar(questao1PortObj);

            //questao composta com subquestoes simples e subquestoes compostas
            QuestaoComposite compositePort = new QuestaoComposite { Enunciado = "Enunciado da Questão" };
            compositePort.Adicionar(new QuestaoDiscursiva { Enunciado = "Enunciado da Questão" });

            QuestaoComposite composite2Port = new QuestaoComposite { Enunciado = "Enunciado da Questão" };
            composite2Port.Adicionar(new QuestaoDiscursiva { Enunciado = "Enunciado da Questão" });
            compositePort.Adicionar(composite2Port);

            questao1Port.Adicionar(compositePort);

            provaEscrita2.Questoes.Add(questao1Port);

            provaEscrita2.Questoes.Add(new QuestaoDiscursiva { Enunciado = "Enunciado da Questão Simples" });


            //questao com subquestoes
            QuestaoComposite questao2Port = new QuestaoComposite { Enunciado = "Enunciado" };
            questao2Port.Adicionar(new QuestaoDiscursiva { Enunciado = "Enunciado da Questão" });
            provaEscrita2.Questoes.Add(questao2Port);

            provaEscrita2.ExibirProva();
        }

        private static void GerarProvaMatematica()
        {
            //cria uma prova de Matematica
            Prova provaEscrita1 = new ProvaMatematica();

            Console.WriteLine("Prova de " + provaEscrita1.Materia);
            Console.WriteLine("Tempo Estimado em Minutos: " + provaEscrita1.calculaTempoProva());
            Console.WriteLine("");

            /*criar questoes para a prova*/

            //questao composta com 2 subquestoes de tipos diferentes
            QuestaoComposite questao1Mat = new QuestaoComposite { Enunciado = "Enunciado" };
            QuestaoObjetiva questao1MatObj = new QuestaoObjetiva { Enunciado = "Enunciado da Questão" };
            questao1MatObj.AdicionarAlternativa(new Alternativa { Nome = "Alternativa1" });
            questao1MatObj.AdicionarAlternativa(new Alternativa { Nome = "Alternativa2" });
            questao1MatObj.AdicionarAlternativa(new Alternativa { Nome = "Alternativa3" });
            questao1Mat.Adicionar(questao1MatObj);


            questao1Mat.Adicionar(new QuestaoDiscursiva { Enunciado = "Enunciado da Questão" });

            //questao composta com subquestoes simples e subquestoes compostas
            QuestaoComposite compositeMat = new QuestaoComposite { Enunciado = "Enunciado da Questão" };
            compositeMat.Adicionar(new QuestaoDiscursiva { Enunciado = "Enunciado da Questão" });

            QuestaoComposite composite2Mat = new QuestaoComposite { Enunciado = "Enunciado da Questão" };
            composite2Mat.Adicionar(new QuestaoDiscursiva { Enunciado = "Enunciado da Questão" });
            compositeMat.Adicionar(composite2Mat);

            questao1Mat.Adicionar(compositeMat);

            provaEscrita1.Questoes.Add(questao1Mat);


            //questao com subquestao
            QuestaoComposite questao2Mat = new QuestaoComposite { Enunciado = "Enunciado" };
            provaEscrita1.Questoes.Add(questao2Mat);

            //questao com subquestoes
            QuestaoComposite questao3Mat = new QuestaoComposite { Enunciado = "Enunciado" };
            questao3Mat.Adicionar(new QuestaoDiscursiva { Enunciado = "Enunciado da Questão" });
            QuestaoObjetiva questao3MatObj = new QuestaoObjetiva { Enunciado = "Enunciado da Questão" };
            questao3MatObj.AdicionarAlternativa(new Alternativa { Nome = "Alternativa1" });
            questao3MatObj.AdicionarAlternativa(new Alternativa { Nome = "Alternativa2" });
            questao3MatObj.AdicionarAlternativa(new Alternativa { Nome = "Alternativa3" });

            questao3Mat.Adicionar(questao3MatObj);

            provaEscrita1.Questoes.Add(questao3Mat);

            provaEscrita1.ExibirProva();
        }
    }
}
