#include <stdlib.h>
#include <stdio.h>

int main() {

    double temp;
    scanf("%lf", &temp);

    if (temp < 0)
    {
    printf("Fora de intervalo\n");
    }

    else if (temp <= 25)
    {
     printf("Intervalo [0,25]\n");
    }

    else if (temp <= 50)
    {
      printf("Intervalo (25,50]\n");
    }

    else if (temp <= 75)
    {
      printf("Intervalo (50,75]\n");
    }

    else if (temp <= 100)
    {
      printf("Intervalo (75,100]\n");
    }
    
    else if (temp > 100)
    {
      printf("Fora de intervalo\n");
    }

     return 0;
}