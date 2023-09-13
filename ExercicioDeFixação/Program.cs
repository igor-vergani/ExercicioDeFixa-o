using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio de fixação

            Console.WriteLine("Entre com seu nome completo:");
            string nomeCompleto = Console.ReadLine();
            

            Console.WriteLine("Quantos quartos tem na sua casa:");
            int NumeroQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu ultimo nome, idade, e altura (mesma linha)");
            string[] vet = Console.ReadLine().Split();
            string lastName = vet[0];
            int idade = int.Parse(vet[1]);
            float altura = float.Parse(vet[2]);

            Console.WriteLine("Seu nome completo é: " + lastName + " sua idade é :" + idade + " quantidade de quartos na sua casa é de " + NumeroQuartos);
            
        }
    }
}