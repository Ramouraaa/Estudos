using System;

class MainClass {
  public static void Main (string[] args) {
    double delta, R1, R2;
    string[] X = new string[2];
    X = Console.ReadLine().Split(' ');
    double A = Convert.ToDouble(X[0]);
    double B = Convert.ToDouble(X[1]);
    double C = Convert.ToDouble(X[2]);

    delta = (B * B) - (4 * A * C);
    if(delta >= 0 && A != 0)
    { 
    R1 = (-B + Math.Sqrt(delta)) / (2 * A);
    R2 = (-B - Math.Sqrt(delta)) / (2 * A);
    
    Console.WriteLine("R1 = " + R1.ToString("F5"));
    Console.WriteLine("R2 = " + R2.ToString("F5"));
    }
    else Console.WriteLine("Impossivel calcular");
  }
}

/*            double A, B, C, del, x1, x2;
            string[] value = Console.ReadLine().Split(' ');

            A = Convert.ToDouble(value[0]);
            B = Convert.ToDouble(value[1]);
            C = Convert.ToDouble(value[2]);

            del = Math.Pow(B, 2) - (4 * A * C);

            if (del > 0 & A != 0)
            {

                x1 = (-B + Math.Sqrt(del)) / (2 * A);
                x2 = (-B - Math.Sqrt(del)) / (2 * A);

                Console.WriteLine("R1 = " + x1.ToString("F5"));
                Console.WriteLine("R2 = " + x2.ToString("F5"));
            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }*/