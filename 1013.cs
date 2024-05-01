using System;

class MainClass {
  public static void Main (string[] args) {
    string []V = Console.ReadLine().Split(' ');

    int X = Convert.ToInt32(V[0]);
    int Y = Convert.ToInt32(V[1]);
    int Z = Convert.ToInt32(V[2]);

    if(X >= Y && X >= Z)
      Console.WriteLine(X + " eh o maior");

    else if(Y >= X && Y >= Z)
      Console.WriteLine(Y + " eh o maior");

    else
      Console.WriteLine(Z + " eh o maior");
  }
}