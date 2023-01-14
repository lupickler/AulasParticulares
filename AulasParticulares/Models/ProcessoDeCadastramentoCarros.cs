namespace AulasParticulares.Models.Services
{
    public static class ProcessoDeCadastramentoCarros
    {
        public static void CadastrarCarros()
        {
            Carros carros = new Carros()
            {
                Marca = CadastrarMarca(),
                Modelo = CadastrarModelo(),
            };

            ApresentarCarros(carros);

        }
        private static string CadastrarMarca()
        {
            Console.WriteLine("Qual a marca do carro?");
            string marca = Console.ReadLine();
            PularDuasLinhas();
            return marca;
        }

        private static string CadastrarModelo()
        {
            Console.WriteLine("Qual o modelo do carro?");
            string modelo = Console.ReadLine();
            PularDuasLinhas();
            return modelo;
        }

        private static void ApresentarCarros(Carros carros)
        {
            Console.WriteLine($"marca: {carros.Marca} \nmodelo: {carros.Modelo}");
        }

        private static void PularDuasLinhas()
        {
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
