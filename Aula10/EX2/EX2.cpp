#include <iostream>
#include <map>
using namespace std;

int main() {
    map<string, int> cidades = {
        {"São Paulo", 11451999},
        {"Rio de Janeiro", 6211223},
        {"Curitiba", 1948626}
    };

    int soma = 0;
    for (auto cidade : cidades) {
        soma += cidade.second;
    }

    float media = soma / (float)cidades.size();

    cout << "Cidades com populacao acima da media:\n";
    for (auto cidade : cidades) {
        if (cidade.second > media) {
            cout << cidade.first << ": " << cidade.second << endl;
        }
    }

    string maisPop;
    string menosPop;
    int maior = 0, menor = INT32_MAX;

    for (auto cidade : cidades) {
        if (cidade.second > maior) {
            maior = cidade.second;
            maisPop = cidade.first;
        }
        if (cidade.second < menor) {
            menor = cidade.second;
            menosPop = cidade.first;
        }
    }

    cout << "\nMais populosa: " << maisPop << endl;
    cout << "Menos populosa: " << menosPop << endl;

    int y;
    cout << "\nDigite a populacao para remover: ";
    cin >> y;

    for (auto it = cidades.begin(); it != cidades.end(); ) {
        if (it->second == y) {
            it = cidades.erase(it);
        }
        else {
            ++it;
        }
    }

    cout << "\nCidades restantes:\n";
    for (auto cidade : cidades) {
        cout << cidade.first << ": " << cidade.second << endl;
    }

    return 0;
}
