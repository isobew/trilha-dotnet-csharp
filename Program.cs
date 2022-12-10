using codes.Models;
Pessoa p = new Pessoa();

p.Nome = "Isabella";
p.Idade = 22;
p.Apresentar();

// tipos de dados
string apresentacao = "Olá, seja bem vindo";
int quantidade = 1;
quantidade = 10;
double altura = 1.80;
decimal preco = 1.80M;
bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável preco: " + preco);
Console.WriteLine("Valor da variável condicao: " + condicao);

//tipo DateTime

//data atual da máquina que está executando
DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

//soma de 5 dias
dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
Console.WriteLine(dataAtual.ToString("yyyy/MM/dd"));
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));
