using System;

class Program {
  public static void Main (string[] args) {
    //Erradoooo
    Console.WriteLine("A");
    int min;
    int hour = 0;
    string []valo = Console.ReadLine().Split(' ');

    int HI = Convert.ToInt32(valo[0]);
    int MI = Convert.ToInt32(valo[1]);
    int HF = Convert.ToInt32(valo[2]);
    int MF = Convert.ToInt32(valo[3]);

    if(MI > MF)
       min = ((MI - MF) - 60) * -1;
    else
       min = MF - MI;

    if(HI > HF || HI == HF)
      hour = ((HI - HF) - 24) * -1;
    else
    {
      hour = HF - HI;
      if(MI > MF && HF > HI)
        hour--;
    }

    Console.WriteLine("O JOGO DUROU " + hour + " HORA(S) E " + min + " MINUTO(S)");
      

      
  }
}