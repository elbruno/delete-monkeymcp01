using MyMonkeyApp.Models;

namespace MyMonkeyApp.Helpers;

/// <summary>
/// Static helper class for managing monkey data and operations.
/// </summary>
public static class MonkeyHelper
{
    private static readonly List<Monkey> _monkeys = new()
    {
        new("Baboon", "Africa & Arabia", "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg", null, 2000000),
        new("Capuchin", "Central & South America", "https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg", null, 150000),
        new("Blue Monkey", "East & Central Africa", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/200px-BlueMonkey.jpg", null, 200000),
        new("Squirrel Monkey", "Central & South America", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1c/Saimiri_sciureus-1_Luc_Viatour.jpg/200px-Saimiri_sciureus-1_Luc_Viatour.jpg", null, 300000),
        new("Golden Snub-nosed Monkey", "Central China", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c8/Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg/200px-Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg", null, 10000),
        new("Howler Monkey", "Central & South America", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Alouatta_guariba.jpg/200px-Alouatta_guariba.jpg", null, 100000),
        new("Japanese Macaque", "Japan", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Macaca_fuscata_fuscata1.jpg/200px-Macaca_fuscata_fuscata1.jpg", null, 50000),
        new("Mandrill", "Equatorial Africa", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Mandrill_at_san_francisco_zoo.jpg/200px-Mandrill_at_san_francisco_zoo.jpg", null, 800000),
        new("Proboscis Monkey", "Borneo", "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/Proboscis_Monkey_in_Borneo.jpg/200px-Proboscis_Monkey_in_Borneo.jpg", null, 7000),
        new("Vervet Monkey", "Southern & Eastern Africa", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5c/Vervet_Monkey_Kruger.jpg/200px-Vervet_Monkey_Kruger.jpg", null, 500000),
        new("Spider Monkey", "Central & South America", "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4c/Spider_Monkey_edit.jpg/200px-Spider_Monkey_edit.jpg", null, 250000),
        new("Rhesus Macaque", "Asia", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0f/Macaca_mulatta.jpg/200px-Macaca_mulatta.jpg", null, 25000000),
        new("Gelada", "Ethiopian Highlands", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/13/Gelada-Pavian.jpg/200px-Gelada-Pavian.jpg", null, 200000),
        new("Tamarin", "Amazon Basin", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/03/Saguinus_midas_-_Wilhelma_Zoo_Stuttgart.jpg/200px-Saguinus_midas_-_Wilhelma_Zoo_Stuttgart.jpg", null, 800000, -3.4653, -62.2159),
        new("Marmoset", "South America", "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3c/Callithrix_jacchus_-_face.jpg/200px-Callithrix_jacchus_-_face.jpg", null, 1000000, -10.0, -55.0)
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