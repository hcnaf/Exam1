using ConsoleApp1.PizzaDecorators;
using ConsoleApp1.Pizzas;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza1 = new ItalianPizza();
            pizza1 = new TomatoPizza(pizza1); // итальянская пицца с томатами
            Console.WriteLine("Name: {0}", pizza1.Name);
            Console.WriteLine("Cost: {0}", pizza1.GetCost());

            Pizza pizza2 = new ItalianPizza();
            pizza2 = new CheesePizza(pizza2);// итальянская пиццы с сыром
            Console.WriteLine("Name: {0}", pizza2.Name);
            Console.WriteLine("Cost: {0}", pizza2.GetCost());

            Pizza pizza3 = new BulgarialPizza();
            pizza3 = new TomatoPizza(pizza3);
            pizza3 = new CheesePizza(pizza3);// болгарская пиццы с томатами и сыром
            Console.WriteLine("Name: {0}", pizza3.Name);
            Console.WriteLine("Cost: {0}", pizza3.GetCost());
        }
    }
}
