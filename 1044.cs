using System;

class Program {
  public static void Main (string[] args){
    string []valo = Console.ReadLine().Split(' ');

    int A = Convert.ToInt32(valo[0]);
    int B = Convert.ToInt32(valo[1]);

    if(B > A)
    {
    if(B % A == 0)
      Console.WriteLine("Sao Multiplos");
    else
      Console.WriteLine("Nao sao Multiplos");
    }

    else if(A > B)
    {
    if(A % B == 0)
      Console.WriteLine("Sao Multiplos");
    else
      Console.WriteLine("Nao sao Multiplos");
    }
      
  }
}