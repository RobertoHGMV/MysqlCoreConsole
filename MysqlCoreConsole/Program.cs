using System;

namespace MysqlCoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Digite 1 para inserção ou 2 para leitura");
            var option = Console.ReadKey().KeyChar.ToString().ToLower();

            Console.WriteLine();

            if ("1" == option)
            {
                Repository.InsertData();
                Repository.PrintData();
            }
            else if ("2" == option)
                Repository.PrintData();

            Console.ReadKey();
            
            Console.WriteLine("Click para fechar");
            Console.ReadKey();
        }
    }
}
