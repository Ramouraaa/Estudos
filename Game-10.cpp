#include <iostream>

using namespace std;

int main() {
  int N, D, A;
  cin >> N >> D >> A;
  if(A > D)  A = (N - A) + D;
  else  A = D - A;

  cout << A;
}