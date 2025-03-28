Random numAleatorio = new Random();
int tentativa;
int contadorTentativas = 0;
int valorInteiro = numAleatorio.Next(1,100);
Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
Console.WriteLine("Tente adivinhar um número entre 1 e 100 ");
do
{
    Console.WriteLine("Digite seu palpite!!");
    tentativa = int.Parse(Console.ReadLine());
     contadorTentativas++;
     if (tentativa<valorInteiro)
     {
        Console.WriteLine("Chutou baixo!");
     }else if (tentativa > valorInteiro)
     {
         Console.WriteLine("Chutou alto!");
     }else
     {
        Console.WriteLine($"Acertou! O número era {valorInteiro}.");
                Console.WriteLine($"Você acertou em {contadorTentativas} tentativas.");
     }
} while (tentativa!= valorInteiro);

