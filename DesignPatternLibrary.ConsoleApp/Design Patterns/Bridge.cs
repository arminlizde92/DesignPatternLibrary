using DesignPatternLibrary.BridgePattern;

namespace DesignPatternLibrary.ConsoleApp.Design_Patterns
{
    /// <summary>
    /// static helper class for bridge pattern example
    /// </summary>
    public static class Bridge
    {
        /// <summary>
        /// shows example
        /// </summary>
        public static void ShowExample()
        {
            OrganizingFight organizingFight = new OrganizeTitleFight();
            organizingFight.MMAOrganization = new UFC();
            organizingFight.Organize();

            organizingFight = new OrganizeSpecialFight();
            organizingFight.MMAOrganization = new Bellator();
            organizingFight.Organize();
        }
    }
}
