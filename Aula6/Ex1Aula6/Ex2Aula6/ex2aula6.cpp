#include <iostream>
using namespace std;

void calcularMediaPares() {
   /* int quantidade;
    cout << "Digite a quantidade de números: ";
    cin >> quantidade;

    int contador = 0;
    int soma = 0;
    int numero;

    int i = 0;
    while (i < quantidade) {
        cout << "Digite o número " << i + 1 << ": ";
        cin >> numero;
        if (numero % 2 == 0) {
            soma += numero;
            contador++;
        }
        i++;
    }

    if (contador > 0) {
        float media = static_cast<float>(soma) / contador;
        cout << "A média dos números pares é: " << media << endl;
    } else {
        cout << "Nenhum número par foi digitado." << endl;
    }
}*/
int quantidade, numero;
int contador=0, soma = 0, pares = 0;
cout << "Quantos números você vai digitar? ";
cin >> quantidade;
while (contador < quantidade) {
    cout << "Digite o número #" << (contador + 1) << ": ";
    cin >> numero;

    if (numero % 2 == 0) {
        soma += numero;
        pares++;
    }

    contador++;
}
if (pares > 0) {
    double media = (double)soma / pares;
    cout << "Média dos números pares: " << media << endl;
} else {
    cout << "Nenhum número par foi digitado." << endl;
}


}


void somaImparesMultiplosDe3() {
 
int soma = 0;
int num;
for(num =50; num<=500;num++){
    if (num % 2 != 0 && num % 3 == 0)
    {
       soma = soma+num;
    }
}   cout << "A soma dos números ímpares múltiplos de 3 entre 50 e 500 é: " << soma << endl;
}


void somaDigitosDoQuadrado() {
    int numero,quadrado,soma;
    cout << "Digite um número: ";
    cin >> numero;

   quadrado = numero * numero;
    cout << "O quadrado de " << numero << " é " << quadrado << endl;

    soma = 0;
    while (quadrado > 0) {
        soma += quadrado % 10;
        quadrado /= 10;      
    }
    
    cout << "A soma dos dígitos do quadrado é: " << soma << endl;
   
}


int main() {
    int opcao;

    do {
        cout << "\n===== MENU =====\n";
        cout << "1. Media dos numeros pares \n";
        cout << "2. Soma de impares multiplos de 3 \n";
        cout << "3. Soma dos digitos do quadrado de um numero\n";
        cout << "0. Sair\n";
        cout << "Escolha uma opcao: ";
        cin >> opcao;

        switch (opcao) {
            case 1:
                calcularMediaPares();
                break;
            case 2:
                somaImparesMultiplosDe3();
                break;
            case 3:
                somaDigitosDoQuadrado();
                break;
            case 0:
                cout << "Encerrando o programa.\n";
                break;
            default:
                cout << "Opção inválida. Tente novamente.\n";
        }
    } while (opcao != 0);

    return 0;
}
