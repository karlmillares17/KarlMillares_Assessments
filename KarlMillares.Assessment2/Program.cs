using KarlMillares.Assessment2.AbstractFactory;
using KarlMillares.Assessment2.AbstractFactory.Implementation;
using KarlMillares.Assessment2.FacadePattern;
using KarlMillares.Assessment2.StrategyPattern;
using KarlMillares.Assessment2.StrategyPattern.Implementation;
using System;

namespace KarlMillares.Assessment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assessment # 2");
            Console.WriteLine("Abstract Factory Design Pattern");

            Console.WriteLine("Opening Factory Type");
            var client = new Client();
            client.ClientMethod(new SmartDevice());
            Console.WriteLine("");

            Console.WriteLine("Store Facade Design Pattern");
            var store = new StoreFacade();
            store.GetConsole();
            store.GetPackagedConsole();
            Console.WriteLine("");

            Console.WriteLine("Strategy Design Pattern");
            var generateItem = new GenerateItem();
            generateItem.SetStrategy(new Guids());
            generateItem.Generate();
            generateItem.SetStrategy(new Numbers());
            generateItem.Generate();

            Console.ReadLine();
        }
    }
}
