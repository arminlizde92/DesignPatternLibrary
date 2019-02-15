using DesignPatternLibrary.BuilderPattern;

namespace DesignPatternLibrary.ConsoleApp.Design_Patterns
{
    /// <summary>
    /// static builder helper class
    /// </summary>
    public static class Builder
    {
        /// <summary>
        /// shows pattern example
        /// </summary>
        public static void ShowExample()
        {
            var beansoup = new SoupMasterChef(new BeanSoupBuilder());
            beansoup.DoTheSoupMagic();
            beansoup.GetSoup().Display();

            var mysoup = new SoupMasterChef(new MySoupBuilder());            
            mysoup.DoTheSoupMagic();
            mysoup.GetSoup().Display();
        }
    }
}
