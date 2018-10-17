using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace Pokemon
{
    public class PokemonDb : IPokemonRepository
    {
        public string BaseURL { get; }
        public PokemonDb(string baseURL) 

        {
            BaseURL = baseURL;
        }

        public async Task<IEnumerable<APIPokemonList>> ListAll(string param)
        {
            IEnumerable<APIPokemonList> List = null;

            using (HttpClient client = new HttpClient() ) {

                client.BaseAddress = new Uri(BaseURL);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.GetAsync($"{BaseURL}{param}").Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string contents = await responseContent.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<RootObject>(contents);
                    List = result.results;
                }

                return List;
            }
        }

        public async Task<Pokemon> RetrievePokemon()
        {
            using (HttpClient client = new HttpClient())
            {
                Random rnd = new Random();
                string number = rnd.Next(1, 901).ToString();
                client.BaseAddress = new Uri(BaseURL);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                

                var response = client.GetAsync($"{BaseURL}/pokemon/{number}/").Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string contents = await responseContent.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<APIPokemon>(contents);
                    Pokemon randomPokemon = new Pokemon(result.name, result.stats[5].base_stat, result.stats[4].base_stat, result.stats[3].base_stat, PokemonType.Fire);
                    return randomPokemon;

                } else
                {
                    Console.WriteLine("Returning null");
                    return null;
                }

                
            }
        }

     
    }

    public class RootObject
    {
        public int count { get; set; }
        public object next { get; set; }
        public object previous { get; set; }
        public List<APIPokemonList> results { get; set; }

        
    }

}
