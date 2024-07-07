namespace ServerManagement.Models;

public class Server
{
    public Server()
    {
        Random random = new();
        var randomValue = random.Next(0, 2);
        IsOnline = randomValue != 0;
    }

public int ServerId { get; set; }
    public bool IsOnline { get; set; }
    public string? Name { get; set; }
    public string? City { get; set; }
}