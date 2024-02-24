using System;

class Program 
{
  public static void Main (string[] args) 
  {

   Console.WriteLine("Digite o valor em centavos que deseja converter: ");
    int valoremCentavos = int.Parse(Console.ReadLine());
    

    int reais = valoremCentavos /100;
    int centavos = valoremCentavos %100 ;


    Console.WriteLine("O total em dinheiro eh: " + reais + " reais e " + centavos + " centavos ");
    


  }
}
