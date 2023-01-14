namespace AulasParticulares.Models.Services
{
    public static class ProcessoCadastroCliente
    {
        public static void CadastrarCliente()
        {
            Cliente cliente = new Cliente()
            {
                Nome = CadastrarNome(),
                Idade = CadastrarIdade(),
                Altura = CadastrarAltura(),
                Endereco = CadastrarEndereco(),
            };

            ApresentarDados(cliente);
        }

        private static string CadastrarEndereco() 
        {
            Console.WriteLine("Seu endereco?");
            string endereco = Convert.ToString(Console.ReadLine());
            PularDuasLinhas();
            return endereco;
        }

        private static decimal CadastrarAltura()
        {
            Console.WriteLine("Qual a sua altura?");
            decimal altura = Convert.ToDecimal(Console.ReadLine());
            PularDuasLinhas();
            return altura;
        }

        private static string CadastrarNome()
        {
            Console.WriteLine("Qual o seu nome?");
            string nome = Console.ReadLine();
            PularDuasLinhas();
            return nome;
        }

        private static int CadastrarIdade()
        {
            Console.WriteLine("Qual a sua idade?");
            int idade = Convert.ToInt32(Console.ReadLine());
            PularDuasLinhas();
            return idade;
        }

        private static void ApresentarDados(Cliente cliente)
        {
            Console.WriteLine($"nome: {cliente.Nome} \nidade: {cliente.Idade} \naltura: {cliente.Altura} \nendereco: {cliente.Endereco}");
        }

        private static void PularDuasLinhas()
        {
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
