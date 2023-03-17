// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CalculateBetOddDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CalculateBetOddDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Dtos.Input.Bet
{
    using ArbitrageFinder.Domain.AggregateModels.Bet.Enum;

    /// <summary>
    /// <see cref="CalculateBetOddDto"/>
    /// </summary>
    public class CalculateBetOddDto
    {
        /// <summary>
        /// Gets or sets the bookmaker identifier.
        /// </summary>
        /// <value>The bookmaker identifier.</value>
        public Guid BookmakerId { get; init; }

        /// <summary>
        /// Gets or sets the odd identifier.
        /// </summary>
        /// <value>The odd identifier.</value>
        public Guid OddId { get; init; }

        /// <summary>
        /// Gets or sets the real odd.
        /// </summary>
        /// <value>The real odd.</value>
        public decimal RealOdd { get; init; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public OddType Type { get; init; }
    }
}