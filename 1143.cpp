#include <iostream>
using namespace std;

int main() {
  int N, X = 1, Y,Soma = 1, Soma2 = 1, t1 = 1, t2 = 1;
  cin >> N;

  for (int i = 1; i <= N; i++)
  {
    printf("%d %d %d\n", i, Soma, Soma2);
    t2 += 2 + t1;
    Soma = t2 + t1;
    t1++;
    X += 2; 
    Soma2 = Soma * (i + 1);
  }
}