using System;

class MainClass {
  public static void Main (string[] args) {
    int Number = Convert.ToInt32(Console.ReadLine());
    int Salary = Convert.ToInt32(Console.ReadLine());
    double Aument = Convert.ToDouble(Console.ReadLine());

    double FSalary = Salary * Aument;

    Console.WriteLine("NUMBER = " + Number);
    Console.WriteLine("SALARY = U$ " + FSalary.ToString("F2"));
    
  }
}