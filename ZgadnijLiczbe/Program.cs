Random c = new Random();
int liczba1 = c.Next(1, 10);
int y = 0;

Console.WriteLine("Licba została wylosowana");
while (true)
{
    string wybor = Console.ReadLine();

    object int32 = null;
    if (!Int32.TryParse(wybor, out y))
    {
        Console.WriteLine("Zgadnij liczbę: ");
        continue;
    }

    if (y == liczba1)
    {
        Console.WriteLine("Wygrałeś");
        break;
    }
    else if (y > liczba1)
    {
        Console.WriteLine("Liczba jest mniejsza.");
        continue;
    }
    else if (y < liczba1)
    {
        Console.WriteLine("Liczba jest większa.");
        continue;
    }
    else
    {
        Console.WriteLine("Przegrałes.");
    }
}