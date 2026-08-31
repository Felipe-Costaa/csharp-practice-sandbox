//Crie um programa que:

//Receba um valor representando o saldo.
//Verifique se esse valor é positivo, negativo ou zero.
//Exiba uma mensagem indicando a situação do saldo.
Console.WriteLine("Entre com o saldo da conta: ");
float saldo = float.Parse(Console.ReadLine()!);
if (saldo < 0)
{
    Console.WriteLine($"Você está com saldo negativo! Saldo: R${saldo}");
}else if(saldo == 0)
{
    Console.WriteLine("Você está com saldo zerado!");
}else
{
    Console.WriteLine($"Você está com saldo positivo! Seu saldo é de R$ {saldo}\n");
}

//Crie um programa que:
//Receba um código numérico (1 ou 2) representando o tipo de produto.
//Classifique o produto como:
//“Perecível” para código 1.
//“Não perecível” para código 2.
//Alerte o usuário caso o código seja inválido.

Console.WriteLine("Digite o codigo do produto (1 ou 2)");
char tipoProduto = Console.ReadKey().KeyChar;
if (tipoProduto == '1')
{
    Console.WriteLine("\nProduto Perecível");
}
else
{
    Console.WriteLine("\nProduto não perecivel");
}

Console.WriteLine("Entre com a nota final do aluno: ");
float notaFinal = float.Parse(Console.ReadLine()!);
if(notaFinal >= 9)
{
    Console.WriteLine("A classificação do aluno é A\n");
}else if (notaFinal >= 7 & notaFinal < 9)
{
    Console.WriteLine("A classificação do aluno é B\n");
}
else if (notaFinal >= 5 & notaFinal < 7)
{
    Console.WriteLine("A classificação do aluno é C\n");
}
else if (notaFinal < 5)
{
    Console.WriteLine("A classificação do aluno é D\n");
}

//Crie um programa que:
//Receba uma senha.
//Receba um nível de acesso.
//Verifique se:
//A senha está correta (Considere a senha como 42).
//O nível de acesso é igual ou superior a 5.
//Exiba “Acesso liberado” se ambos os critérios forem atendidos, ou “Acesso negado” caso contrário.
Console.WriteLine("Entre com a senha:");
int senhaInserida = int.Parse(Console.ReadLine()!);
Console.WriteLine("Entre com o nivel de acesso requerido");
int nivelAcesso = int.Parse(Console.ReadLine()!);
if ( senhaInserida == 42 & nivelAcesso == 6)
{
    Console.WriteLine("Acesso concedido!\n");
}
else
{
    Console.WriteLine("Acesso negado.\n");
}

//Crie um programa que:

//Receba a idade do cliente como entrada.
//Classifique-o em uma das faixas
//Infantil (0 a 12 anos)
//Adolescente (13 a 17 anos)
//Adulto (18 a 59 anos)
//Idoso (60 anos ou mais)
//Exiba a categoria correspondente
Console.WriteLine("Entre com a idade do cliente:");
int idade = int.Parse(Console.ReadLine()!);
if (idade <= 12)
{
    Console.WriteLine("Classificação: Infantil\n");
}else if(idade > 12 & idade <= 17)
{
    Console.WriteLine("Classificação: Adolescente\n");
}else if (idade > 17 & idade <= 59)
{
    Console.WriteLine("Classificação: Adulto\n");
}else if (idade >= 60)
{
    Console.WriteLine("Classificação: Idoso\n");
}

//Crie um programa que:
//Receba dois números digitados pelo usuário.
//Pergunte qual a operação matemática deseja realizar (+, -, *, /).
//Exiba “Operação inválida” caso a entrada seja diferente das operações acima.
//Exiba o resultado de acordo com a operação escolhida.

Console.WriteLine("Digite o primeiro número:");
double num1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Digite o segundo número:");
double num2 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Digite a operação (+, -, *, /):");
string operacao = Console.ReadLine()!;

switch (operacao)
{
    case "+":
        Console.WriteLine("Resultado: " + (num1 + num2));
        break;
    case "-":
        Console.WriteLine("Resultado: " + (num1 - num2));
        break;
    case "*":
        Console.WriteLine("Resultado: " + (num1 * num2));
        break;
    case "/":
        Console.WriteLine("Resultado: " + (num1 / num2));
        break;
    default:
        Console.WriteLine("Operação inválida.");
        break;
}

//você precisa de um programa que:
//Pergunte ao usuário qual o momento do dia (manhã, tarde ou noite).
//Solicite o nome do usuário.
//Exiba uma saudação personalizada com base no momento do dia e no nome fornecido.
//Exiba uma mensagem em caso de opção inválida.
Console.WriteLine("""
    1 - Manhã
    2 - Tarde
    3 - Noite
 
    Que momento do dia é agora?
    """);
int momento = int.Parse(Console.ReadLine()!);
 
Console.WriteLine("Qual o seu nome? ");
string nome = Console.ReadLine()!;
 
switch(momento)
{
    case 1:
        Console.WriteLine($"Bom dia, {nome}");
        break;
    case 2:
        Console.WriteLine($"Boa tarde, {nome}");
        break;
    case 3:
        Console.WriteLine($"Boa noite, {nome}");
        break;
    default:
        Console.WriteLine("Entrada inválida");
        break;
}

//Crie um programa que:
//Receba o cupom de recompensa inserido
//Retorne uma mensagem de acordo com o cupom
//Informe que “Recompensa indisponível” se o cupom for inválido
Console.WriteLine("Digite o código de recompensa (DOBRAR, CURAR, OURO, ESPECIAL):");
string codigo = Console.ReadLine()!;

string mensagem = codigo switch
{
    "DOBRAR" => "Você ganhou 2x EXP por 1 hora!",
    "CURAR" => "Poção de cura adquirida!",
    "OURO" => "+1000 moedas de ouro!",
    "ESPECIAL" => "Item lendário desbloqueado!",
    _ => "Recompensa indisponível."
};

Console.WriteLine(mensagem);



//Atualmente, os livros são organizados em códigos de três dígitos e catalogados de acordo com o número inicial em seu código, seguindo a tabela abaixo:

//1: Ficção Científica
//2: Literatura Clássica
//3: Fantasia
//4: Romance
//5: Suspense / Mistério
//6: Não ficção
//7: Biografias / Memórias
//8: Distopia
//9: Infantojuvenil
Console.WriteLine("Digite o código do livro: ");
int codigoLivro = int.Parse(Console.ReadLine()!);

switch (codigoLivro / 100)
{
    case 1:
        Console.WriteLine("Ficção Científica");
        break;
    case 2:
        Console.WriteLine("Literatura Clássica");
        break;
    case 3:
        Console.WriteLine("Fantasia");
        break;
    case 4:
        Console.WriteLine("Romance");
        break;
    case 5:
        Console.WriteLine("Suspense/Mistério");
        break;
    case 6:
        Console.WriteLine("Não Ficção");
        break;
    case 7:
        Console.WriteLine("Biografias/Memórias");
        break;
    case 8:
        Console.WriteLine("Distopia");
        break;
    case 9:
        Console.WriteLine("Infantojuvenil");
        break;
    default:
        Console.WriteLine("Código inexistente");
        break;
}


//Crie um programa que:
//Solicite que o usuário digite seu nome
//Verifique se o nome corresponde ao do administrador (ex: "Admin")
//Caso não seja o administrador, exibir uma mensagem de "Usuário não cadastrado" e apresentar um menu com opções:
//Cadastrar novo usuário
//Acessar como convidado
//Sair do sistema

string ADMIN_USER = "Admin";

Console.WriteLine("Sistema de Autenticação");
Console.WriteLine("-----------------------");
Console.Write("Digite seu nome de usuário: ");

string username = Console.ReadLine();

if (username == ADMIN_USER)
{
    Console.WriteLine($"Bem-vindo, {username}!");
}

else
{
    Console.WriteLine("Usuário não cadastrado.");
    Console.WriteLine("Opções disponíveis:");
    Console.WriteLine("[1] Cadastrar novo usuário");
    Console.WriteLine("[2] Acessar como convidado");
    Console.WriteLine("[3] Sair");

    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Novo usuário '{username}' cadastrado com sucesso!");
            break;

        case 2:
            Console.WriteLine("Acesso concedido como convidado.");
            break;

        case 3:
            Console.WriteLine("Saindo do sistema...");
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Opção inválida. O sistema será encerrado.");
            break;
    }
}