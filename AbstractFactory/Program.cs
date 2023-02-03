using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(new CocaColaFactory());

            client.Run();

        }
    }
}
