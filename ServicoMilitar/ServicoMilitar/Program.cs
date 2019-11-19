using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicoMilitar
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome, sexo;
            int idade;
            double altura;

            Console.Write("Informe o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Informe sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Informe sua altura: ");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Informe seu sexo (M/F): ");
            sexo = Console.ReadLine();
            Console.WriteLine();

            if (idade >= 18 && altura >= 1.80)
            {
                Console.WriteLine("Você, " + nome + " está apto(a) para o Alistamento Militar!");
            }

            else 
            {
                Console.WriteLine("Você, " + nome + " não está apto(a) para o Alistamento Militar!");
            }

            Console.ReadLine();
        }
    }
}
