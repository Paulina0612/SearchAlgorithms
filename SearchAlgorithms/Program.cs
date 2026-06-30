
void Menu()
{
    Console.WriteLine("Menu");
    Console.WriteLine("1. Linear Search.");
    Console.WriteLine("2. Binary Search.");
    Console.WriteLine("3. Exit.\n");
}



void LinearSearch()
{
    Console.WriteLine("Linear");
}



void BinarySearch()
{
    Console.WriteLine("Binary");
}



while (true)
{
    Menu();
    Console.WriteLine("Enter number of the desired option.");
    var opt = Console.ReadLine();

    switch (opt)
    {
        case "1":
            LinearSearch();
            break;
        case "2":
            BinarySearch();
            break;
        case "3":
            return 0;
        default:
            Console.WriteLine("Incorrect input. ");
            break;
    }

    Console.Write("\n\n\n");
}