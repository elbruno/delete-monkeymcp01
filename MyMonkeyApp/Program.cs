using MyMonkeyApp.Helpers;
using MyMonkeyApp.Models;

namespace MyMonkeyApp;

/// <summary>
/// Main program class for the Monkey Console Application.
/// </summary>
internal class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    /// <param name="args">Command line arguments.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    static async Task Main(string[] args)
    {
        await DisplayWelcomeMessageAsync();
        await RunMenuAsync();
    }

    /// <summary>
    /// Displays the welcome message with ASCII art.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    private static async Task DisplayWelcomeMessageAsync()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(@"
    🐒 Welcome to the Monkey Console Application! 🐒
    
            __
           /  \  
          |  o o|
           \  ~/  
           /   \ 
          /     \
         /       \
        
    Discover amazing monkeys from around the world!
");
        Console.ResetColor();
        await Task.Delay(1000);
    }

    /// <summary>
    /// Runs the main interactive menu loop.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    private static async Task RunMenuAsync()
    {
        bool running = true;

        while (running)
        {
            DisplayMenu();
            var choice = Console.ReadLine()?.Trim();

            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    await ListAllMonkeysAsync();
                    break;
                case "2":
                    await FindMonkeyByNameAsync();
                    break;
                case "3":
                    await ShowRandomMonkeyAsync();
                    break;
                case "4":
                    DisplayAbout();
                    break;
                case "5":
                case "q":
                case "quit":
                case "exit":
                    running = false;
                    DisplayGoodbye();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("❌ Invalid option. Please try again.");
                    Console.ResetColor();
                    break;
            }

            if (running)
            {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    /// <summary>
    /// Displays the main menu options.
    /// </summary>
    private static void DisplayMenu()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("🐒 === MONKEY CONSOLE APPLICATION ===");
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("Please choose an option:");
        Console.WriteLine("1. 📋 List all monkeys");
        Console.WriteLine("2. 🔍 Find monkey by name");
        Console.WriteLine("3. 🎲 Get random monkey");
        Console.WriteLine("4. ℹ️  About");
        Console.WriteLine("5. 🚪 Exit");
        Console.WriteLine();
        Console.Write("Enter your choice (1-5): ");
    }

    /// <summary>
    /// Lists all available monkeys.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    private static async Task ListAllMonkeysAsync()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("🐒 All Available Monkeys:");
        Console.ResetColor();
        Console.WriteLine();

        try
        {
            var monkeys = await MonkeyHelper.GetMonkeysAsync();

            for (int i = 0; i < monkeys.Count; i++)
            {
                Console.WriteLine($"{i + 1,2}. {monkeys[i]}");
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Total: {monkeys.Count} monkey species");
            Console.ResetColor();
        }
        catch (Exception ex)
        {
            DisplayError($"Error loading monkeys: {ex.Message}");
        }
    }

    /// <summary>
    /// Prompts the user to find a monkey by name.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    private static async Task FindMonkeyByNameAsync()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("🔍 Find Monkey by Name:");
        Console.ResetColor();
        Console.WriteLine();
        Console.Write("Enter the monkey name: ");

        var name = Console.ReadLine()?.Trim();

        if (string.IsNullOrWhiteSpace(name))
        {
            DisplayError("Please enter a valid monkey name.");
            return;
        }

        try
        {
            var monkey = await MonkeyHelper.GetMonkeyByNameAsync(name);

            if (monkey != null)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("🎉 Monkey Found!");
                Console.ResetColor();
                DisplayMonkeyDetails(monkey);
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"❌ No monkey found with the name '{name}'.");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("💡 Tip: Try searching for names like 'Baboon', 'Capuchin', or 'Spider Monkey'");
            }
        }
        catch (Exception ex)
        {
            DisplayError($"Error searching for monkey: {ex.Message}");
        }
    }

    /// <summary>
    /// Shows a random monkey.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    private static async Task ShowRandomMonkeyAsync()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("🎲 Random Monkey:");
        Console.ResetColor();
        Console.WriteLine();

        try
        {
            var monkey = await MonkeyHelper.GetRandomMonkeyAsync();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("🎉 Here's your random monkey!");
            Console.ResetColor();
            DisplayMonkeyDetails(monkey);
        }
        catch (Exception ex)
        {
            DisplayError($"Error getting random monkey: {ex.Message}");
        }
    }

    /// <summary>
    /// Displays detailed information about a monkey.
    /// </summary>
    /// <param name="monkey">The monkey to display.</param>
    private static void DisplayMonkeyDetails(Monkey monkey)
    {
        Console.WriteLine();
        Console.WriteLine("🐒 Monkey Details:");
        Console.WriteLine($"   Name: {monkey.Name}");
        Console.WriteLine($"   Location: {monkey.Location}");
        Console.WriteLine($"   Population: {monkey.Population:N0}");
        Console.WriteLine();

        // Add some fun ASCII art based on the monkey type
        DisplayMonkeyArt(monkey.Name);
    }

    /// <summary>
    /// Displays ASCII art based on the monkey type.
    /// </summary>
    /// <param name="monkeyName">The name of the monkey.</param>
    private static void DisplayMonkeyArt(string monkeyName)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;

        // Simple ASCII art variations
        if (monkeyName.Contains("Spider", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine(@"
       🕷️ Spider Monkey 🕷️
          \   o   /
           \ | | /
            \| |/
             \_/
");
        }
        else if (monkeyName.Contains("Howler", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine(@"
       🔊 Howler Monkey 🔊
            ___
           /   \
          | O O |
           \ ~ /
            \_/
         AAHHHOOO!
");
        }
        else if (monkeyName.Contains("Golden", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine(@"
       ✨ Golden Monkey ✨
            ___
           /   \
          | ★ ★ |
           \ ◡ /
            \_/
");
        }
        else if (monkeyName.Contains("Baboon", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine(@"
       🦧 Baboon 🦧
            ___
           /   \
          | o o |
           \ ~ /
            \_/
");
        }
        else
        {
            Console.WriteLine(@"
            🐒
           ___
          /   \
         | o o |
          \ ~ /
           \_/
");
        }

        Console.ResetColor();
    }

    /// <summary>
    /// Displays information about the application.
    /// </summary>
    private static void DisplayAbout()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("ℹ️  About Monkey Console Application:");
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("This application provides information about various monkey species");
        Console.WriteLine("from around the world. You can:");
        Console.WriteLine("• Browse all available monkeys");
        Console.WriteLine("• Search for specific monkeys by name");
        Console.WriteLine("• Discover random monkeys");
        Console.WriteLine();
        Console.WriteLine($"Database contains information about {MonkeyHelper.GetMonkeyCount()} monkey species.");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Created with ❤️ for monkey enthusiasts!");
        Console.ResetColor();
    }

    /// <summary>
    /// Displays an error message.
    /// </summary>
    /// <param name="message">The error message to display.</param>
    private static void DisplayError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"❌ Error: {message}");
        Console.ResetColor();
    }

    /// <summary>
    /// Displays the goodbye message.
    /// </summary>
    private static void DisplayGoodbye()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(@"
    🐒 Thank you for using the Monkey Console Application! 🐒
    
            __
           /  \  
          |  ^ ^|
           \  ◡/  
           /   \ 
          /     \
         /       \
        
    See you later, monkey lover! 🍌
");
        Console.ResetColor();
    }
}
