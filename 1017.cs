using System;

class MainClass {
  public static void Main (string[] args) {
    int h = Convert.ToInt32(Console.ReadLine());
    int km = Convert.ToInt32(Console.ReadLine());

    float L = km * h;
    L = L / 12;

    Console.WriteLine(L.ToString("F3"));

  }
}