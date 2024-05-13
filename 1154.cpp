#include <iostream>
using namespace std;

int main() {
  int A, infinity = 0, count = 0;;
  float B = 0;
  
  for (int i = 0; i <= infinity; i++)
  {
    infinity = i + 1;
    cin >> A;
    
    if (A < 0)
    {
      break;
    
    }
    
    else 
    {
        B = B + A;
        count++;
    }
  }
 
  printf("%.2f\n", B / count);
}