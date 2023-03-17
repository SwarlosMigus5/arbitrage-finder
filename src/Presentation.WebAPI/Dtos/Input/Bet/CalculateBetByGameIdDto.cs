// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CalculateBetByGameIdDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CalculateBetByGameIdDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Dtos.Input.Bet
{
    /// <summary>
    /// <see cref="CalculateBetByGameIdDto"/>
    /// </summary>
    public class CalculateBetByGameIdDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculateBetByGameIdDto"/> class.
        /// </summary>
        public CalculateBetByGameIdDto()
        {
            this.Odds = new();
        }

        /// <summary>
        /// Gets or sets the game identifier.
        /// </summary>
        /// <value>The game identifier.</value>
        public Guid GameId { get; init; }

        /// <summary>
        /// Gets the odds.
        /// </summary>
        /// <value>The odds.</value>
        public List<CalculateBetOddDto> Odds { get; init; }
    }
}