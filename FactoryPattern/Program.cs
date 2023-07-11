namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What can I get you to drink? We are currently running a special on  Vodka and Bourbon");
            string userInput = Console.ReadLine();


            var drink = DrinkFactory.CreateDrink(userInput);

            drink.Drink();

            Console.WriteLine("Lets make another drink!");
            userInput = Console.ReadLine();
        }

    }
}

