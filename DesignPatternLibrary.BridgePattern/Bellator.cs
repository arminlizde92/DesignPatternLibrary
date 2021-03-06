﻿using System;
using System.ComponentModel;

namespace DesignPatternLibrary.BridgePattern
{
    /// <summary>
    /// Bellator organization, the concrete implementor participiant in this example
    /// </summary>
    [Description("Concrete implementor participiant")]
    public class Bellator : IMMAOrganization
    {
        /// <summary>
        /// Bellator fight organization method
        /// </summary>
        /// <param name="fighter1">fighter1</param>
        /// <param name="fighter2">fighter2</param>
        public void OrganizeFight(string fighter1, string fighter2)
        {
            Console.WriteLine("Bellator fight of the year {0} VS {1}", fighter1, fighter2);
        }
    }
}
