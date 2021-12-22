using System;
using System.Collections.Generic;
using System.Linq;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a classe aula";
            string aulaSets = "Trabalhando com conjuntos";

            //List<string> aulas = new List<string>
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            //Listas são arrayz dinâmicos ou seja, elas expandem ou diminuem de acordo com a necessidade
            //Não tem um tamanho fixo
            List<string> aulas = new List<string>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);
            Imprimir(aulas);
            Console.WriteLine();

            //Imprimindo a primeira E ULTIMA aula:
            Console.WriteLine("A primeira aula é " + aulas[0]);
            Console.WriteLine("A última aula é " + aulas[aulas.Count - 1]);
            Console.WriteLine();
            Console.WriteLine("A primeira aula é " + aulas.First());
            Console.WriteLine("A última aula é " + aulas.Last());
            Console.WriteLine();

            //Trocar o nome da primeira aula
            aulas[0] = "Trabalhando com Listas";
            Imprimir(aulas);
            Console.WriteLine();

            //Encontrar uma palavra dentro das listas
            Console.WriteLine("A primeira aula 'Trabalhando' é: " +
                aulas.First(aula => aula.Contains("Trabalhando")));
            Console.WriteLine("A última aula 'Trabalhando' é: " +
                aulas.Last(aula => aula.Contains("Trabalhando")));
            Console.WriteLine("A primeira aula 'Conclusão' é: " +
                aulas.FirstOrDefault(aula => aula.Contains("Conclusão")));
            Console.WriteLine();

            //Trocar a ordem da lista
            aulas.Reverse();
            Imprimir(aulas);
            Console.WriteLine();
            aulas.Reverse();
            Imprimir(aulas);
            Console.WriteLine();

            //Remover último elemento
            aulas.RemoveAt(aulas.Count - 1);
            Imprimir(aulas);
            Console.WriteLine();

            aulas.Add("Conclusão");

            //Ordenar a lista
            aulas.Sort();
            Imprimir(aulas);
            Console.WriteLine();

            //Copiando elementos de uma lista
            List<string> copia = aulas.GetRange(aulas.Count - 2, 2);
            Imprimir(copia);
            Console.WriteLine();

            //Clonar uma lista
            List<string> clone = new List<string>(aulas);
            Imprimir(clone);
            Console.WriteLine();

            //Remover os dois últimos itens da lista
            clone.RemoveRange(aulas.Count - 2, 2);
            Imprimir(clone);
            Console.WriteLine();
        }

        private static void Imprimir(List<string> aulas)
        {
            //foreach(var aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}

            //for(int i = 0; i< aulas.Count; i++)
            //{
            //    Console.WriteLine(aulas[i]);
            //}

            aulas.ForEach(aula =>
            {
                Console.WriteLine(aula);
            });
        }
    }
}
