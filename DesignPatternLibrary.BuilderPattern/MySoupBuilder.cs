using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLibrary.BuilderPattern
{
    public class MySoupBuilder : SoupBuilder
    {
        public override void ApplyIngredients()
        {
            this.Soup.Ingredients = new List<string>()
                { "Onion", "Garlic", "Carrot", "Potatoes", "Petersilie", "Olive oil",
                    "Tomatoes", "Mushrooms", "Brussels sprouts", "Green Beans" };
        }

        public override void ApplyMeat()
        {
            this.Soup.Meat = MeatType.Veal | MeatType.BosnianSuhoMeso;
        }

        public override void ApplySpices()
        {
            this.Soup.Spices = new List<string>() { "Vegeta", "Pepper", "Habanero" };
        }

        public override void PrepareBread()
        {
            this.Soup.Bread = "Fresh bread";
        }
    }
}
