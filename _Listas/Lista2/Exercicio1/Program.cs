using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite seu nome de usuario: ");
        string nomeDeUsuario = Console.ReadLine();

        Console.WriteLine("Digite sua senha: ");
        string senha = Console.ReadLine();


        if (nomeDeUsuario == "admin" && senha == "123senha")
        {
            Console.WriteLine("Login realizado com sucesso! ");
        }
        else 
        {
            Console.WriteLine("Credenciais invalidas") ;
        }
    }
}
