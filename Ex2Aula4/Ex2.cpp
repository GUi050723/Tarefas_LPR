#include <iostream>
using namespace std;
int main(){
    
int A,B;
cout << "Digite 2 números inteiros "<< endl;
cin >> A >> B;
if (A % B == 0 || B % A==0)
{
    cout << "São Multiplos"<< endl;
}else{
    cout<< "Não são Multiplos"<< endl;
}
}