int[] numero = new int[10];
int[] pares = new int[10];
int[] impar = new int[10];
int contPar = 0;
int contImpar = 0;

for (int i = 0; i < numero.Length; i++)
{
    Console.Write($"Digite o {i + 1}º número inteiro: ");
    numero[i] = int.Parse(Console.ReadLine());
    if (numero[i] % 2 == 0)
    {
        pares[contPar] = numero[i];
        contPar++;
        // System.Console.WriteLine(pares[i] + " ");
    }
    else
    {
        impar[contImpar] = numero[i];
        contImpar++;
        // System.Console.WriteLine(impar[i] + " ");
    }
}
 Console.WriteLine("\nNúmeros pares digitados:");
        for (int i = 0; i < contPar; i++)
        {
            Console.Write(pares[i] + " ");
        }

        
        Console.WriteLine("\n\nNúmeros ímpares digitados:");
        for (int i = 0; i < contImpar; i++)
        {
            Console.Write(impar[i] + " ");
        }