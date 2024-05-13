#include <iostream>

int main() {
  int N;
  int N2 = 0;
  int N3 = 0;
  int N4 = 0;
  std::cin >> N;
  for(int i = 0; i < N; i++)
  {
      N2++;
      if(N2 >= 60)
      {
         N3++;
         N2 = 0;
         if(N3 >= 60)
         {
           N4++;
           N3 = 0;
         }
      }
  }
  std::cout << N4 << ":" << N3 << ":" << N2 << "\n"; 
}