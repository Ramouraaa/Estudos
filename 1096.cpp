#include <iostream>

int main() {
  int I = 1;
  for(int i = 1; i <= 5; i++)
  {
      printf("I=%d J=7\n", I);
      printf("I=%d J=6\n", I);
      printf("I=%d J=5\n", I);
      I = I + 2;
  }
 return 0;
}