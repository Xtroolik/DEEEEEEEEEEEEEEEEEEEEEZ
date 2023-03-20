Console.WriteLine("Podaj jaką kością chcesz rzucić:");
Console.WriteLine("1. D3");
Console.WriteLine("2. D4");
Console.WriteLine("3. D6");
string choice = Console.ReadLine();
Random rng = new Random();
int randomThrow = 0;

switch(choice) 
{
    case "1":
        randomThrow = rng.Next(1, 3);
        Console.WriteLine("Rzut kością D3: " + randomThrow.ToString());
        break;
    case "2":
        randomThrow = rng.Next(1, 4);
        Console.WriteLine("Rzut kością D4: " + randomThrow.ToString());
        break;
    case "3":
        randomThrow = rng.Next(1, 6);
        Console.WriteLine("Rzut kością D6: " + randomThrow.ToString());
        break;
    default:
        Console.WriteLine("Podałeś złą opcję!");
        break;
}
