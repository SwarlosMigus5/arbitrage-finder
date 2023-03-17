// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Dtos.Output.Bet
{
    using ArbitrageFinder.Domain.AggregateModels.Bet.Enum;

    /// <summary>
    /// <see cref="BetDto"/>
    /// </summary>
    public class BetDto
    {
        /// <summary>
        /// Gets or sets the game identifier.
        /// </summary>
        /// <value>
        /// The game identifier.
        /// </value>
        public Guid GameId { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public BetType Type { get; set; }

        /// <summary>
        /// Gets or sets the uu identifier.
        /// </summary>
        /// <value>
        /// The uu identifier.
        /// </value>
        public Guid UUId { get; set; }
    }
}