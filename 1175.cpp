#include <iostream>

using namespace std;

 int main() {
  int x;
  int N[20];
  for (int i = 0; i <= 19;i++)
  {
    cin >> x;
    N[i] = x;
  }
  x = 19;    
  for (int i = 0; i <= 19; i++)
  {
    cout << "N[" << i << "] = " << N[x] << "\n";
    x--;
  }
}

