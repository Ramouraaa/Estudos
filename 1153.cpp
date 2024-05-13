#include <iostream>

using namespace std;

int Fatorial(int Numero) {
  int Count = Numero;
  for (int i = 1; i < Count; i++)
  { 
  Numero = Numero * i;
  }
  return Numero;
}

int main()
{
    int t;
    cin >> t;
    cout << Fatorial(t) << "\n";
    return 0;
}
            