﻿using System;

class Program
{
    public static void Main (string[] args)
    {
        Console.WriteLine("Digite sua nota do 1° Bimestre: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite sua nota do 2° Bimestre: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite sua nota do 3° Bimestre: ");
        double nota3 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite sua nota do 4° Bimestre: ");
        double nota4 = double.Parse(Console.ReadLine());
        

        double media = (nota1 + nota2 + nota3 + nota4) /4.0;

        Console.WriteLine($"A média do aluno é: {media}");
    }
}
