Console.Write("Digite o número de horas de treinamento por dia: ");
        int horasPorDia = int.Parse(Console.ReadLine());
        
        int diasPorSemana = 5; 
        int horasPorSemana = horasPorDia * diasPorSemana;
        
        Console.WriteLine($"Horas de treinamento por semana: {horasPorSemana}");
        
        int totalHoras = 1000;
        int semanas = 0;
        int horasAcumuladas = 0;
        
        while (horasAcumuladas < totalHoras)
        {
            horasAcumuladas += horasPorSemana;
            semanas++;
        }
        
        int dias = semanas * diasPorSemana;
        double meses = semanas / 4.5;
        
        Console.WriteLine($"Para atingir 1000 horas de treinamento, será necessário:");
        Console.WriteLine($"- {dias} dias úteis");
        Console.WriteLine($"- {semanas} semanas");
        Console.WriteLine($"- {meses:F2} meses");