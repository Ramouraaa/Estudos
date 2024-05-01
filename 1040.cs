using System;

class Program {
  public static void Main (string[] args) {
    string []nota = Console.ReadLine().Split(" ");

    float N1 = Convert.ToSingle(nota[0]);
    float N2 = Convert.ToSingle(nota[1]);
    float N3 = Convert.ToSingle(nota[2]);
    float N4 = Convert.ToSingle(nota[3]);
     
    //Calcular média
    float media = (N1 + N2 + N3 + N4) / 4;
    Console.WriteLine("Media: {0}", media.ToString("F1"));

    if(media >= 7)
       Console.WriteLine("Aluno aprovado.");
    else if(media < 5)
       Console.WriteLine("Aluno reprovado.");
    else
    {
       Console.WriteLine("Aluno em exame.");
       float N5 = Convert.ToSingle(Console.ReadLine());

       float final = (media + N5) / 2;
       
       if(final >= 5)
          Console.WriteLine("Aluno aprovado.");
       else
          Console.WriteLine("Aluno reprovado.");

       Console.WriteLine("Media final: {0}", final.ToString("F1"));
    }
    
  }
}