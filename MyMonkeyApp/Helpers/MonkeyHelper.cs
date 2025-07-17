using MyMonkeyApp.Models;

namespace MyMonkeyApp.Helpers;

/// <summary>
/// Static helper class for managing monkey data and operations.
/// </summary>
public static class MonkeyHelper
{
    private static readonly List<Monkey> _monkeys = new()
    {
        new("Baboon", "Africa & Arabia", 2000000),
        new("Capuchin", "Central & South America", 150000),
        new("Blue Monkey", "East & Central Africa", 200000),
        new("Squirrel Monkey", "Central & South America", 300000),
        new("Golden Snub-nosed Monkey", "Central China", 10000),
        new("Howler Monkey", "Central & South America", 100000),
        new("Japanese Macaque", "Japan", 50000),
        new("Mandrill", "Equatorial Africa", 800000),
        new("Proboscis Monkey", "Borneo", 7000),
        new("Vervet Monkey", "Southern & Eastern Africa", 500000),
        new("Spider Monkey", "Central & South America", 250000),
        new("Rhesus Macaque", "Asia", 25000000),
        new("Gelada", "Ethiopian Highlands", 200000),
        new("Tamarin", "Amazon Basin", 800000),
        new("Marmoset", "South America", 1000000)
    };

    /// <summary>
    /// Gets all available monkeys.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of all monkeys.</returns>
    public static async Task<List<Monkey>> GetMonkeysAsync()
    {
        // Simulate some async work (e.g., database call)
        await Task.Delay(50);
        return _monkeys.ToList();
    }

    /// <summary>
    /// Gets all available monkeys synchronously.
    /// </summary>
    /// <returns>A list of all monkeys.</returns>
    public static List<Monkey> GetMonkeys()
    {
        return _monkeys.ToList();
    }

    /// <summary>
    /// Gets a specific monkey by name (case-insensitive search).
    /// </summary>
    /// <param name="name">The name of the monkey to find.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the monkey if found, null otherwise.</returns>
    public static async Task<Monkey?> GetMonkeyByNameAsync(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            return null;

        // Simulate some async work
        await Task.Delay(25);
        
        return _monkeys.FirstOrDefault(m => 
            string.Equals(m.Name, name, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// Gets a specific monkey by name (case-insensitive search) synchronously.
    /// </summary>
    /// <param name="name">The name of the monkey to find.</param>
    /// <returns>The monkey if found, null otherwise.</returns>
    public static Monkey? GetMonkeyByName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            return null;
            
        return _monkeys.FirstOrDefault(m => 
            string.Equals(m.Name, name, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// Gets a random monkey from the available collection.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation. The task result contains a randomly selected monkey.</returns>
    public static async Task<Monkey> GetRandomMonkeyAsync()
    {
        // Simulate some async work
        await Task.Delay(25);
        
        var random = new Random();
        var index = random.Next(_monkeys.Count);
        return _monkeys[index];
    }

    /// <summary>
    /// Gets a random monkey from the available collection synchronously.
    /// </summary>
    /// <returns>A randomly selected monkey.</returns>
    public static Monkey GetRandomMonkey()
    {
        var random = new Random();
        var index = random.Next(_monkeys.Count);
        return _monkeys[index];
    }

    /// <summary>
    /// Gets the total count of available monkeys.
    /// </summary>
    /// <returns>The number of monkeys in the collection.</returns>
    public static int GetMonkeyCount()
    {
        return _monkeys.Count;
    }
}