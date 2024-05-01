using System;

class MainClass {
  public static void Main (string[] args) {
    int tempo = Convert.ToInt32(Console.ReadLine());
    int year = 0;
    int mouth = 0;
    int day = 0;

    while (tempo > 0)
    {
      if(tempo >= 365)
      {
         year++;
         tempo -= 365;
      }

      else if(tempo >= 30)
      {
        mouth++;
        tempo -= 30;
      }

      else if(tempo >= 1)
      {
        day++;
        tempo -= 1;
      }
    }

    Console.WriteLine(year + " ano(s)");
    Console.WriteLine(mouth + " mes(es)");
    Console.WriteLine(day + " dia(s)");
  }
}