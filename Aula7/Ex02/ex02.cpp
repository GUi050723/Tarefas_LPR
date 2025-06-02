#include <iostream>
#include <vector>
using namespace std;
vector<int> numeros(10);
int procurado;
int ocorrencias=0;
    int main(){
        cout << "Digite 10 numeros inteiros \n";
        for (int i=0;i< numeros.size();i++){
        cout << "Número " << i + 1 << ": ";    
        cin >> numeros[i];
    }  
     cout << "Digite um numero que gostaria de pesquisar";
        cin >> procurado;
        cout << "\nO número " << procurado << " foi encontrado nas posições: ";
        
        for (int i = 0; i < numeros.size(); i++)
        {
            if (numeros[i]==procurado)
            {
                cout << i << "";
                ocorrencias++;
            }
            
        }
        if (ocorrencias>0)
        {
            cout << "\nTotal de ocorrências: " << ocorrencias << endl;
        }else{
                      cout << "\nO número não foi encontrado no vetor." << endl;

        }
        

    } 