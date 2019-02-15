using System.ComponentModel;

namespace DesignPatternLibrary.BridgePattern
{
    /// <summary>
    /// Implementor which defines an interface for a MMA organization
    /// </summary>
    [Description("Implementor")]
    public interface IMMAOrganization
    {
        /// <summary>
        /// organizes a fight
        /// </summary>
        /// <param name="fighter1">fighter name 1</param>
        /// <param name="fighter2">fighter name 2</param>
        void OrganizeFight(string fighter1, string fighter2);
    }
}
