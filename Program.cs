string cebolinha;

Console.Write("Digite uma frase: ");
cebolinha = Console.ReadLine()!;

cebolinha = cebolinha
    .Replace("r", "l")
    .Replace("R", "L");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"\n{cebolinha}");
Console.ResetColor();

