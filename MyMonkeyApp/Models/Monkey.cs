namespace MyMonkeyApp.Models;

/// <summary>
/// Represents a monkey with basic information about its characteristics and habitat.
/// </summary>
public class Monkey
{
    /// <summary>
    /// Gets or sets the name of the monkey species.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the primary location or habitat where this monkey species is found.
    /// </summary>
    public string Location { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the estimated population count for this monkey species.
    /// </summary>
    public int Population { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Monkey"/> class.
    /// </summary>
    public Monkey()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Monkey"/> class with specified values.
    /// </summary>
    /// <param name="name">The name of the monkey species.</param>
    /// <param name="location">The primary location or habitat.</param>
    /// <param name="population">The estimated population count.</param>
    public Monkey(string name, string location, int population)
    {
        Name = name;
        Location = location;
        Population = population;
    }

    /// <summary>
    /// Returns a string representation of the monkey information.
    /// </summary>
    /// <returns>A formatted string containing the monkey's details.</returns>
    public override string ToString()
    {
        return $"{Name} - Location: {Location}, Population: {Population:N0}";
    }
}