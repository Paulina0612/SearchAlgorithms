
void Menu()
{
    Console.WriteLine("Menu");
    Console.WriteLine("1. Linear Search.");
    Console.WriteLine("2. Binary Search.");
    Console.WriteLine("3. Exit.\n");
}



bool LinearSearch(int[] array, int target)
{
    foreach (int i in array)
        if (i == target) return true;
    return false;
}



bool BinarySearch(int[] array, int target)
{
    int start = 0;
    int end = array.Length-1;
    int index = end/2;

    while (true)
    {
        if (Math.Abs(end - start) == 1 && !(array[start] == target || array[end] == target)) return false;

        if (array[index] == target || array[index + 1] == target) return true;
        else if (array[index] < target)
        {
            start = index;
            index = ((end - start) / 2) + start;
        }
        else if (array[index] > target)
        {
            end = index;
            index = (end - start) / 2;
        }
    }
}





// Mockup data
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
int target = 9;





// Main loop
while (true)
{
    Menu();
    Console.WriteLine("Enter number of the desired option.");
    var opt = Console.ReadLine();

    switch (opt)
    {
        case "1":
            if (LinearSearch(array, target) is true) Console.WriteLine("Target found.");
            else Console.WriteLine("Target not found.");
            break;
        case "2":
            if (BinarySearch(array, target) == true) Console.WriteLine("Target found.");
            else Console.WriteLine("Target not found.");
            break;
        case "3":
            return 0; 
        default:
            Console.WriteLine("Incorrect input. ");
            break;
    }

    Console.Write("\n\n\n");
}