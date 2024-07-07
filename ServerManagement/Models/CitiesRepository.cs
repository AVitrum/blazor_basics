namespace ServerManagement.Models;

public static class CitiesRepository
{
    private static readonly List<string> Cities =
    [
        "New York",
        "Los Angeles",
        "Chicago",
        "Houston",
        "Phoenix",
    ];
    
    public static List<string> GetCities() => Cities;
}