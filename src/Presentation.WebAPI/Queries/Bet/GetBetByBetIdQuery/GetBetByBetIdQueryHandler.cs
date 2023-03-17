// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetBetByBetIdQueryHandler.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetBetByBetIdQueryHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Queries.Bet.GetBetByBetIdQuery
{
    using System.Threading;
    using System.Threading.Tasks;
    using ArbitrageFinder.Domain.AggregateModels.Bet.Repository;
    using ArbitrageFinder.Domain.Exceptions;
    using Domain.AggregateModels.Bet;
    using MediatR;

    /// <summary>
    /// <see cref="GetBetByBetIdQueryHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{GetBetByBetIdQuery, Bet}" />
    public class GetBetByBetIdQueryHandler : IRequestHandler<GetBetByBetIdQuery, Bet>
    {
        /// <summary>
        /// The bet repository
        /// </summary>
        private readonly IBetRepository betRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBetByBetIdQueryHandler"/> class.
        /// </summary>
        /// <param name="betRepository">The bet repository.</param>
        public GetBetByBetIdQueryHandler(IBetRepository betRepository)
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
        /// <exception cref="NotFoundException">The bet with id {request.BetId} wasn't found.</exception>
        public async Task<Bet> Handle(GetBetByBetIdQuery request, CancellationToken cancellationToken)
        {
            Bet bet = await this.betRepository.GetAsync(request.BetId, cancellationToken);

            if (bet is null)
            {
                throw new NotFoundException($"The bet with id {request.BetId} wasn't found.");
            }

            return bet;
        }
    }
}