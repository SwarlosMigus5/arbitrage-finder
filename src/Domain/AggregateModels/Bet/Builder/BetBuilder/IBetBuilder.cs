// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IBetBuilder.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// IBetBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.AggregateModels.Bet.Builder.BetBuilder
{
    using System;
    using System.Collections.Generic;
    using ArbitrageFinder.Domain.AggregateModels.Bet.Enum;

    /// <summary>
    /// <see cref="IBetBuilder"/>
    /// </summary>
    public interface IBetBuilder
    {
        /// <summary>
        /// Adds the combinations.
        /// </summary>
        /// <param name="combinations">The combinations.</param>
        /// <returns></returns>
        IBetBuilder AddCombinations(List<Combination> combinations);

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        Bet Build();

        /// <summary>
        /// Creates new bet.
        /// </summary>
        /// <param name="gameId">The game identifier.</param>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        IBetBuilder NewBet(Guid gameId, BetType type);
    }
}