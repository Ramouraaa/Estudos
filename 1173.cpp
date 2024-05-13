#include <iostream>

using namespace std;

int main() {
  int t;
  int v[10];
  cin >> t;
  for (int i = 0; i <= 9;i++)
  {
    v[i] = t;
    cout << "N[" << i << "] = " << v[i] << "\n";
    t += t;
  }
}