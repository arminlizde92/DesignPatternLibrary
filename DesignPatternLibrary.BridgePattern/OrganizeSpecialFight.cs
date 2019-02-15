using System.ComponentModel;

namespace DesignPatternLibrary.BridgePattern
{
    /// <summary>
    /// organizing special fights
    /// </summary>
    [Description("Redifined abstraction")]
    public class OrganizeSpecialFight : OrganizingFight
    {
        /// <summary>
        /// organizes fight
        /// </summary>
        public override void Organize()
        {
            MMAOrganization.OrganizeFight("Floyd MONEY Mayweather", "Conor THE NOTORIOUS McGregor");
        }
    }
}
