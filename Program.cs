Console.Clear();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("--- Esperto Contra Sabido ---\n");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("Quantos alimentos serão distribuídos? ");

Console.ResetColor(); 
int total = Convert.ToInt32(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.DarkBlue;
if (total <= 0) return;

Console.WriteLine();

int restantes = total;
int PicaPau = 0, Raposinha = 0;

int contadorParaVoce = 0, contadorParaMim = 0;
while (restantes > 0)
{
    contadorParaVoce++;
    PicaPau += 1;
    restantes -= 1;

    Console.Write($"{PicaPau} para você. ");

    contadorParaMim = 0;
    while (restantes > 0 && contadorParaMim < contadorParaVoce)
    {
        contadorParaMim++;
        Raposinha += 1;
        restantes -= 1;

        Console.Write($"{contadorParaMim}");

        if (restantes > 0 && contadorParaMim < contadorParaVoce)
        {
            Console.Write(",");
        }

        Console.Write(" ");
    }

    if (contadorParaMim > 0)
    {
        Console.WriteLine("para mim.");
    }
}

if (contadorParaMim == 0)
{
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine($"Pica-pau recebeu {PicaPau} alimento(s).");
Console.WriteLine($"Raposinha recebeu {Raposinha} alimento(s).");
Console.ResetColor(); 