using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        
        private string flourType;
        private string bakingTechnique;
        private int weight;

        public Dough(string flourType , string bakingTechnique , int weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }


        public string FlourType
        {
            get 
            { 
                return flourType; 
            }
            private set 
            {
                if (!Helper.Modifier.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                flourType = value; 
            }
        }
        
        public string BakingTechnique
        {
            get 
            { 
                return bakingTechnique; 
            }
            private set 
            {
                if (!Helper.Modifier.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                bakingTechnique = value; 
            }
        }
        public int Weight
        {
            get
            {
                return weight;
            }
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }

        // Grams => Grams * 2 * modifiers


        public double Calories
            => 2 
            * this.Weight 
            * Helper.Modifier[FlourType.ToLower()] 
            * Helper.Modifier[BakingTechnique.ToLower()]; 

    }
}
