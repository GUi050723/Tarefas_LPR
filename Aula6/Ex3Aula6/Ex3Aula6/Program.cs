using System;

class Program
{
    // Heróis cadastrados
    static string nome1, nome2, nome3, nome4, nome5;
    static string poder1, poder2, poder3, poder4, poder5;
     static int pontos1, pontos2, pontos3, pontos4, pontos5;

    // Heróis da equipe
   static string equipeNome1, equipeNome2, equipeNome3;
     static string equipePoder1, equipePoder2, equipePoder3;
   static int equipePontos1, equipePontos2, equipePontos3;

    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1 - Cadastrar Heróis");
            Console.WriteLine("2 - Selecionar Equipe");
            Console.WriteLine("3 - Exibir Equipe");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CadastrarHerois();
                    break;
                case 2:
                    SelecionarEquipe();
                    break;
                case 3:
                    ExibirEquipe();
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (opcao != 0);
    }

    static void CadastrarHerois()
    {
        Console.WriteLine("\n--- Cadastro de Heróis ---");

        Console.Write("Nome do Herói 1: ");
        nome1 = Console.ReadLine();
        Console.Write("Poder do Herói 1: ");
        poder1 = Console.ReadLine();
        Console.Write("Pontuação do Herói 1: ");
        pontos1 = int.Parse(Console.ReadLine());

        Console.Write("Nome do Herói 2: ");
        nome2 = Console.ReadLine();
        Console.Write("Poder do Herói 2: ");
        poder2 = Console.ReadLine();
        Console.Write("Pontuação do Herói 2: ");
        pontos2 = int.Parse(Console.ReadLine());

        Console.Write("Nome do Herói 3: ");
        nome3 = Console.ReadLine();
        Console.Write("Poder do Herói 3: ");
        poder3 = Console.ReadLine();
        Console.Write("Pontuação do Herói 3: ");
        pontos3 = int.Parse(Console.ReadLine());

        Console.Write("Nome do Herói 4: ");
        nome4 = Console.ReadLine();
        Console.Write("Poder do Herói 4: ");
        poder4 = Console.ReadLine();
        Console.Write("Pontuação do Herói 4: ");
        pontos4 = int.Parse(Console.ReadLine());

        Console.Write("Nome do Herói 5: ");
        nome5 = Console.ReadLine();
        Console.Write("Poder do Herói 5: ");
        poder5 = Console.ReadLine();
        Console.Write("Pontuação do Herói 5: ");
        pontos5 = int.Parse(Console.ReadLine());

        Console.WriteLine("Cadastro concluído!");
    }

    static void SelecionarEquipe()
    {
        Console.WriteLine("\n--- Seleção da Equipe ---");
        Console.WriteLine("1 - " + nome1);
        Console.WriteLine("2 - " + nome2);
        Console.WriteLine("3 - " + nome3);
        Console.WriteLine("4 - " + nome4);
        Console.WriteLine("5 - " + nome5);

        Console.Write("Escolha o número do 1º herói: ");
        int n1 = int.Parse(Console.ReadLine());
        SelecionarHeroi(n1, out equipeNome1, out equipePoder1, out equipePontos1);
        //OUT Com out, a função pode devolver vários valores ao mesmo tempo.
        Console.Write("Escolha o número do 2º herói: ");
        int n2 = int.Parse(Console.ReadLine());
        SelecionarHeroi(n2, out equipeNome2, out equipePoder2, out equipePontos2);

        Console.Write("Escolha o número do 3º herói: ");
        int n3 = int.Parse(Console.ReadLine());
        SelecionarHeroi(n3, out equipeNome3, out equipePoder3, out equipePontos3);

        Console.WriteLine("Equipe selecionada com sucesso!");
    }

    static void SelecionarHeroi(int numero, out string nome, out string poder, out int pontos)
    {
        nome = ""; poder = ""; pontos = 0;

        switch (numero)
        {
            case 1:
                nome = nome1;
                poder = poder1;
                pontos = pontos1;
                break;
            case 2:
                nome = nome2;
                poder = poder2;
                pontos = pontos2;
                break;
            case 3:
                nome = nome3;
                poder = poder3;
                pontos = pontos3;
                break;
            case 4:
                nome = nome4;
                poder = poder4;
                pontos = pontos4;
                break;
            case 5:
                nome = nome5;
                poder = poder5;
                pontos = pontos5;
                break;
            default:
                Console.WriteLine("Número inválido! Herói vazio.");
                break;
        }
    }

    static void ExibirEquipe()
    {
        Console.WriteLine("\n--- Equipe Selecionada ---");
        Console.WriteLine("Herói 1: " + equipeNome1 + " | Poder: " + equipePoder1 + " | Pontos: " + equipePontos1);
        Console.WriteLine("Herói 2: " + equipeNome2 + " | Poder: " + equipePoder2 + " | Pontos: " + equipePontos2);
        Console.WriteLine("Herói 3: " + equipeNome3 + " | Poder: " + equipePoder3 + " | Pontos: " + equipePontos3);

        int total = equipePontos1 + equipePontos2 + equipePontos3;
        Console.WriteLine("Pontuação Total da Equipe: " + total);
    }
}
