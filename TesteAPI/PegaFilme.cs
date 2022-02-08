using System;
using Refit;
namespace TesteAPI
{
    class PegaFilme
    {
        public static async void Busca(string filme)
        {
            var filmeClient = RestService.For<IFilmeAPIService>("http://www.omdbapi.com");
            var adress = await filmeClient.GetMovieAsync(filme);
            
        }
    }
}
