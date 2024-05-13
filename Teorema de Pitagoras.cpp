#include <iostream>
#include <math.h>
using namespace std;

int main() {
  float A, B, C;
  cout << "B = ";
  cin >> B;
  cout << "C = ";
  cin >> C;

  cout <<"A² = " << B << "² + " << C << "²\n";

  B = B * B;
  C = C + C;

  cout <<"A² = " << B << " + " << C << "\n";
  
  A = B + C;

  cout <<"A² = " << A << "\n";

  A = sqrt(A);

  cout << "√A = " << A << "\n";
}