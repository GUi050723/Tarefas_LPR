#include <iostream>
using namespace std;

struct livros {
    string Titulo;
    string Autor;
    int AnoPubli;
    int Npag;
    double Preco;
};

int main() {
    livros Livro[3];

    double PrecoTotal = 0;     
    int TotalPaginas = 0;      

    for (int i = 0; i < 3; i++) {
        cout << "Livro " << i + 1 << ":\n";

        cout << "Titulo: ";
        cin >> Livro[i].Titulo;

        cout << "Autor: ";
        cin >> Livro[i].Autor;

        cout << "Ano de Publicacao: ";
        cin >> Livro[i].AnoPubli;

        cout << "Numero de Paginas: ";
        cin >> Livro[i].Npag;

        cout << "Preco: ";
        cin >> Livro[i].Preco;

        PrecoTotal += Livro[i].Preco;
        TotalPaginas += Livro[i].Npag;

        cout << endl;
    }

    float Media = TotalPaginas / 3;

    cout << "O preco total dos livros sera: R$ " << PrecoTotal << endl;
    cout << "A media de paginas dos livros é: " << Media << " paginas" << endl;

    return 0;
}
