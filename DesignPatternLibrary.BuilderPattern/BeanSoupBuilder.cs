using System;
using System.Collections.Generic;

namespace DesignPatternLibrary.BuilderPattern
{
    public class BeanSoupBuilder : SoupBuilder
    {
        public override void ApplyIngredients()
        {
            this.Soup.Ingredients = new List<string>()
            {
                "Onion",
                "Garlic",
                "Carrot",
                "Beans",
                "Petersilie",
                "Olive oil"
            };
        }

        public override void ApplyMeat()
        {
            this.Soup.Meat = MeatType.BosnianSudzuk | MeatType.BosnianSuhoMeso;
        }

        public override void ApplySpices()
        {
            this.Soup.Spices = new List<string>() { "Vegeta", "Pepper", "Habanero", "Paprika powder" };
        }

        public override void PrepareBread()
        {
            this.Soup.Bread = "Super fresh bread";
        }
    }
}
