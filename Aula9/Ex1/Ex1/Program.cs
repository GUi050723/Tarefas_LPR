using System.Collections.Generic;
using System;
using System.Linq;

List<string> nomes = new();
System.Console.WriteLine("Digite os nomes");
nomes.Add(Console.ReadLine());
while (true)
{
string entrada = Console.ReadLine();
if (entrada.ToLower() == "fim")// to lower transforma tudo em minuscula
nomes.Add(entrada);
}
List<string> nomesOrdenados = nomes.OrderBy(nome => nome.Length).ToList(); // coloca em ordem de caracter!!!
foreach (string nome in nomesOrdenados)
{
Console.WriteLine(nome);
}