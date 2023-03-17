// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetBetByGameIdQueryHandler.cs" company="Openvia">
//     Copyright (c) Openvia. All rights reserved.
// </copyright>
// <summary>
// GetBetByGameIdQueryHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Queries.Bet.GetBetByGameIdQuery
{
    using System.Threading;
    using System.Threading.Tasks;
    using ArbitrageFinder.Domain.AggregateModels.Bet.Repository;
    using ArbitrageFinder.Domain.Exceptions;
    using Domain.AggregateModels.Bet;
    using MediatR;

    /// <summary>
    /// <see cref="GetBetByGameIdQueryHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{GetBetByGameIdQuery, Bet}" />
    public class GetBetByGameIdQueryHandler : IRequestHandler<GetBetByGameIdQuery, Bet>
    {
        /// <summary>
        /// The bet repository
        /// </summary>
        private readonly IBetRepository betRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBetByGameIdQueryHandler"/> class.
        /// </summary>
        /// <param name="betRepository">The bet repository.</param>
        public GetBetByGameIdQueryHandler(IBetRepository betRepository)
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
        /// <exception cref="NotFoundException">The bet for the game with id {request.GameId} wasn't found.</exception>
        public async Task<Bet> Handle(GetBetByGameIdQuery request, CancellationToken cancellationToken)
        {
            Bet bet = await this.betRepository.GetByGameIdAsync(request.GameId, cancellationToken);

            if (bet is null)
            {
                throw new NotFoundException($"The bet for the game with id {request.GameId} wasn't found.");
            }

            return bet;
        }
    }
}