using System;

class MainClass {
  public static void Main (string[] args) {
    double R = Convert.ToDouble(Console.ReadLine());

    R *= R * R;

    double VOLUME = (4 / 3.0) * 3.14159 * R;

    Console.WriteLine("VOLUME = " + VOLUME.ToString("F3"));
  }
}