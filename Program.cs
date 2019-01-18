using System;
using Newtonsoft.Json;

namespace firstcore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(JsonConvert.SerializeObject(args));
            Console.WriteLine("Hello From My Console App!");
        }
    }
}
