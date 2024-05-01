using System;

class Program {
  public static void Main (string[] args) {
    int result;
    string []valo = Console.ReadLine().Split(' ');

    int TI = Convert.ToInt32(valo[0]);
    int TF = Convert.ToInt32(valo[1]);

    if(TI >= TF)
    {
      result = (24 - TI) + TF;
      Console.WriteLine("O JOGO DUROU " + result + " HORA(S)");     
    }

    if(TI < TF)
    {
    result = TF - TI;
    Console.WriteLine("O JOGO DUROU " + result + " HORA(S)");       
    }
  }
}