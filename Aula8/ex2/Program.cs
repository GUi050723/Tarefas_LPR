using System;
public struct Produto
{
    public string nome;
    public int codigo;
    public float preco;
    public int qtd;
}
class aula8
{
    static void Main()
    {
        Produto[] produtos = new Produto[3];
        for (int i = 0; i < produtos.Length; i++)
        {
            Console.WriteLine($"Digite os dados do produto {i + 1}:");

            Console.Write("Nome: ");
            produtos[i].Nome = Console.ReadLine();

            Console.Write("Código: ");
            produtos[i].Codigo = int.Parse(Console.ReadLine());

            Console.Write("Preço: ");
            produtos[i].Preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            produtos[i].Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
        }

        double valorTotal = 0;

        for (int i = 0; i < produtos.Length; i++)
        {
            valorTotal += produtos[i].Preco * produtos[i].Quantidade;
        }

        Console.WriteLine($"Valor total em estoque: R$ {valorTotal:F2}");
    }
}
    
