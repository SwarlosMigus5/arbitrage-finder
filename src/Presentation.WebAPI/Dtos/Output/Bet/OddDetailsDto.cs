// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OddDetailsDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// OddDetailsDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Dtos.Output.Bet
{
    using ArbitrageFinder.Domain.AggregateModels.Bet.Enum;

    /// <summary>
    /// <see cref="OddDetailsDto"/>
    /// </summary>
    public class OddDetailsDto
    {
        /// <summary>
        /// Gets the bookmaker identifier.
        /// </summary>
        /// <value>The bookmaker identifier.</value>
        public Guid BookmakerId { get; init; }

        /// <summary>
        /// Gets the odd identifier.
        /// </summary>
        /// <value>The odd identifier.</value>
        public Guid OddId { get; init; }

        /// <summary>
        /// Gets the real odd.
        /// </summary>
        /// <value>The real odd.</value>
        public decimal RealOdd { get; init; }

        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <value>The type.</value>
        public OddType Type { get; init; }
    }
}