using System;

class Program {
  public static void Main (string[] args) {
    string []XY = Console.ReadLine().Split(' ');

    double X = Convert.ToDouble(XY[0]);
    double Y = Convert.ToDouble(XY[1]);

    if(X > 0 && Y > 0)
      Console.WriteLine("Q1");

    if(X < 0 && Y > 0)
      Console.WriteLine("Q2");
    
    if(X < 0 && Y < 0)
      Console.WriteLine("Q3");

    if(X > 0 && Y < 0)
      Console.WriteLine("Q4");

    if(Y == 0 && X > 0 || Y == 0 && 0 > X)
      Console.WriteLine("Eixo X");

    if(X == 0 && Y > 0 || X == 0 && 0 > Y)
      Console.WriteLine("Eixo Y");
    
    if(X == 0 && Y == 0)
      Console.WriteLine("Origem");
    
  }
}