namespace FactoryPattern
{
    class Vodka : IDrink
    {
        public string? Alcohol { get; set; }
        public string? Fruit { get; set; }

        public void Drink()
        {
            Console.WriteLine("I'm enjoying a wonderful shot of Vodka.");
        }
    }
}
