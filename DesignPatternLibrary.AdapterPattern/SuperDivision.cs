using System;

namespace DesignPatternLibrary.AdapterPattern
{
    /// <summary>
    /// the adapter class
    /// </summary>
    public class SuperDivision : Division
    {
        /// <summary>
        /// private intance of <see cref="DivisionDatabank"/>
        /// </summary>
        private DivisionDatabank _bank;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="weightClass">weightClass</param>
        public SuperDivision(WeightClass weightClass)
            : base(weightClass)
        {
        }

        public override void Display()
        {
            _bank = new DivisionDatabank();
            _champion = _bank.GetDivisionChampion(this._weightClass);
            _upperWeightLimit = _bank.GetDivisionWeightClass(this._weightClass);

            base.Display();
            Console.WriteLine(" Upper weight limit: {0}", _upperWeightLimit);
            Console.WriteLine(" Champion: {0}", _champion);
        }
    }
}
