using System;

class MainClass {
  public static void Main (string[] args) {
    float count = 100;
    int j = 0;
    //Definir dinheiro
    float money = Convert.ToSingle(Console.ReadLine());
    //Guardar o dinheiro
    float[] dinheiro = new float[12];

    bool f = false;
    while(money >= 0.01)
    {
      if (money >= count)
      {
         dinheiro[j]++;
         money -= count;
      }
      else
      {
        j++;
        switch (j)
        {
          case 1:
            count = 50;
            break;
    
          case 2:
            count = 20;
            break;

          case 3:
            count = 10;
            break;

          case 4:
            count = 5;
            break;
            
          case 5:
            count = 2;
            break;
    
          case 6:
            count = 1;
            break;

          case 7:
            count = 0.5f;
            break;

          case 8:
            count = 0.25f;
            break;

          case 9:
            count = 0.1f;
            break;

          case 10:
            count = 0.05f;
            break;
        
          default:
            f = true;
            count = 0.01f;
            break;
        }
      }
    }
    if (f) dinheiro[11]++;

    //Escrever no console
    Console.WriteLine("NOTAS:\n" + dinheiro[0] + " nota(s) de R$ 100.00");
    Console.WriteLine(dinheiro[1] + " nota(s) de R$ 50.00");
    Console.WriteLine(dinheiro[2] + " nota(s) de R$ 20.00");
    Console.WriteLine(dinheiro[3] + " nota(s) de R$ 10.00");
    Console.WriteLine(dinheiro[4] + " nota(s) de R$ 5.00");
    Console.WriteLine(dinheiro[5] + " nota(s) de R$ 2.00");
    Console.WriteLine("MOEDAS:\n" + dinheiro[6] + " moeda(s) de R$ 1.00");
    Console.WriteLine(dinheiro[7] + " moeda(s) de R$ 0.50");
    Console.WriteLine(dinheiro[8] + " moeda(s) de R$ 0.25");
    Console.WriteLine(dinheiro[9] + " moeda(s) de R$ 0.10");
    Console.WriteLine(dinheiro[10] + " moeda(s) de R$ 0.05");
    Console.WriteLine(dinheiro[11] + " moeda(s) de R$ 0.01");
  }
}