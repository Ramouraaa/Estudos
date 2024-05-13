#include <iostream>

int main() {
  float A, B = 0, Plus = 0;
   
     for(int i = 0; i <= 5; i++)
     {
       scanf("%f", &A);
       if(A >= 0)
       {
       B = B + A;
       Plus++;
       }
     }

     printf("%.0f valores positivos\n%.1f\n", Plus, B / Plus);     
}