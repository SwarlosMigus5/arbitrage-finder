// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetBetByBetIdDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetBetByBetIdDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Dtos.Input.Bet
{
    /// <summary>
    /// <see cref="GetBetByBetIdDto"/>
    /// </summary>
    public class GetBetByBetIdDto
    {
        /// <summary>
        /// Gets or sets the bet identifier.
        /// </summary>
        /// <value>
        /// The bet identifier.
        /// </value>
        public Guid BetId { get; set; }
    }
}