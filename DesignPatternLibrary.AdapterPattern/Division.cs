using System;

namespace DesignPatternLibrary.AdapterPattern
{
    /// <summary>
    /// ufc division class
    /// THE TARGET CLASS
    /// </summary>
    public class Division
    {
        /// <summary>weight class</summary>
        protected WeightClass _weightClass;

        /// <summary>Division max weight</summary>
        protected float _upperWeightLimit;

        /// <summary>current champion</summary>
        protected string _champion;

        /// <summary>Division constructor</summary>
        /// <param name="weightClass">wieght class</param>
        public Division(WeightClass weightClass)
        {
            this._weightClass = weightClass;
        }

        /// <summary>
        /// displays weight class of division
        /// </summary>
        public virtual void Display()
        {
            Console.WriteLine("\nDivision: {0}", this._weightClass.ToString());
        }
    }
}
