Console.WriteLine("Podaj jaką kością chcesz rzucić:");
Console.WriteLine("1. D3");
Console.WriteLine("2. D4");
Console.WriteLine("3. D6");
Console.WriteLine("4. D10");
Console.WriteLine("5. D12");
Console.WriteLine("6. D20");
Console.WriteLine("7. D100");
Console.WriteLine("q. Exit");

Random rng = new Random();
int randomThrow = 0;
char choice;
do
{
    choice = Console.ReadKey().KeyChar;
    Console.WriteLine("");
    switch (choice)
    {
        case '1':
            randomThrow = rng.Next(1, 4);
            Console.WriteLine("Rzut kością D3: " + randomThrow.ToString());
            break;
        case '2':
            randomThrow = rng.Next(1, 5);
            Console.WriteLine("Rzut kością D4: " + randomThrow.ToString());
            break;
        case '3':
            randomThrow = rng.Next(1, 7);
            Console.WriteLine("Rzut kością D6: " + randomThrow.ToString());
            break;
        case '4':
            randomThrow = rng.Next(1, 11);
            Console.WriteLine("Rzut kością D10: " + randomThrow.ToString());
            break;
        case '5':
            randomThrow = rng.Next(1, 13);
            Console.WriteLine("Rzut kością D12: " + randomThrow.ToString());
            break;
        case '6':
            randomThrow = rng.Next(1, 21);
            Console.WriteLine("Rzut kością D20: " + randomThrow.ToString());
            break;
        case '7':
            randomThrow = rng.Next(1, 101);
            Console.WriteLine("Rzut kością D100: " + randomThrow.ToString());
            break;
        case 'q':
            break;
        default:
            Console.WriteLine("Podałeś złą opcję!");
            break;
    }
    Console.WriteLine();
}
while (choice != 'q');

