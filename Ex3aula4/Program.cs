 Console.WriteLine("Escolha uma classe de personagem:");
        Console.WriteLine("1 - Guerreiro");
        Console.WriteLine("2 - Mago");
        Console.WriteLine("3 - Arqueiro");
Console.Write("Digite o número da classe escolhida: ");
        string escolha = Console.ReadLine();
switch (escolha)
        {
            case "1":
                Console.WriteLine("Classe escolhida: Guerreiro");
                Console.WriteLine("Habilidades especiais:");
                Console.WriteLine("- Golpe Poderoso");
                Console.WriteLine("- Defesa Implacável");
                Console.WriteLine("- Grito de Guerra");
                break;

            case "2":
                Console.WriteLine("Classe escolhida: Mago");
                Console.WriteLine("Habilidades especiais:");
                Console.WriteLine("- Bola de Fogo");
                Console.WriteLine("- Teleporte");
                Console.WriteLine("- Escudo Arcano");
                break;

            case "3":
                Console.WriteLine("Classe escolhida: Arqueiro");
                Console.WriteLine("Habilidades especiais:");
                Console.WriteLine("- Tiro Preciso");
                Console.WriteLine("- Flecha Explosiva");
                Console.WriteLine("- Camuflagem");
                break;
                default:
                Console.WriteLine("Classe inválida. Tente novamente.");
                break;
        }
