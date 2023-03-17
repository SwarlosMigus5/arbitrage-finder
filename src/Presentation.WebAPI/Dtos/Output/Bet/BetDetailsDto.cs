// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetDetailsDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetDetailsDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Dtos.Output.Bet
{
    using ArbitrageFinder.Domain.AggregateModels.Bet.Enum;

    /// <summary>
    /// <see cref="BetDetailsDto"/>
    /// </summary>
    public class BetDetailsDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetDetailsDto"/> class.
        /// </summary>
        public BetDetailsDto()
        {
            this.Combinations = new();
        }

        /// <summary>
        /// Gets or sets the combinations.
        /// </summary>
        /// <value>
        /// The combinations.
        /// </value>
        public List<CombinationDetailsDto> Combinations { get; set; }

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
        /// Gets or sets the UUID.
        /// </summary>
        /// <value>
        /// The UUID.
        /// </value>
        public Guid UUID { get; set; }
    }
}