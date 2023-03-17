// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetBetByBetIdQuery.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetBetByBetIdQuery
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Queries.Bet.GetBetByBetIdQuery
{
    using Domain.AggregateModels.Bet;
    using MediatR;

    /// <summary>
    /// <see cref="GetBetByBetIdQuery"/>
    /// </summary>
    /// <seealso cref="IRequest{Bet}" />
    public class GetBetByBetIdQuery : IRequest<Bet>
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