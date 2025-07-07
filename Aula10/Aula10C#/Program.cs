using System.Collections.Generic;


namespace Aula10C_

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> idade = new Dictionary<string, int>
            {
                {"Guilherme",18},{"Julia",22},{"Maria",12},{"Pedro",16}
            };
            int soma = 0;

            foreach (var pessoa in idade)
            {
                soma += pessoa.Value;
            }
            float media = soma / idade.Count;
            foreach (var pessoa in idade)
            {
                if (pessoa.Value>media)
                {
                    Console.WriteLine(($"Aluno: {pessoa.Key}, Idade: {pessoa.Value}"));
                }
               
            }
            int idadeMax = int.MinValue;
            int idadeMin = int.MaxValue;
            string maisVelho = "", maisNovo = "";
            foreach (var pessoa in idade)
            {
                if (pessoa.Value > idadeMax)
                {
                    idadeMax = pessoa.Value;
                    maisVelho = pessoa.Key;
                }
                if (pessoa.Value < idadeMin)
                {
                    idadeMin = pessoa.Value;
                    maisNovo = pessoa.Key;
                }
                
            }
            Console.WriteLine($"\nPessoa mais velha: {maisVelho} ({idadeMax} anos)");
            Console.WriteLine($"Pessoa mais nova: {maisNovo} ({idadeMin} anos)");


        }
    }
}
