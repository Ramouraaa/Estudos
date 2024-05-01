#include <iostream>

using namespace std;

int main() {
  int X_m, Y_m, X_r, Y_r;

  cin >> X_m >> Y_m >> X_r >> Y_r; 
  
  int Maria =  X_m - Y_m;
  if(Maria < 0) Maria *= -1;
  int Reuniao = X_r - Y_r;
  if(Reuniao < 0) Reuniao *= -1;
   cout << Maria + Reuniao << endl;

}