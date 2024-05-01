using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("A");
    string []numb = Console.ReadLine().Split(' ');

    float A = Convert.ToSingle(numb[0]);
    float B = Convert.ToSingle(numb[1]);
    float C = Convert.ToSingle(numb[2]);
    

    if (A+B > C && C > A-B)
    {
      float peri = A + B + C;
      Console.WriteLine("Perimetro = " + peri.ToString("F1"));
    }

    else
    {
      float area = ((A + B) * C) / 2;
      Console.WriteLine("Area = " + area.ToString("F1"));
    }
    
  }
}