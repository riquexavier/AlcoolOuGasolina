﻿double ValorGAS, ValorALC;
double Porcen;

Console.Clear();

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write("Encho com Alcool ou Gasolina?");
Console.ResetColor();

Console.Write("\n\nDigite o Preço do Etanol (R$).....: ");
ValorALC = Convert.ToDouble(Console.ReadLine());

Console.Write("\nDigite o Preço da Gasolina (R$).....: ");
ValorGAS = Convert.ToDouble(Console.ReadLine());
Porcen = MelhorEnch(ValorALC,ValorGAS);

Console.WriteLine($"O preço do etanol corresponde a {Porcen:N2}% do preço da gasolina.");
Console.Write("\nRecomendação: Abasteça com ");
if(Porcen<73)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write("ETANOL");
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write("GASOLINA");
}
Console.ResetColor();

double MelhorEnch(double ValorALC ,double ValorGAS)
{
    Porcen = (ValorALC/ValorGAS)*100;
    return Porcen;
}