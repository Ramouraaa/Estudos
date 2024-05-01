using System;

class MainClass {
  public static void Main (string[] args) {

   string []X = Console.ReadLine().Split(' ');
   string []Y = Console.ReadLine().Split(' ');

   double x1 = Convert.ToDouble(X[0]);
   double y1 = Convert.ToDouble(X[1]);
   double x2 = Convert.ToDouble(Y[0]);
   double y2 = Convert.ToDouble(Y[1]);

   double part1 = (x2 * x2) - (2 * x2 * x1) + (x1 * x1);
   double part2 = (y1 * y1) - (2 * y1 * y2) + (y2 * y2);
   double part3 = (part1 + part2);
   double part4 = Math.Sqrt(part3);

   Console.WriteLine(part4.ToString("F4"));
  }
}