using System;

class Program
{
    public static void Main (string[] args)
    {
        Console.WriteLine("Digite a base do triangulo: ");
        double baseTriangulo = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a altura do triangulo: ");
        double alturaTriangulo = double.Parse(Console.ReadLine());
        

        double valortotal = (baseTriangulo * alturaTriangulo) /2;

        bool analista = (valortotal > 20);

        Console.WriteLine($"A área do triângulo é maior que 20? {analista}");

    }
}
    
    
