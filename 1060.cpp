#include <iostream>

int main() {
  float A, B, C, D, E, F, Resultado = 0;
  scanf("%f %f %f %f %f %f", &A, &B, &C, &D, &E, &F);

  if (A > 0)
  {
    Resultado = Resultado + 1;
  }

  if (B > 0)
  {
    Resultado = Resultado + 1;
  }

  if (C > 0)
  {
    Resultado = Resultado + 1;
  }

  if (D > 0)
  {
    Resultado = Resultado + 1;
  }

  if (E > 0)
  {
    Resultado = Resultado + 1;
  }

  if (F > 0)
  {
    Resultado = Resultado + 1;
  }
  printf("%.0f valores positivos\n", Resultado);
}