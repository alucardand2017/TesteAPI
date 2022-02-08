using System;
using Refit;

namespace TesteAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sessao = true;
            while (sessao)
            {
                try
                {
                    DesenharTela.ImprimirTelaFundo();
                    Console.WriteLine("Digite o nome do filme:");
                    string filme = Console.ReadLine().ToString();
                    PegaFilme.Busca(filme);
                }
                catch (ApiException e)
                {
                    Console.WriteLine("Erro de comunicação com a API! - " + e.Message); ;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro desconhecido! - " + e.Message);
                }
                Console.WriteLine("Deseja continuar a sessao? (s/n)");
                char escolha = char.Parse(Console.ReadLine());
                if (escolha == 'n')
                    sessao = false;
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços!");
            Console.ReadLine();
        }
    }
}
