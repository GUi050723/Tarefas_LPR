//const int x = 4;
using System.IO.Compression;

string []cidades = { "Vitoria", "Belo Horizonte", "Rio de Janeiro", "São Paulo" };


int[,] distancia = {
        {0,524, 521, 882},
        {524, 0, 434,586},
        {521, 434, 0,429},
        {882, 586, 429,0}
};
int origem, destino;
        System.Console.WriteLine("Digite a cidade de origem\n 0-Vitoria\n 1-BH\n 2-RJ\n 3-SP ");
        origem = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Digite a cidade de destino\n 0-Vitoria\n 1-BH\n 2-RJ\n 3-SP");
        destino = int.Parse(Console.ReadLine());

if (origem < 0 || origem >= cidades.Length || destino < 0 || destino >= cidades.Length)
{
    Console.WriteLine("Entrada inválida. Tente novamente.");
}
if (origem != destino)
{
    System.Console.WriteLine($"Distância entre {cidades[origem]} e {cidades[destino]} é {distancia[origem, destino]} km.");
}