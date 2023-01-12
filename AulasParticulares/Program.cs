using AulasParticulares.Models;

string nome = ProcessoDeCadastramento.CadastrarNome();
int idade = ProcessoDeCadastramento.CadastrarIdade();
decimal altura = ProcessoDeCadastramento.CadastrarAltura();

ProcessoDeCadastramento.ApresentarDados(nome, idade, altura);