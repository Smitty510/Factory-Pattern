namespace FactoryPattern
{
    class Bourbon : IDrink
    {
        public string? Alcohol { get; set; }
        public string? Fruit { get; set; }

        public void Drink()
        {
            Console.WriteLine("This bourbon is off the chain!!");
        }




    }
}
