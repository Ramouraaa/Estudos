using System;

class MainClass {
  public static void Main (string[] args) {
    int time = Convert.ToInt32(Console.ReadLine());
    int second = 0;
    int minute = 0;
    int hour = 0;

    while(time > 0)
    {
        //Horas
        if(time >= 3600)
        {
          hour++;
          time -= 3600;
        }

        //Minutos
        else if(time >= 60)
        {
          minute++;
          time -= 60;
        }

        //Segundos
        else if(time >= 1)
        {
          second++;
          time -= 1;
        }
    }
    Console.WriteLine(hour + ":" + minute + ":" + second);

  }
}