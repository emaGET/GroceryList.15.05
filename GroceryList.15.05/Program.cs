// private bool isRunning = true;
List<string> groceries = [];
groceries.Add("Cat food");
groceries.Add("Human food");
groceries.Add("Milk");

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
    Console.WriteLine("2 - Remove Item");
    Console.WriteLine("3 - Search");
    Console.WriteLine("Q - Quit");

    string input = Console.ReadLine();

    if (input == "1")
    {
        Console.WriteLine("What would you like to add?");
        input = Console.ReadLine();
        groceries.Add(input);
        // break;
    }

    else if (input == "2")
    {
        Console.WriteLine("What would you like to remove?");
        input = Console.ReadLine();
        string found = groceries.Find(item => item.ToLower() == input.ToLower());
        if (groceries.Contains(found))
        {
            groceries.Remove(found);
        }
        else
        {
            Console.WriteLine("Item not found...");
        }
    }
    
    else if (input == "3")
    {
        Console.WriteLine("What are you looking for?");
        input = Console.ReadLine();
        string found = groceries.Find(item => item.ToLower() == input.ToLower());
        
        if (found != null)
        {
            Console.WriteLine("It's on the list!");
        }
        else
        {
            Console.WriteLine("Item not found... Better if you add it");
        }

    }
    
    
    else if (input.ToLower() == "q")
    {
        break;
    }
}