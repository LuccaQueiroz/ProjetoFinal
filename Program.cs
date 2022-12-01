double a, b, c, delta, x1, x2;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("-- Bem vindo ao Facilitador --");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Digite aqui sua dúvida sobre equações de segundo grau:");
Console.ResetColor();
Console.WriteLine("");

Console.Write("(a): ");
a = Convert.ToDouble(Console.ReadLine());

Console.Write("(b): ");
b = Convert.ToDouble(Console.ReadLine());

Console.Write("(c): ");
c = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();


if (a == 0)
{
    Console.WriteLine("Isso não é uma equação de segundo grau");
}
else
{
    delta = b * b - 4 * a * c;

    if (delta < 0)
    {
        Console.WriteLine($"Como delta = {delta:N2}, a equação não possui raízes");
    }
    else
    {
        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        x2 = (-b - Math.Sqrt(delta)) / (2 * a);

        Console.WriteLine($"O resultado é: x1 = {x1:N2} e x2 = {x2:N2}");
    }
}

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("-- Obrigado por usar nosso programa! --");
Console.ResetColor();