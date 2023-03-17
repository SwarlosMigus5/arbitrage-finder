// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetBetsByFilterQuery.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetBetsByFilterQuery
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Queries.Bet.GetBetsByFilterQuery
{
    using Domain.AggregateModels.Bet;
    using MediatR;

    /// <summary>
    /// <see cref="GetBetsByFilterQuery"/>
    /// </summary>
    /// <seealso cref="IRequest{IEnumerable{Bet}}" />
    public class GetBetsByFilterQuery : IRequest<IEnumerable<Bet>>
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