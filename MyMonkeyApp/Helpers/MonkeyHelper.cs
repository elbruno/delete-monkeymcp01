using MyMonkeyApp.Models;

namespace MyMonkeyApp.Helpers;

/// <summary>
/// Static helper class for managing monkey data and operations.
/// </summary>
public static class MonkeyHelper
{
    private static readonly List<Monkey> _monkeys = new()
    {
        new("Baboon", "Africa & Arabia", "Large, terrestrial primates known for their dog-like snouts and complex social structures.", "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg", 2000000, -1.0, 20.0),
        new("Capuchin", "Central & South America", "Intelligent New World monkeys known for their problem-solving abilities and tool use.", "https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg", 150000, 9.7489, -83.7534),
        new("Blue Monkey", "East & Central Africa", "Arboreal monkeys with distinctive blue-grey fur and white throat patches.", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/200px-BlueMonkey.jpg", 200000, -1.2921, 36.8219),
        new("Squirrel Monkey", "Central & South America", "Small, agile primates with golden fur and distinctive black and white facial markings.", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1c/Saimiri_sciureus-1_Luc_Viatour.jpg/200px-Saimiri_sciureus-1_Luc_Viatour.jpg", 300000, -3.4653, -62.2159),
        new("Golden Snub-nosed Monkey", "Central China", "Endangered primates with striking golden fur, adapted to cold mountain forests.", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c8/Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg/200px-Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg", 10000, 33.5, 107.5),
        new("Howler Monkey", "Central & South America", "Known for their powerful vocalizations that can be heard up to 3 miles away.", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Alouatta_guariba.jpg/200px-Alouatta_guariba.jpg", 100000, -3.4653, -62.2159),
        new("Japanese Macaque", "Japan", "Also known as snow monkeys, famous for bathing in hot springs during winter.", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Macaca_fuscata_fuscata1.jpg/200px-Macaca_fuscata_fuscata1.jpg", 50000, 36.2048, 138.2529),
        new("Mandrill", "Equatorial Africa", "The world's largest monkey species, males have colorful facial markings.", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Mandrill_at_san_francisco_zoo.jpg/200px-Mandrill_at_san_francisco_zoo.jpg", 800000, -1.0, 11.0),
        new("Proboscis Monkey", "Borneo", "Endemic to Borneo, known for their large, pendulous noses and excellent swimming ability.", "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/Proboscis_Monkey_in_Borneo.jpg/200px-Proboscis_Monkey_in_Borneo.jpg", 7000, 1.5, 114.0),
        new("Vervet Monkey", "Southern & Eastern Africa", "Highly social monkeys known for their distinct alarm calls for different predators.", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5c/Vervet_Monkey_Kruger.jpg/200px-Vervet_Monkey_Kruger.jpg", 500000, -25.0, 30.0),
        new("Spider Monkey", "Central & South America", "Long-limbed primates that use their arms to swing through trees with remarkable agility.", "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4c/Spider_Monkey_edit.jpg/200px-Spider_Monkey_edit.jpg", 250000, -3.4653, -62.2159),
        new("Rhesus Macaque", "Asia", "Highly adaptable monkeys found across diverse habitats, important in medical research.", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0f/Macaca_mulatta.jpg/200px-Macaca_mulatta.jpg", 25000000, 28.7041, 77.1025),
        new("Gelada", "Ethiopian Highlands", "Ground-dwelling primates with distinctive red chest patches, found only in Ethiopia.", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/13/Gelada-Pavian.jpg/200px-Gelada-Pavian.jpg", 200000, 9.1450, 40.4897),
        new("Tamarin", "Amazon Basin", "Small, colorful New World monkeys known for their distinctive mustaches and manes.", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/03/Saguinus_midas_-_Wilhelma_Zoo_Stuttgart.jpg/200px-Saguinus_midas_-_Wilhelma_Zoo_Stuttgart.jpg", 800000, -3.4653, -62.2159),
        new("Marmoset", "South America", "Tiny primates with claw-like nails instead of fingernails, excellent climbers.", "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3c/Callithrix_jacchus_-_face.jpg/200px-Callithrix_jacchus_-_face.jpg", 1000000, -10.0, -55.0)
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