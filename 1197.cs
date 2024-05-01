using System;

class Program {
  public static void Main (string[] args) {
    string []vel = Console.ReadLine().Split(' ');

    int I = Convert.ToInt32(vel[0]);
    int C = Convert.ToInt32(vel[1]);

    Console.WriteLine((I * C) * 2);
  }
}