// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetBuilder.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.AggregateModels.Bet.Builder.BetBuilder
{
    using System;
    using System.Collections.Generic;
    using ArbitrageFinder.Domain.AggregateModels.Bet.Enum;

    /// <summary>
    /// <see cref="BetBuilder"/>
    /// </summary>
    /// <seealso cref="IBetBuilder" />
    internal class BetBuilder : IBetBuilder
    {
        /// <summary>
        /// The bet
        /// </summary>
        private Bet bet;

        /// <summary>
        /// Adds the combinations.
        /// </summary>
        /// <param name="combinations">The combinations.</param>
        /// <returns></returns>
        public IBetBuilder AddCombinations(List<Combination> combinations)
        {
            foreach (Combination combination in combinations)
            {
                this.bet.AddCombination(combination);
            }

            return this;
        }

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        public Bet Build()
        {
            return this.bet;
        }

        /// <summary>
        /// Creates new bet.
        /// </summary>
        /// <param name="gameId">The game identifier.</param>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public IBetBuilder NewBet(Guid gameId, BetType type)
        {
            this.bet = new(gameId, type);

            return this;
        }
    }
}