Console.Clear();

Console.WriteLine(
@"
Menu de opções
--------------
N. Novo arquivo
A. Abrir arquivo
H. Ajuda
X. Sair
");

Console.Write("\nSelecione uma opção do menu: ");
string entrada = Console.ReadLine()!
                .Substring(0,1).ToUpper();

switch (entrada)
{
    case "N":
    case "n":
        Console.WriteLine("Novo arquivo");
        break;
    case "A":
    case "a":
        Console.WriteLine("Abrir arquivo");
        break;
    case "H":
    case "h":
        Console.WriteLine("Ajuda");
        break;
    case "X":
    case "x":
        Console.WriteLine("Sair");
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;
}

