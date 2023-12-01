using BasicSecurityASP.Models;
using System.Text.Json;

namespace BasicSecurityASP.Services
{
    public class BeerService : IBeerService
    {
        string path = @"C:\Users\diego\projects\asp.net\source\BasicSecurityASP\beers.json";

        public async Task<List<Beer>> GetBeers()
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = await r.ReadToEndAsync();
                List<Beer> beers = JsonSerializer.Deserialize<List<Beer>>(json);
                return beers;
            }
        }

    }
}
