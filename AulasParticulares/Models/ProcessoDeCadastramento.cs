using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasParticulares.Models
{
    public static class ProcessoDeCadastramento
    {
        public static decimal CadastrarAltura()
        {
            Console.WriteLine("Qual a sua altura?");
            decimal altura = Convert.ToDecimal(Console.ReadLine());
            PularDuasLinhas();
            return altura;
        }

        public static string CadastrarNome()
        {
            Console.WriteLine("Qual o seu nome?");
            string nome = Console.ReadLine();
            PularDuasLinhas();

            return nome;
        }

        public static int CadastrarIdade()
        {
            Console.WriteLine("Qual a sua idade?");
            int idade = Convert.ToInt32(Console.ReadLine());
            PularDuasLinhas();

            return idade;
        }

        public static void ApresentarDados(string nome, int idade, decimal altura)
        {
            Console.WriteLine($"nome: {nome} \nidade: {idade} \naltura: {altura}");
        }

        private static void PularDuasLinhas()
        {
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
