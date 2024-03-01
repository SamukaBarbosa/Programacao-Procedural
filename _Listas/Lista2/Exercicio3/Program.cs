using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o nome da crianca:");
        string nome = Console.ReadLine();

        if (nome == "Filomena")
        {
        
            Console.WriteLine("Rotina de Filomena: ");
            Console.WriteLine("1. Escola das 07h as 12h ");
            Console.WriteLine("2. Almoco das 12h as 13h ");
            Console.WriteLine("3. Futebol das 14h as 16h ");
            Console.WriteLine("4. Dever de casa das 16h as 18h ");
        }
        else if (nome == "Joselito")    
        {
        
            Console.WriteLine("Rotina de Joselito: ");
            Console.WriteLine("1. Escola das 07h as 12:30h ");
            Console.WriteLine("2. Almoco das 13h as 14h ");
            Console.WriteLine("3. Natacao das 14h as 16h ");
            Console.WriteLine("4. Reforco escolar das 16h as 19h ");
        }
        else
        {
            Console.WriteLine("Criança nao indentificada!");
        }
    }
}
