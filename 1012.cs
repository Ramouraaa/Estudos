using System;

class MainClass {
  public static void Main (string[] args) {
    string []X = Console.ReadLine().Split(' ');

    double A = Convert.ToDouble(X[0]);
    double B = Convert.ToDouble(X[1]);
    double C = Convert.ToDouble(X[2]);

    double AreaT = (A * C) / 2;
    double AreaC = 3.14159 * (C * C);
    double AreaTra = ((A + B) * C) / 2;
    double AreaQ = B * B;
    double AreaR = A * B;

    Console.WriteLine("TRIANGULO: " + AreaT.ToString("F3"));
    Console.WriteLine("CIRCULO: " + AreaC.ToString("F3"));
    Console.WriteLine("TRAPEZIO: " + AreaTra.ToString("F3"));
    Console.WriteLine("QUADRADO: " + AreaQ.ToString("F3"));
    Console.WriteLine("RETANGULO: " + AreaR.ToString("F3"));
  }
}