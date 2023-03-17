// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Combination.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// Combination
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.AggregateModels.Bet
{
    using System.Collections.Generic;
    using ArbitrageFinder.Domain.SeedWork;

    /// <summary>
    /// <see cref="Combination"/>
    /// </summary>
    /// <seealso cref="EntityBase" />
    public class Combination : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Combination" /> class.
        /// </summary>
        /// <param name="v1Odd">The v1 odd.</param>
        /// <param name="xOdd">The x odd.</param>
        /// <param name="v2Odd">The v2 odd.</param>
        /// <param name="profitMargin">The profit margin.</param>
        internal Combination(Odd v1Odd, Odd xOdd, Odd v2Odd, decimal profitMargin)
            : this()
        {
            this.V1Odd = v1Odd;
            this.XOdd = xOdd;
            this.V2Odd = v2Odd;
            this.ProfitMargin = profitMargin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Combination"/> class.
        /// </summary>
        protected Combination()
        {
        }

        /// <summary>
        /// Gets or sets the profit margin.
        /// </summary>
        /// <value>
        /// The profit margin.
        /// </value>
        public decimal ProfitMargin { get; private set; }

        /// <summary>
        /// Gets the v1 odd.
        /// </summary>
        /// <value>
        /// The v1 odd.
        /// </value>
        public virtual Odd V1Odd { get; private set; }

        /// <summary>
        /// Gets the v2 odd.
        /// </summary>
        /// <value>
        /// The v2 odd.
        /// </value>
        public virtual Odd V2Odd { get; private set; }

        /// <summary>
        /// Gets the x odd.
        /// </summary>
        /// <value>
        /// The x odd.
        /// </value>
        public virtual Odd XOdd { get; private set; }

        /// <summary>
        /// Gets the atomic values.
        /// </summary>
        /// <returns></returns>
        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return this.UUId;
        }
    }
}