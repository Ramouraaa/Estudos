#include <iostream>

int main() {
  int N, D, I;
  scanf("%d", &N);

 for (int i = 2; i <= 100; i++)
 {
   scanf("%d", &D);
   if (D > N)
   {
      N = D;
      I = i;
   }
   if (i == 100)
    {
      printf("%d\n%d\n", N, I);
    }

   } 
}