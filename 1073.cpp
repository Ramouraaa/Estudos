#include <iostream>

using namespace std;
int Quadrado(int i) {
  i *= i;
  return i;
  }

void Universo()
{
  int N;
  cin >> N;
  if (N % 2 == 0)
  {
  
  }
  else
  {
    N -= 1;
  }
  for (int i = 2; N >= i; i += 2)
  {
       cout << i << "^2" << " = " << Quadrado(i) << "\n";
  }
}

int main()
{
    Universo();
    return 0;
}

