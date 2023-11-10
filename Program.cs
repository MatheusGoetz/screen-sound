List<string> listaDeBandas = new List<string> { "Pearl Jam", "The Beatles" };

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
}

void ExibirOpcoesMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumero = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumero)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            Console.WriteLine("Voce escolheu a opção " + opcaoEscolhidaNumero);
            break;
        case 4:
            Console.WriteLine("Voce escolheu a opção " + opcaoEscolhidaNumero);
            break;
        case -1:
            Console.WriteLine("Saindo do programa, muito obrigado por utilizar Screen Sound :)");
            break;
        default:
            Console.WriteLine(opcaoEscolhidaNumero + " Desculpe, opção inválida!!");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro Das Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDeBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo Bandas Registradas");

    foreach (string banda in listaDeBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    };

    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
};
void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string marcadores = string.Empty.PadLeft(quantidadeLetras, '*');
    Console.WriteLine(marcadores);
    Console.WriteLine(titulo);
    Console.WriteLine(marcadores);
};
ExibirLogo();
ExibirOpcoesMenu();
