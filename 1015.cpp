#include <iostream>
#include <math.h>

int main() {
  float x1, x2, y1, y2, part1, part2, part3, part4;

  scanf("%f %f %f %f", &x1, &y1, &x2, &y2);

  part1 = (x2 * x2) - (2 * x2 * x1) + (x1 * x1);
  part2 = (y1 * y1) - (2 * y1 * y2) + (y2 * y2);
  part3 = (part1 + part2);
  part4 = sqrt(part3);

  printf("%.4f\n", part4);

  return 0;
}