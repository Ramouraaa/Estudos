#include <iostream>

using namespace std;

int main() {
  int km, h;
  cin >> h >> km;

  float L = km * h;
  L = L / 12;

  printf("%.3f\n", L);

}