namespace ConsoleApp1.Pizzas
{
    internal class ItalianPizza : Pizza
    {
        public ItalianPizza() : base("Italian pizza")
        { }

        public override int GetCost()
        {
            return 10;
        }

    }
}
