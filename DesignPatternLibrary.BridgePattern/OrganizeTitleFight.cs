 using System.ComponentModel;

namespace DesignPatternLibrary.BridgePattern
{
    /// <summary>
    /// organizing title fight
    /// </summary>
    [Description("Redifined abstraction")]
    public class OrganizeTitleFight : OrganizingFight
    {
        /// <summary>
        /// implementation of the organize method
        /// </summary>
        public override void Organize()
        {
            MMAOrganization.OrganizeFight("Khabib THE EAGEL Nurmagomedov", "Conor THE NOTORIOUS McGregor");
        }
    }
}
