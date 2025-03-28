#include <iostream>
using namespace std;
int numero,quadrado,soma;
int main() {
    
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
