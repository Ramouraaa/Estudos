#include <iostream>

int main() {
  
int X, Y, B = 0;

scanf("%d %d", &X, &Y);

if (X > Y)
{
  int bag = X;
  X = Y;
  Y = bag;
}

if (Y % 2 == 0)
{
  Y--;

}

else
{
  Y -= 2;
}

if (X % 2 == 0)
{
  X = X + 1;
}

else 
{
  X = X + 2;
}

for(int i = Y; i < X; i += 2)
{
 B += i;

}
 printf("%d\n", Y);
return 0;
}