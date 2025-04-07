#include <iostream>
using namespace std;

int reverterNumero(int numero) {
    
    int reverso = 0;
    while (numero != 0) {
        int digito = numero % 10;
        reverso = reverso * 10 + digito;
        numero /= 10;
    }
    return reverso;
}

int main() {
    int numero;
    cout << "Digite um numero inteiro: ";
    cin >> numero;

    int resultado = reverterNumero(numero);
    cout << "Numero invertido: " << resultado << endl;

    return 0;
}