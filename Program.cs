using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atividade - Escreva um algoritmo que receba o número inteiro e exiba sua tabuada até 10
            Console.WriteLine("Tabuada"); 
            Console.WriteLine("Digite um número:");
            int numero = int.Parse(Console.ReadLine());
            
            int formula ,contador;
            for (contador = 1;  contador <=10; ++contador)
            
            {
                formula = numero * contador;
                Console.WriteLine(numero + "x" + contador + " = " + formula);
            }

                
        }
    }
}
