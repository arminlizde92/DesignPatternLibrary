namespace DesignPatternLibrary.AdapterPattern
{
    /// <summary>
    /// the 'Adaptee' class
    /// </summary>
    public class DivisionDatabank
    {
        /// <summary>
        /// return upper weight for a division
        /// </summary>
        /// <param name="weightClass">weight class</param>
        /// <returns>upper weight</returns>
        public float GetDivisionWeightClass(WeightClass weightClass)
        {
            switch (weightClass)
            {
                case WeightClass.Strawweight: return 52.2f;
                case WeightClass.Flyweight: return 56.7f;
                case WeightClass.Bantamweight: return 61.2f;
                case WeightClass.Featherweight: return 65.8f;
                case WeightClass.Lightweight: return 70.3f;
                case WeightClass.Welterweight: return 77.1f;
                case WeightClass.Middleweight: return 83.9f;
                case WeightClass.LightHeavyweight: return 93.0f;
                case WeightClass.Heavyweight: return 120.2f;
                default: return 0f;
            }
        }

        /// <summary>
        /// gets division champion
        /// </summary>
        /// <param name="weightClass">weight class</param>
        /// <returns>champion name</returns>
        public string GetDivisionChampion(WeightClass weightClass)
        {
            switch (weightClass)
            {
                case WeightClass.Flyweight: return "Henry Cejudo";
                case WeightClass.Bantamweight: return "TJ Dillashaw";
                case WeightClass.Featherweight: return "Max BLESSED Holloway";
                case WeightClass.Lightweight: return "Khabib THE EAGLE Nurmagomedov";
                case WeightClass.Welterweight: return "Tyron THE CHOSEN ONE Woodley";
                case WeightClass.Middleweight: return "Robert THE REAPER Whittaker";
                case WeightClass.LightHeavyweight: return "Jon BONES Jones";
                case WeightClass.Heavyweight: return "Daniel DC Cormier";
                default: return "";
            }
        }
    }
}
