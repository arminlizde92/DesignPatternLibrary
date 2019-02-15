using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLibrary.BuilderPattern
{
    /// <summary>
    /// soup builder class
    /// </summary>
    public abstract class SoupBuilder
    {
        /// <summary>
        /// instance of <see cref="Soup"/>
        /// </summary>
        protected Soup Soup;

        /// <summary>
        /// get soup method
        /// </summary>
        /// <returns>instance of <see cref="Soup"/></returns>
        public Soup GetSoup() => this.Soup;

        /// <summary>
        /// initiliazes soup instance
        /// </summary>
        public void BuildNewSoup() => this.Soup = new Soup();

        /// <summary>
        /// abstract method for preparing the bread
        /// </summary>
        public abstract void PrepareBread();

        /// <summary>
        /// abstract method for applying spices
        /// </summary>
        public abstract void ApplySpices();

        /// <summary>
        /// abstract method for applying meat
        /// </summary>
        public abstract void ApplyMeat();

        /// <summary>
        /// abstract method for applying ingredients
        /// </summary>
        public abstract void ApplyIngredients();
    }
}
