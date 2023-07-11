namespace FactoryPattern
{
    class DrinkFactory
    {
        public static IDrink CreateDrink(string userInput)
        {
            switch (userInput.ToLower())
            {
                case "Vodka":
                    return new Vodka() { Alcohol = "Vodka", Fruit = "Lime" };
                case "Bourbon":
                    return new Bourbon() { Alcohol = "Bourbon", Fruit = "Orange" };
                default:
                    return new Vodka();

            }

        }

    }
}
