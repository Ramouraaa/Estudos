using System;

class MainClass {
  public static void Main (string[] args) {
    string []P1 = Console.ReadLine().Split(' ');
    string []P2 = Console.ReadLine().Split(' '); 

    double x1 = Convert.ToDouble(P1[1]);
    double x2 = Convert.ToDouble(P1[2]);
    double y1 = Convert.ToDouble(P2[1]);
    double y2 = Convert.ToDouble(P2[2]);

    double Result = (x1 * x2) + (y1 * y2);

    Console.WriteLine("VALOR A PAGAR: R$ " + Result.ToString("F2"));
  }
}