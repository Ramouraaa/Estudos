using System; 

class URI {

    static void Main(string[] args) { 

    double n = 3.14159;
    double raio = Convert.ToDouble(Console.ReadLine());
    
    raio *= raio;
    double area = n * raio;
    
    Console.WriteLine("A=" + area.ToString("F4"));

    }

}