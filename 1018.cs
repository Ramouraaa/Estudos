using System;

class MainClass {
  public static void Main (string[] args) {
    int r = Convert.ToInt32(Console.ReadLine());
    int subs = r;
    int infinity = 1;
    int cen = 0;
    int cin = 0;
    int vin = 0;
    int dez = 0;
    int cinco = 0;
    int dois = 0;
    int um = 0;

    for(int i = 0; i < infinity; i++)
    {
      if(r >= 100)
      {
         cen++;
         r -= 100;
      }
      else if(r >= 50)
      {
        cin++;
        r -= 50;
      }
      else if(r >= 20)
      {
        vin++;
        r -= 20;
      }
      else if(r >= 10)
      {
        dez++;
        r -= 10;
      }
      else if(r >= 5)
      {
        cinco++;
        r -= 5;
      }
      else if(r >= 2)
      {
        dois++;
        r -= 2;
      }
      else if(r >= 1)
      {
        um++;
        r -= 1;
      }
      else
      {
         break;
      }
      infinity++;
    }
    Console.WriteLine(subs);
    Console.WriteLine(cen + " nota(s) de R$ 100,00");
    Console.WriteLine(cin + " nota(s) de R$ 50,00");
    Console.WriteLine(vin + " nota(s) de R$ 20,00");
    Console.WriteLine(dez + " nota(s) de R$ 10,00");
    Console.WriteLine(cinco + " nota(s) de R$ 5,00");
    Console.WriteLine(dois + " nota(s) de R$ 2,00");
    Console.WriteLine(um + " nota(s) de R$ 1,00");
  }
}