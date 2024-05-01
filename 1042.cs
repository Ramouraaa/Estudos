using System;

class Program {
  public static void Main (string[] args) {
    int med = 0;
    string []numb = Console.ReadLine().Split(' ');

    int []X = new int [3];
    X[0] = Convert.ToInt32(numb[0]);
    X[1] = Convert.ToInt32(numb[1]);
    X[2] = Convert.ToInt32(numb[2]);
        
    int min = Math.Min(X[0], Math.Min(X[1], X[2]));
    int max = Math.Max(X[0], Math.Max(X[1], X[2]));

    for(int i = 0; i <= 2; i++)
    {
        if(X[i] != max && X[i] != min || X[0] == X[1] && X[1] > X[2] && X[0] > X[2] || X[0] == X[2] && X[0] > X[1] && X[2] > X[1] || X[1] == X[2] && X[1] > X[0] && X[2] > 0)
           med = X[i];
    }     
      
    Console.WriteLine(min);
    Console.WriteLine(med);
    Console.WriteLine(max + "\n");

    Console.WriteLine(X[0]);
    Console.WriteLine(X[1]);
    Console.WriteLine(X[2]);
    
  }
}
