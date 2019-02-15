using System;
using System.Collections.Generic;

namespace DesignPatternLibrary.BuilderPattern
{
    /// <summary>
    /// soup class
    /// </summary>
    public class Soup
    {
        /// <summary>
        /// list of ingredients
        /// </summary>
        public List<string> Ingredients { get; set; }

        /// <summary>
        /// list of spices
        /// </summary>
        public List<string> Spices { get; internal set; }

        /// <summary>
        /// meat type
        /// </summary>
        public MeatType Meat { get; internal set; }

        /// <summary>
        /// bread
        /// </summary>
        public string Bread { get; internal set; }

        /// <summary>
        /// shows the soup proccess
        /// </summary>
        public void Display()
        {
            Console.WriteLine("=======================================================");
            Ingredients.ForEach(i => Console.WriteLine("{0}, ", i));
            Spices.ForEach(s => Console.WriteLine("{0}, ", s));

            // TODO: Implement getting seperate enum flags
            Console.WriteLine("Meat: {0}", Meat);
            Console.WriteLine("Bread: {0}", Bread);
        }
    }
}