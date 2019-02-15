using System.ComponentModel;

namespace DesignPatternLibrary.BridgePattern
{
    /// <summary>
    /// Abstraction which represents an organizing fight
    /// is going to be organized.
    /// </summary>
    [Description("Abstraction participant")]
    public abstract class OrganizingFight
    {
        /// <summary>
        /// reference to the implementor
        /// </summary>
        public IMMAOrganization MMAOrganization;

        /// <summary>
        /// abastract method which organizes a fight
        /// </summary>
        public abstract void Organize();
    }
}
