using System;
using TesteAPIFake.Models;

namespace TesteAPIFake.Views
{
    static class DesenharTela
    {
        public static void ImprimirTelaFundo( UserResponse user)
        {
            var cor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            for (int j = 0; j <= 100; j++)
                Console.Write("=");
            Console.WriteLine(user);
            for (int i = 0; i < 100 ; i++)
                Console.Write("=");
            Console.WriteLine("=");
            Console.ForegroundColor = cor;
        }
    }
}
