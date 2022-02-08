using System;
using System.Collections.Generic;
using System.Text;

namespace TesteAPI
{
    static class DesenharTela
    {
        public static void ImprimirTelaFundo()
        {
            List<string> cabecalho = new List<string>() { "Title: ", "Year: ", "Rated: ", "Released: ", "Genre: ", "Director: ", "Actors: ", "Plot: ", 
                "Language: ", "Country: ", "Adwars: ", "Poster: ", "Ratings: ", "Metascore: ", "imdbRating: ", "imdbdVotes: ", "imdbID: ", "Type: ", "DVD: ", "BoxOffice: ", "Production: ", "WebSite: ", "Response: "};
            Filmes filme = new Filmes();
 
            Console.Title = "Programa para Testar API";
            var cor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            for (int j = 0; j < 100; j++)
                Console.Write("=");
            Console.WriteLine("=");
            for (int i = 0; i < cabecalho.Count; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    if (j == 0)
                    {
                        Console.Write("|" + cabecalho[i]);
                        j += cabecalho[i].Length;
                    }
                    else if (j == 99)
                        Console.WriteLine("|");
                    else
                        Console.Write(" ");
                }
            }
            for (int i = 0; i < 100; i++)
                Console.Write("=");
            Console.WriteLine("=");
            Console.ForegroundColor = cor;
        }
        
    }
}
