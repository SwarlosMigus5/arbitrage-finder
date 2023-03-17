// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetBetByGameIdQuery.cs" company="Openvia">
//     Copyright (c) Openvia. All rights reserved.
// </copyright>
// <summary>
// GetBetByGameIdQuery
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Queries.Bet.GetBetByGameIdQuery
{
    using Domain.AggregateModels.Bet;
    using MediatR;

    /// <summary>
    /// <see cref="GetBetByGameIdQuery"/>
    /// </summary>
    /// <seealso cref="IRequest{Bet}" />
    public class GetBetByGameIdQuery : IRequest<Bet>
    {
        /// <summary>
        /// Gets or sets the game identifier.
        /// </summary>
        /// <value>
        /// The game identifier.
        /// </value>
        public Guid GameId { get; set; }
    }
}