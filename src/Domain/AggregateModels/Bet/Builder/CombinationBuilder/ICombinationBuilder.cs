// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICombinationBuilder.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// ICombinationBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.AggregateModels.Game.Builder.CombinationBuilder
{
    using ArbitrageFinder.Domain.AggregateModels.Bet;

    /// <summary>
    /// <see cref="ICombinationBuilder"/>
    /// </summary>
    public interface ICombinationBuilder
    {
        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        Combination Build();

        /// <summary>
        /// Creates new combination.
        /// </summary>
        /// <param name="v1Odd">The v1 odd.</param>
        /// <param name="xOdd">The x odd.</param>
        /// <param name="v2Odd">The v2 odd.</param>
        /// <param name="profitMargin">The profit margin.</param>
        /// <returns></returns>
        ICombinationBuilder NewCombination(Odd v1Odd, Odd xOdd, Odd v2Odd, decimal profitMargin);
    }
}