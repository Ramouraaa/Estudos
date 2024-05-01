using System;

class Program {
  public static void Main (string[] args) {
    double med = 0;
    bool noT = false;
    string []numb = Console.ReadLine().Split(' ');
    
    double []X = new double [3];
    X[0] = Convert.ToDouble(numb[0]);
    X[1] = Convert.ToDouble(numb[1]);
    X[2] = Convert.ToDouble(numb[2]);
        
    double min = Math.Min(X[0], Math.Min(X[1], X[2]));
    double max = Math.Max(X[0], Math.Max(X[1], X[2]));

    for(int i = 0; i <= 2; i++)
        if(X[i] != max && X[i] != min)
           med = X[i];

    if(X[0] == X[1] || X[0] == X[2])
       med = X[0];
    else if(X[1] == X[2])
      med = X[1];
      

    double A = max;
    double B = med;
    double C = min;
    
    double A2 = A * A;
    double B2 = B * B;
    double C2 = C * C;
    
    if(A >= B+C)
    {
      Console.WriteLine("NAO FORMA TRIANGULO");
      noT = true;
    }

    else if(A2 == B2 + C2)
      Console.WriteLine("TRIANGULO RETANGULO");

    else if(A2 > B2 + C2)
      Console.WriteLine("TRIANGULO OBTUSANGULO");

    else if(A2 < B2 + C2)
      Console.WriteLine("TRIANGULO ACUTANGULO");

    if(A == B && B == C && C == A && !noT)
    {
      Console.WriteLine("TRIANGULO EQUILATERO");
      noT = true;
    }

    if(A == B && !noT || B == C && !noT || C == A && !noT)
      Console.WriteLine("TRIANGULO ISOSCELES");
   
  }
}