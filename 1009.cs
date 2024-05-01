using System;

class MainClass {
  public static void Main (string[] args) {
    string NOME = Console.ReadLine();
    double Salary = Convert.ToDouble(Console.ReadLine());
    double Vendas = Convert.ToDouble(Console.ReadLine());

    Salary = (Vendas * 0.15) + Salary;

    Console.WriteLine("TOTAL = R$ " + Salary.ToString("F2"));
  }
}