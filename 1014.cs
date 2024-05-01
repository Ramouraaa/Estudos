using System;

class MainClass {
  public static void Main (string[] args) {
    int X = Convert.ToInt32(Console.ReadLine());
    double Y = Convert.ToDouble(Console.ReadLine());

    double Z = X / Y;

    Console.WriteLine(Z.ToString("F3") + " km/l");
  }
}