#include <iostream>

using namespace std;

bool V[1000005];

int main() {
  int n, presente = 0, x;
  cin >> n;

 for(int i = 0; i < n;i++)
 {
     cin >> x;
     if(!V[x])
     {
        V[x] = true;
        presente++;
     }
 }
 cout << presente << "\n";
}