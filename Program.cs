using System.Runtime.InteropServices;
using DesafioFundamentos.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoFixo = 0;
decimal precoPorHora = 0;

Console.WriteLine("Bem vindo ao sistema de estacionamento!");
Console.WriteLine("Insira o valor do preço fixo:");
precoFixo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira o valor do preço por hora:");
precoPorHora = Convert.ToInt32(Console.ReadLine());

Estacionamento Parking = new Estacionamento(precoFixo, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Escolha uma operação:");
    Console.WriteLine("[1] Cadastrar um veículo");
    Console.WriteLine("[2] Remover um veículo");
    Console.WriteLine("[3] Listar veículos estacionados");
    Console.WriteLine("[4] Encerrar programa");
    
    switch (Console.ReadLine())
    {
        case "1":
            Parking.AdicionarVeiculo();
            break;
        case "2":
            Parking.RemoverVeiculo();
            break;
        case "3":
            Parking.ListarVeiculos();
            break;
        case "4":
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    
    Console.WriteLine("Pressione qualquer tecla para continuar:");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou!");
