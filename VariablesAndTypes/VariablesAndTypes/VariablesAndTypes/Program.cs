//Exercicio 1
//Dado o ano de nascimento do usuário, calcule a idade dele em anos

using System.Runtime.Intrinsics.X86;
using System.Globalization;

Console.WriteLine("Insira seu ano de nascimento: ");
string anoNascimento = Console.ReadLine()!;
int idadeUsuario = 2026 - int.Parse(anoNascimento);
Console.WriteLine($"Você tem: {idadeUsuario} anos");

//Exercicio 2
//Crie um programa que:
//Declare uma variável para armazenar o valor recebido da doação.
//Declare uma variável para indicar se a doação foi anônima (true para anônima, false para não anônima).
//Declare uma variável para indicar o tipo de conta onde o valor foi depositado:
//Use P para conta poupança.
//Use C para conta corrente

double valorDoacao = 500.99;
bool anonima = true;
char Conta = 'P';
string tipoDoacao;
string tipoConta;
if (anonima == true)
{
    tipoDoacao = "anonima";
}
else
{
    tipoDoacao = "identificada";
}

if(Conta == 'P')
{
    tipoConta = "Poupança";
}
else
{
    tipoConta = "Corrente";
}
Console.WriteLine($"Uma doação {tipoDoacao} de R${valorDoacao} na conta {tipoConta}\n");

//Exercicio 3
//Crie um programa que converta milhas em quilometros usando a formula 1 milha = 1.60934 quilometros.
Console.WriteLine("Quantas milhas tem o trajeto?");
float milhas = float.Parse(Console.ReadLine()!);
float quilometros = milhas * 1.60934f;
Console.WriteLine($"Seu trajeto de {milhas} milhas equivale a {quilometros} quilometros.\n");

//Exercicio 4
//Crie um programa que:
//Declare uma variável com um valor inteiro representando o total de minutos.
//Calcule quantas horas completas existem nesse valor e quantos minutos restam.
//Exiba o resultado no formato X horas e Y minutos.
Console.WriteLine("Quantos minutos foram gastos na atividade?");
int minutosGastos = int.Parse(Console.ReadLine()!);
int horas = minutosGastos / 60;
int minutos = minutosGastos % 60;
Console.WriteLine($"Foram gastas {horas} horas e {minutos} minutos");

//Exercicio 5
//Crie um programa que:
//Declare duas variáveis para a largura e comprimento, respectivamente
//Aplique a formula mencionada para calcular a area do terreno
//Exiba o resultado do calculo
Console.WriteLine("Entre com a largura do terreno em metros: ");
double largura = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
Console.WriteLine("Entre com o comprimento do terreno em metros: ");
double comprimento = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
double area = largura * comprimento;
Console.WriteLine($"A area do terreno que tem {largura} m de largura e {comprimento} m de comprimento é de {area} m²");


