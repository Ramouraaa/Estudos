#include <iostream>

int main() {
  int N, P = 1;
  scanf("%d", &N);
  for(int i = 1; i <= N; i++)
  {
    printf("%d ", P);
    P = P + 1;
    printf("%d ", P);
    P = P + 1;
    printf("%d PUM\n", P); 
    P = P + 2;   
  }
}