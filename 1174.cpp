#include <iostream>

using namespace std;

int main() {
  double x;
  double A[100];
  for (int i = 0; i <= 99;i++)
  {
    cin >> x;
    A[i] = x;
    if (x <= 10)
    {
    cout.setf(ios::fixed);
    cout.precision(1);
    cout << "A[" << i << "] = " << A[i] << "\n";
    }
  }
}