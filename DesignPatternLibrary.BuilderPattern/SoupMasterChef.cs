using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLibrary.BuilderPattern
{
    public class SoupMasterChef
    {
        /// <summary>
        /// readonly instance of soupbuilder
        /// </summary>
        private readonly SoupBuilder _soupBuilder;

        /// <summary>
        /// constructor for supreMasterChef
        /// </summary>
        /// <param name="soupBuilder">instance of <see cref="SoupBuilder"/></param>
        public SoupMasterChef(SoupBuilder soupBuilder) => this._soupBuilder = soupBuilder;

        /// <summary>
        /// does the magic
        /// starts to builder
        /// </summary>
        public void DoTheSoupMagic()
        {
            _soupBuilder.BuildNewSoup();
            _soupBuilder.ApplyIngredients();
            _soupBuilder.ApplySpices();
            _soupBuilder.ApplyMeat();
            _soupBuilder.PrepareBread();
        }

        /// <summary>
        /// gets tje soup
        /// </summary>
        /// <returns>soup</returns>
        public Soup GetSoup() => _soupBuilder.GetSoup();
    }
}
