// private bool isRunning = true;
List<string> groceries = [];
groceries.Add("Cat food");
groceries.Add("Human food");
groceries.Add("Milk (for pancakes)");

// foreach (string item in groceries)
// {
//     Console.WriteLine(item);
// }

while (true)
{
    Console.WriteLine("--- Today's grocery list! ---");
    
    foreach (string item in groceries)
    {
        Console.WriteLine(item);
    }
    
    Console.WriteLine("1 - Add item");
    Console.WriteLine("2 - Show list");
    Console.WriteLine("Q - Quit");

    string input = Console.ReadLine();

    if (input == "1")
    {
        Console.WriteLine("What would you like to add?");
        input = Console.ReadLine();
        groceries.Add(input);
        // break;
    }
    
    else if (input.ToLower() == "q")
    {
        break;
    }
}