using AulasParticulares.Models;

string nome = ProcessoDeCadastramento.CadastrarNome();
int idade = ProcessoDeCadastramento.CadastrarIdade();
decimal altura = ProcessoDeCadastramento.CadastrarAltura();

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


