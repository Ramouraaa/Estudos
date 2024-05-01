using System;

class MainClass {
  public static void Main (string[] args) {
    //Entrada
    float intervalo = Convert.ToSingle(Console.ReadLine());
    
    //Condições
    if(intervalo > 100 || intervalo < 0)
      Console.WriteLine("Fora de intervalo");

    else if(intervalo >= 0 && intervalo <= 25)
      Console.WriteLine("Intervalo [0,25]");

    else if(intervalo > 25 && intervalo <= 50)
      Console.WriteLine("Intervalo (25,50]");

    else if(intervalo > 50 && intervalo <= 75)
      Console.WriteLine("Intervalo (50,75]");

    else if(intervalo > 75 && intervalo <= 100)
      Console.WriteLine("Intervalo (75,100]");  

  }
}