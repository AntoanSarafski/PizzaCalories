using System;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string[] pizzaInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name = pizzaInfo[1];

            string[] doughInfo = Console.ReadLine().Split();

            string flourType = doughInfo[1];
            string bakingTechnique = doughInfo[2];
            int weight = int.Parse(doughInfo[3]);

            try
            {
                Dough dough = new Dough(flourType, bakingTechnique, weight);

                Pizza pizza = new Pizza(name, dough);

                string input = Console.ReadLine();
                while (input != "END")
                {
                    string[] toppingInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string toppingType = toppingInfo[1];
                    int toppingWeight = int.Parse(toppingInfo[2]);

                    Topping topping = new Topping(toppingType, toppingWeight);

                    pizza.AddTopping(topping);

                    input = Console.ReadLine();
                }

                Console.WriteLine($"{pizza.Name} - {pizza.Calories:F2} Calories.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
