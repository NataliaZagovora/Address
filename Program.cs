using System;

namespace Address
{
    class Program
    {
        static void Main(string[] args)
        {
            Address Adr = new Address();
            Adr.inputAdress();
            Console.WriteLine("****************************************************");
            Adr.outputAdress();
        }
    }
}
