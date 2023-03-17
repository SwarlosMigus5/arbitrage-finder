// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetRepository.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Infrastructure.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using ArbitrageFinder.Domain.AggregateModels.Bet;
    using ArbitrageFinder.Domain.AggregateModels.Bet.Repository;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// <see cref="BetRepository"/>
    /// </summary>
    /// <seealso cref="GenericRepository{Bet}" />
    /// <seealso cref="IBetRepository" />
    internal class BetRepository : GenericRepository<Bet>, IBetRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public BetRepository(
                ArbitrageFinderDBContext context)
                : base(context)
        {
        }

        /// <summary>
        /// Gets the by filters asynchronous.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<IEnumerable<Bet>> GetByFiltersAsync(DateTime startDate, DateTime endDate, CancellationToken cancellationToken)
        {
            return await this.Entities.Where(bet =>
                bet.Date >= startDate &&
                bet.Date <= endDate)
                .ToListAsync(cancellationToken);
        }

        /// <summary>
        /// Gets the by game identifier asynchronous.
        /// </summary>
        /// <param name="gameId">The game identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<Bet> GetByGameIdAsync(Guid gameId, CancellationToken cancellationToken)
        {
            return await this.Entities.FirstOrDefaultAsync(bet => bet.GameId == gameId, cancellationToken);
        }
    }
}