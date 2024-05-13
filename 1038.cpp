#include <iostream>

using namespace std;

int main() {
  int Opcao, Quantidade;
  float p[] = {4, 4.5, 5, 2, 1.5};

  cin >> Opcao >> Quantidade;

  cout.setf(ios::fixed);
  cout.precision(2);
  cout << "Total: R$ " << p[Opcao - 1] * Quantidade << endl;
}