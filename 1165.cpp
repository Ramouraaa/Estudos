#include <iostream>

using namespace std;

int Quadrado(int Numero) {
   int divisores = 0; 
   for(int i = 1; i <= Numero; i++)
   {
     if (Numero % i == 0)
     divisores++;
   }
  return divisores;
  }

int main()
{
  int Numero;
  int Count;
  cin >> Count;
  int V[Count];
  int N[Count];
  for (int i = 0; i < Count; i++)
  {
    cin >> Numero;
    /*if (Quadrado(Numero) == 2)
    {
    cout << Numero << " eh primo\n";
    }
    else
    {
    cout << Numero << " nao eh primo\n";
    }*/
    
    V[i] = Quadrado(Numero);
    N[i] = Numero;
  }
  for (int i = 0; i < Count; i++)
  {
    cout << V[i] << " (" << N[i] << ")\n";
  }
}
          