// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetType.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetType
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ArbitrageFinder.Domain.AggregateModels.Bet.Enum
{
    /// <summary>
    /// <see cref="BetType"/>
    /// </summary>
    public enum BetType
    {
        /// <summary>
        /// The unknown
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// The two way bet
        /// </summary>
        TwoWayBet = 1,

        /// <summary>
        /// The three way bet
        /// </summary>
        ThreeWayBet = 2
    }
}