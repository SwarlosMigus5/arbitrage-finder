// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetBetsByFilterDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetBetsByFilterDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Dtos.Input.Bet
{
    /// <summary>
    /// <see cref="GetBetsByFilterDto"/>
    /// </summary>
    public class GetBetsByFilterDto
    {
        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>
        /// The end date.
        /// </value>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>
        /// The start date.
        /// </value>
        public DateTime StartDate { get; set; }
    }
}