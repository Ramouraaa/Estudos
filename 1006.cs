using System;

class MainClass {
  public static void Main (string[] args) {
    double A = Convert.ToDouble(Console.ReadLine());
    double B = Convert.ToDouble(Console.ReadLine());
    double C = Convert.ToDouble(Console.ReadLine());

    double MEDIA = (A * 2) + (B * 3) + (C * 5);
    MEDIA = MEDIA / 10;

    Console.WriteLine("MEDIA = " + MEDIA.ToString("F1"));
  }
}