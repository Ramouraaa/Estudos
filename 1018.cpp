#include <iostream>

using namespace std;

int main() {
  int r[7];
  int t;
  int Count = 100;
  cin >> t;

  for(int i = 0; i < 7; i++)
  {
     r[i] = t / Count;
     t = t % Count;
     if(i == 0)
     Count = 50;
     if(i == 1)
     Count = 20;
     if(i == 2)
     Count = 10;
     if(i == 3)
     Count = 5;
     if(i == 4)
     Count = 2;
     if(i == 5)
     Count = 1;
  }

  cout << t << "\n";
  cout << r[0] << " nota(s) de R$ 100,00\n";
  cout << r[1] << " nota(s) de R$ 50,00\n";
  cout << r[2] << " nota(s) de R$ 20,00\n";
  cout << r[3] << " nota(s) de R$ 10,00\n";
  cout << r[4] << " nota(s) de R$ 5,00\n";
  cout << r[5] << " nota(s) de R$ 2,00\n";
  cout << r[6] << " nota(s) de R$ 1,00\n";
}