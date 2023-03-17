// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CombinationDetailsDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CombinationDetailsDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Dtos.Output.Bet
{
    /// <summary>
    /// <see cref="CombinationDetailsDto"/>
    /// </summary>
    public class CombinationDetailsDto
    {
        /// <summary>
        /// Gets or sets the profit margin.
        /// </summary>
        /// <value>
        /// The profit margin.
        /// </value>
        public decimal ProfitMargin { get; set; }

        /// <summary>
        /// Gets or sets the UUID.
        /// </summary>
        /// <value>
        /// The UUID.
        /// </value>
        public Guid UUID { get; set; }

        /// <summary>
        /// Gets or sets the v1 odd identifier.
        /// </summary>
        /// <value>
        /// The v1 odd identifier.
        /// </value>
        public Guid V1OddId { get; set; }

        /// <summary>
        /// Gets or sets the v2 odd identifier.
        /// </summary>
        /// <value>
        /// The v2 odd identifier.
        /// </value>
        public Guid V2OddId { get; set; }

        /// <summary>
        /// Gets or sets the x odd identifier.
        /// </summary>
        /// <value>
        /// The x odd identifier.
        /// </value>
        public Guid XOddId { get; set; }
    }
}