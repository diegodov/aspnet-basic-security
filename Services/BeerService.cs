using BasicSecurityASP.Models;
using System.Text.Json;

namespace BasicSecurityASP.Services
{
    public class BeerService : IBeerService
    {
        string path = @"C:\Users\diego\projects\asp.net\source\BasicSecurityASP\beers.json";

        public async Task<List<Beer>> GetBeers()
        {
            string content = await File.ReadAllTextAsync(path);
            var beers = JsonSerializer.Deserialize<List<Beer>>(content);
            return beers; 
        }

    }
}
