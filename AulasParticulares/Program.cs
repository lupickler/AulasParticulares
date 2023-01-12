string nome = CadastrarNome();
int idade = CadastrarIdade();
decimal altura = CadastrarAltura();

ApresentarDados();

decimal CadastrarAltura()
{
    Console.WriteLine("Qual a sua altura?");
    decimal altura = Convert.ToDecimal(Console.ReadLine());
    PularDuasLinhas();

    return altura;
}

string CadastrarNome()
{
    Console.WriteLine("Qual o seu nome?");
    string nome = Console.ReadLine();
    PularDuasLinhas();

    return nome;
}

int CadastrarIdade()
{
    Console.WriteLine("Qual a sua idade?");
    int idade = Convert.ToInt32(Console.ReadLine());
    PularDuasLinhas();

    return idade;
}

void ApresentarDados()
{
    Console.WriteLine($"nome: {nome} \nidade: {idade} \naltura: {altura}");
}

void PularDuasLinhas()
{
    Console.WriteLine("");
    Console.WriteLine("");
}