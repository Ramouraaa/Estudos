#include <iostream>

using namespace std;

int main() {
  int Count;
  int X = 0;
  cin >> Count;
  int N[Count + 1];
  Count++;

  for(int i = 1; i <= Count; i++)
  {
    X += i;
    N[i] = X;
  }
  cout << N[Count] << "\n";

}