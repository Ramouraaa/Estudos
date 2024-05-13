#include <iostream>

int main() {
  int X;
  scanf("%d", &X);

   if(X % 2 == 0)
  {
   X = X + 1;
   if (X)
   {
     for(int i = 0; i <= 5; i++)
     {
       printf("%d\n", X);
       X = X + 2;
     }
   }
  }

else
{
  for(int i = 0; i <= 5; i++)
  {
    printf("%d\n", X);
    X = X + 2;
  }
}
}