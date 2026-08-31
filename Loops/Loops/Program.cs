int opcaoMenu = 0;
do
{
    Console.WriteLine("Bem vindo aao menu de opções de exercicios!");
    Console.WriteLine("Entre com a opção do exercicio que você quer executar");
    Console.WriteLine("Exercicio 1: Soma das vendas");
    Console.WriteLine("Exercicio 2: Controle de estoque");
    Console.WriteLine("Sair: -1");
    opcaoMenu = int.Parse(Console.ReadLine()!);
    switch (opcaoMenu)
    {
        case 1:
            SomaDasVendas();
            break;
        case 2:
            ControleDeEstoque();
            break;
    }



} while (opcaoMenu != -1);

void SomaDasVendas()
{
    int encerraRegistros = 0;
    double totalVendas = 0.00;
    Console.Clear();
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
void ControleDeEstoque()
{
    int controleLoop = 0;
    int quantidadeEstoque = 0;
    Console.Clear();
    do
    {
        Console.WriteLine("Deseja adicionar um produto ao estoque?");
        Console.WriteLine("1 - SIM | 2 - NÃO");
        controleLoop = int.Parse(Console.ReadLine()!);
        if (controleLoop == 1)
        {
            Console.WriteLine("Quantidade:");
            quantidadeEstoque = quantidadeEstoque + int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Estoque atual: {quantidadeEstoque}");

        }
        else
        {
            Console.WriteLine("Obrigado por usar nosso sistema!");
            Thread.Sleep(2000);
            Console.Clear();
        }
    } while (controleLoop != 2);
    
}