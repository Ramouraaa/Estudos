#include <iostream>

int main() {
  int I = 1, J = 60;
  for(int i = 1; i <= 13; i++)
  {
    printf("I=%d J=%d\n", I, J);
    I += 3;
    J -= 5;
  }
}