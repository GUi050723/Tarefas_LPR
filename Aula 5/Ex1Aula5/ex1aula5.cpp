#include <iostream>
using namespace std;
int main(){
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

return 0;
}


