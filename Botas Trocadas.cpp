#include <iostream>

using namespace std;

int main() {
  int N, Bota, Pares = 0;
  int Direita[10000];
  int Esquerda[10000];
  string Lado;
  cin >> N;

  for(int i = 0; i < N; i++)
  {
     cin >> Bota >> Lado;
     if(Lado == "D")
        Direita[Bota]++;
     else if(Lado == "E")
             Esquerda[Bota]++;
     if(Direita[Bota] >= 1 && Esquerda[Bota] >= 1)
     {
       Pares++;
       Direita[Bota]--;
       Esquerda[Bota]--;
     }
  }
  cout << Pares << endl;
}