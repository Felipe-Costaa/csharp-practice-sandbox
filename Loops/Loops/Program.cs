int opcaoMenu = 0;
do
{
    Console.WriteLine("Bem vindo aao menu de opções de exercicios!");
    Console.WriteLine("Entre com a opção do exercicio que você quer executar");
    Console.WriteLine("Exercicio 1: Soma das vendas");
    Console.WriteLine("Sair: -1");
    opcaoMenu = int.Parse(Console.ReadLine()!);
    switch (opcaoMenu)
    {
        case 1:
            SomaDasVendas();
            break;
    }



} while (opcaoMenu != -1);

void SomaDasVendas()
{
    int encerraRegistros = 0;
    double totalVendas = 0.00;
    while (encerraRegistros != 1)
    {
        Console.WriteLine("Entre com o valor da venda:");
        totalVendas = totalVendas + double.Parse(Console.ReadLine()!);
        Console.WriteLine("Vendas encerradas? 1 - SIM ou 2 - NÃO");
        encerraRegistros = int.Parse(Console.ReadLine()!);
    }
    Console.WriteLine($"Total de vendas do dia: R$ {totalVendas}");
    Console.WriteLine($"Pressione qualquer tecla para sair");
    Console.ReadKey();
    Console.Clear();

}