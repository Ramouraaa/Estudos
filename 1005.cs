using System;

class MainClass {
  public static void Main (string[] args) {
    double X = Convert.ToDouble(Console.ReadLine());
    double Y = Convert.ToDouble(Console.ReadLine());

    double Z = (X * 3.5) + (Y * 7.5);
    Z = Z / 11;

    Console.WriteLine("MEDIA = " + Z.ToString("F5"));
  }
}