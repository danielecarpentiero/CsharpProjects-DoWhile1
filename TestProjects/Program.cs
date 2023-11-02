Console.WriteLine("Inserire un numero intero compreso fra 5 e 10.");
int value;

do
{
    string? input = Console.ReadLine();

    if (!int.TryParse(input, out value))
    {
        Console.WriteLine("Mi dispiace, hai inserito un valore errato, riprova.");
    }
    else if (value < 5 || value > 10)
    {
        Console.WriteLine($"Hai inserito {value}. Per favore digita un valore compreso fra 5 e 10.");
    }
} while (value < 5 || value > 10);

if (value >= 5 || value <= 10)
{

    Console.WriteLine($"Il valore che hai inserito, {value} è stato accettato.");
}
