namespace ServerManagement.Models;

public static class ServersRepository
{
    private static readonly List<Server> Servers = [];
    
    static ServersRepository()
    {
        var cities = CitiesRepository.GetCities();
        var random = new Random();
        
        for (var i = 1; i <= 15; i++)
        {
            var randomCityIndex = random.Next(0, cities.Count);
            var city = cities[randomCityIndex];
            
            Servers.Add(new Server { ServerId = i, Name = $"Server{i}", City = city });
        }
    }
    
    public static void AddServer(Server server)
    {
        var maxId = Servers.Max(s => s.ServerId);
        server.ServerId = maxId + 1;
        Servers.Add(server);
    }

    public static List<Server> GetServers() => Servers;
    
    public static List<Server> GetServersByCity(string city) => Servers.Where(
        s => s.City != null && s.City.Equals(city, StringComparison.OrdinalIgnoreCase)).ToList();
    
    public static Server? GetServerById(int serverId)
    {
        var server = Servers.FirstOrDefault(s => s.ServerId == serverId);

        return server ?? null;
    }
    
    public static List<Server> SearchServers(string searchTerm)
    {
        return Servers.Where(s => 
            s.Name != null && s.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}