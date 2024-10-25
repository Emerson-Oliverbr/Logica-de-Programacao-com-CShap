using System;
using System.Globalization;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome;
            int quantidadeDeQuartos;
            double preco;            

            Console.WriteLine("Entre com seu nome completo: ");
            nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            quantidadeDeQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o preço do produto? ");
            preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Entre com seu ultimo nome, idade e altura (na mesma linha) ");
            string[] dadosCliente = Console.ReadLine().Split(' ');
            string ultimoNome = dadosCliente[0];
            int idade = int.Parse(dadosCliente[1]);
            double altura = double.Parse(dadosCliente[2],CultureInfo.InvariantCulture);
            

            Console.WriteLine("Dados do Cliente: ");
            Console.WriteLine(nome);
            Console.WriteLine(quantidadeDeQuartos);
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}