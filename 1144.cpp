#include <iostream>

int main() {
  int N, A = 1, B = 1, S, S3, T = 1;
  
  scanf("%d", &N);

  for(int i = 1; i <= N; i++)
  {
    printf("%d %d %d\n", i, A, B);
    
    A = A + 1;
    B = B + 1;
    
    printf("%d %d %d\n", i, A, B);
    
    S = S + 2;
    A = A + S;
    T = T + 1;
    S3 = A * T;
    B = S3;
  }
  return 0;
  }

