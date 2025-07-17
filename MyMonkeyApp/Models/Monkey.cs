namespace MyMonkeyApp.Models;

/// <summary>
/// Represents a monkey with detailed information from MonkeyMCP.
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
    /// Gets or sets the description or details about the monkey.
    /// </summary>
    public string? Details { get; set; }

    /// <summary>
    /// Gets or sets the image URL for the monkey.
    /// </summary>
    public string? Image { get; set; }

    /// <summary>
    /// Gets or sets the estimated population count for this monkey species.
    /// </summary>
    public int Population { get; set; }

    /// <summary>
    /// Gets or sets the latitude of the monkey's habitat.
    /// </summary>
    public double? Latitude { get; set; }

    /// <summary>
    /// Gets or sets the longitude of the monkey's habitat.
    /// </summary>
    public double? Longitude { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Monkey"/> class.
    /// </summary>
    public Monkey()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Monkey"/> class with all fields required.
    /// </summary>
    public Monkey(
        string name,
        string location,
        string? details,
        string? image,
        int population,
        double? latitude,
        double? longitude)
    {
        Name = name;
        Location = location;
        Details = details;
        Image = image;
        Population = population;
        Latitude = latitude;
        Longitude = longitude;
    }

    /// <summary>
    /// Returns a string representation of the monkey information.
    /// </summary>
    /// <returns>A formatted string containing all the monkey's details.</returns>
    public override string ToString()
    {
        return
            $"Name: {Name}\n" +
            $"Location: {Location}\n" +
            $"Details: {Details ?? "N/A"}\n" +
            $"Image: {Image ?? "N/A"}\n" +
            $"Population: {Population:N0}\n" +
            $"Latitude: {(Latitude.HasValue ? Latitude.Value.ToString() : "N/A")}\n" +
            $"Longitude: {(Longitude.HasValue ? Longitude.Value.ToString() : "N/A")}";
    }
}