#include <iostream>

int main() {
  int A, B, C;

  scanf("%d %d", &A, &B);

  if (B < A)
  {
    if (A % B == 0)
    {
        printf("Sao Multiplos\n");      
    }
    else
    {
    printf("Nao sao Multiplos\n");
    }
  }
else
{
  if (B % A == 0)
  {
      printf("Sao Multiplos\n");     
  }

  else
  {
    printf("Nao sao Multiplos\n");
  }
}
}