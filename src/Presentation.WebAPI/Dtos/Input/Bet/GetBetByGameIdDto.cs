// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetBetByGameIdDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetBetByGameIdDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Dtos.Input.Bet
{
    /// <summary>
    /// <see cref="GetBetByGameIdDto"/>
    /// </summary>
    public class GetBetByGameIdDto
    {
        /// <summary>
        /// Gets or sets the game identifier.
        /// </summary>
        /// <value>The game identifier.</value>
        public Guid GameId { get; set; }
    }
}