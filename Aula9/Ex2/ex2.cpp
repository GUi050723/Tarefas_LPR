#include <iostream>
#include <list>
#include <math.h>
using namespace std;
int n;
int main(){
list<int> numeros;
cout << "Digite 100 numeros";
for (int i = 0; i < 100; ++i) {
cin >> n;
numeros.push_back(n);
}
numeros.push_back(n);
numeros.sort();
for (int m: numeros)
{
 cout << m << " ";
}


}