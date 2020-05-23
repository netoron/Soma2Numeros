using System;

namespace Soma2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            string primeiro;
            string segundo;
            double soma1;
            double soma2;

            double item;
            
            Console.WriteLine("Soma de dois numeros");
            Console.Write("Digite o Primeiro número:");
            
            primeiro = Console.ReadLine();
            
            Console.Write("Digite o Segundo número:");
            segundo = Console.ReadLine();

            soma1 = Convert.ToDouble(primeiro);
            soma2 = Convert.ToDouble(segundo);

            item = soma1 * soma2;
            Console.WriteLine($"A Soma de {primeiro} e de {segundo} é {item}");


        }
    }
}
