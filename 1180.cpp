#include <iostream>

using namespace std;

int main() {
  int Count;
  cin >> Count;
  int V[Count];
  Count--;
  for(int i = 0; i <= Count; i++)
  {
    cin >> V[i];
  }
  int Menor = V[0];
  int Contador = 0;
  for (int i = 0; i <= Count; i++) 
  {
    if (Menor > V[i])
    {
      Menor = V[i];
      Contador = i;
    }
  }
  cout << "Menor valor: " << Menor << "\n";
  cout << "Posicao: " << Contador << "\n";
  return 0;
  }