// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetBetsByFilterQueryHandler.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetBetsByFilterQueryHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Queries.Bet.GetBetsByFilterQuery
{
    using System.Threading;
    using System.Threading.Tasks;
    using ArbitrageFinder.Domain.AggregateModels.Bet.Repository;
    using Domain.AggregateModels.Bet;
    using MediatR;

    /// <summary>
    /// <see cref="GetBetsByFilterQueryHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{GetBetsByFilterQuery, IEnumerable{Bet}}" />
    public class GetBetsByFilterQueryHandler : IRequestHandler<GetBetsByFilterQuery, IEnumerable<Bet>>
    {
        /// <summary>
        /// The bet repository
        /// </summary>
        private readonly IBetRepository betRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBetsByFilterQueryHandler"/> class.
        /// </summary>
        /// <param name="betRepository">The bet repository.</param>
        public GetBetsByFilterQueryHandler(IBetRepository betRepository)
        {
            this.betRepository = betRepository;
        }

        /// <summary>
        /// Handles a request
        /// </summary>
        /// <param name="request">The request</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>
        /// Response from the request
        /// </returns>
        public async Task<IEnumerable<Bet>> Handle(GetBetsByFilterQuery request, CancellationToken cancellationToken)
        {
            return await this.betRepository.GetByFiltersAsync(request.StartDate, request.EndDate, cancellationToken);
        }
    }
}