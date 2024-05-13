#include <iostream>

using namespace std;

int main() {
  long long int Count;
    long long int x;
    cin >>  Count;
    Count++;
    long long int V[Count];

    for(long long int i = 1; i < Count; i++)
    { 
      cin >> x;
      V[i] = x; 
    }
    long long int t = 1;
    long long int A = 0;      
    long long int B = 1;      
    long long int C = 0;
    for(long long int i = 1;i <= 61; i++)
    {
      if(V[t] == 0)
      {
        i = 0;
      }
      if(i == 1)
      {
        C = 1;
      }
      if(i > 1)
      {
        C = A + B;
        A = B;
        B = C; 
      }
      if (V[t] == i)
      {       
        cout << "Fib(" << V[t] << ") = " << C << "\n";
        A = 0;      
        B = 1;
        i = 0;      
        C = 0; 
        t++;
        if (t == Count)
        {
          break;
        }
      }
    }
 }