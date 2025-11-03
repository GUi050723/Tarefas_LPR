using System;

namespace ExercicioRetangulo
{
    class Retangulo
    {
    public double Altura { get; set; }
    public double Largura { get; set; }
    public double CalcArea()
        {
    return Altura * Largura;
        }

    public double CalcPerimetro()
        {
    return 2 * (Altura + Largura);
        }
    }    class Program
    {
   static void Main(string[] args)
        {
   Retangulo ret = new Retangulo();

   Console.Write("Digite a largura do retângulo: ");
   ret.Largura = double.Parse(Console.ReadLine());

   Console.Write("Digite a altura do retângulo: ");
   ret.Altura = double.Parse(Console.ReadLine());

   Console.WriteLine($"\nÁrea = {ret.CalcArea():F2}");
   Console.WriteLine($"Perímetro = {ret.CalcPerimetro():F2}");
        }
    }
}
