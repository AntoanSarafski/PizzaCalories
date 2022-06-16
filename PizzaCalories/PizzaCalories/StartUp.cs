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
            string bakingTechnique = input[2];
            int weight = int.Parse(input[3]);

            Dough dough = new Dough(flourType, bakingTechnique, weight);

            Console.WriteLine(dough.Calories);
        }
    }
}
