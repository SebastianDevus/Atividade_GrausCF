double grausF, grausC;

Console.Write("Insira a temperatura (°C): ");
grausC = Convert.ToDouble(Console.ReadLine()!);

grausF = grausC * 1.8 + 32;

Console.WriteLine($"O equivalente em °F é {grausF:N2}");