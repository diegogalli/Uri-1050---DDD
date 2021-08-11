using System;

namespace DDD
{
    class Program
    {
        static void Main(string[] args)
        {
            int CODIGO;

            CODIGO = int.Parse(Console.ReadLine());

            if ( CODIGO == 61)
            {
                Console.WriteLine("Brasilia");
            }
            else if ( CODIGO == 71)
            {
                Console.WriteLine("Salvador");
            }
            else if ( CODIGO == 11)
            {
                Console.WriteLine("Sao Paulo");
            }
            else if ( CODIGO == 21)
            {
                Console.WriteLine("Rio de Janeiro");
            }
            else if ( CODIGO == 32)
            {
                Console.WriteLine("Juiz de Fora");
            }
            else if ( CODIGO == 19)
            {
                Console.WriteLine("Campinas");
            }
            else if (CODIGO == 27)
            {
                Console.WriteLine("Vitoria");
            }
            else if ( CODIGO == 31)
            {
                Console.WriteLine("Belo Horizonte");
            }
            else
            {
                Console.WriteLine("DDD nao cadastrado");
            }            
        }
    }
}
