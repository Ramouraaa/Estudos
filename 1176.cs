using System;

class MainClass {
  public static void Main (string[] args) {
    ulong Count = Convert.ToUInt64(Console.ReadLine());
    ulong x;
    Count++;
    ulong[] V= new ulong[Count];

    for(ulong i = 1; i < Count; i++)
    { 
      x = Convert.ToUInt64(Console.ReadLine());
      V[i] = x; 
    }
    ulong t = 1;
    ulong A = 0;      
    ulong B = 1;      
    ulong C = 0;
    for(ulong i = 1;i <= 61; i++)
    {
      if(V[t] == 0)
      {
        i = 0;
        Console.WriteLine("Ae desgraçaaaa");
      }
      if(i == 1)
      {
        C = 1;
      }
      if(i > 1)
      {
        C = A + B;
        A = B;
        B = C; 
      }
      if (V[t] == i)
      {       
        Console.WriteLine("Fib(" + V[t] + ") = " + C);
        A = 0;      
        B = 1;
        i = 0;      
        C = 0; 
        t++;
        if (t == Count)
        {
          break;
        }
      }
    }
 }
}

  
