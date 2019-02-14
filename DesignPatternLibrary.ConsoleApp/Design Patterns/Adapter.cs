using DesignPatternLibrary.AdapterPattern;

namespace DesignPatternLibrary.ConsoleApp.Design_Patterns
{
    /// <summary>
    /// static class for adapter pattern
    /// </summary>
    public static class Adapter
    {
        /// <summary>
        /// shows example
        /// </summary>
        public static void ShowExample()
        {
            // Non-adapted division
            Division unkown = new Division(WeightClass.Unknown);
            unkown.Display();

            // Adapted division
            Division heavyWeight = new SuperDivision(WeightClass.Heavyweight);
            heavyWeight.Display();

            Division lightHeavyWeight = new SuperDivision(WeightClass.LightHeavyweight);
            lightHeavyWeight.Display();

            Division leightWeight = new SuperDivision(WeightClass.Lightweight);
            leightWeight.Display();
        }
    }
}
