

int soma = 0;
int num;
for(num =50; num<=500;num++){
    if (num % 2 != 0 && num % 3 == 0)
    {
       soma = soma+num;
    }
}Console.WriteLine("A soma dos números ímpares múltiplos de 3 entre 50 e 500 é: "+soma);