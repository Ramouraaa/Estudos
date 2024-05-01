using System;
using System.Collections;

class MainClass {
  public static void Main (string[] args) {
    //Entrada Dupla
    string[] dentrada = new string[2];
    float[] cardapio = new float[] {0, 4, 4.5f, 5, 2, 1.5f};

    //Difinir valores em 1 linha (Não possivel usar split com int, float, double)
    dentrada = Console.ReadLine().Split(' ');
    int code = int.Parse(dentrada[0]);
    float count = Convert.ToSingle(dentrada[1]);

    //Resultado
    float result = cardapio[code] * count;
    Console.WriteLine("Total: R$ " + result.ToString("F2"));    
  }
}