// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CombinationBuilder.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CombinationBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.AggregateModels.Game.Builder.CombinationBuilder
{
    using ArbitrageFinder.Domain.AggregateModels.Bet;

    /// <summary>
    /// <see cref="CombinationBuilder"/>
    /// </summary>
    /// <seealso cref="ICombinationBuilder" />
    internal class CombinationBuilder : ICombinationBuilder
    {
        /// <summary>
        /// The combination
        /// </summary>
        private Combination combination;

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        public Combination Build()
        {
            return this.combination;
        }

        /// <summary>
        /// Creates new combination.
        /// </summary>
        /// <param name="v1Odd">The v1 odd.</param>
        /// <param name="xOdd">The x odd.</param>
        /// <param name="v2Odd">The v2 odd.</param>
        /// <param name="profitMargin">The profit margin.</param>
        /// <returns></returns>
        public ICombinationBuilder NewCombination(Odd v1Odd, Odd xOdd, Odd v2Odd, decimal profitMargin)
        {
            this.combination = new(v1Odd, xOdd, v2Odd, profitMargin);

            return this;
        }
    }
}