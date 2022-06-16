using System;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string type = input[0];
            string flourType = input[1];
            //string bakingTechnique = input[2];
            int weight = int.Parse(input[2]);

            Topping dough = new Topping(flourType, weight);

            Console.WriteLine(dough.Calories);

        }
    }
}
