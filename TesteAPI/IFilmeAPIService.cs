using Refit;
using System.Threading.Tasks;

namespace TesteAPI
{
    interface IFilmeAPIService
    {
        //FALTA A CHAVE DE ACESSO A API
        [Get("/?apikey=[Inception]&")]
        Task<Filmes> GetMovieAsync(string movie);
    }
}
