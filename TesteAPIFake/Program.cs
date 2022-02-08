using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TesteAPIFake.Models;
using TesteAPIFake.Views;

namespace TesteAPIFake
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                //prepara o endereço de dominio no httpclient
                Console.Title = "Programa para Testar API";
                HttpClient client = new HttpClient { BaseAddress = new Uri("https://jsonplaceholder.typicode.com/") };
                //descreve o subdominio utilizado
                var response = await client.GetAsync("users");
                var content = await response.Content.ReadAsStringAsync();
                //conversão do JSon lido em content de forma deserializada.
                UserResponse[] users = JsonConvert.DeserializeObject<UserResponse[]>(content);
                char cont = 's';
                while (cont == 's')
                {
                    Console.Write("Enter com Id number for search data: ");
                    int id = int.Parse(Console.ReadLine());
                    if (id > users.Length || id == 0)
                        Console.WriteLine("Não há dados para o Id solicitado!");
                    foreach (var item in users)
                    {
                        if (item.Id == id)
                            DesenharTela.ImprimirTelaFundo(item);
                    }
                    Console.WriteLine("Desenha continuar a pesquisa? (s/x)");
                    cont = char.Parse(Console.ReadLine());
                    Console.Clear();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Deu erro em algo!!!" + e.Message); ;
            }
        }
    }
}
