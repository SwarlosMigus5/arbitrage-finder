// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IBetRepository.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// IBetRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.AggregateModels.Bet.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using ArbitrageFinder.Domain.AggregateModels.Bet;
    using ArbitrageFinder.Domain.SeedWork;

    /// <summary>
    /// <see cref="IBetRepository"/>
    /// </summary>
    /// <seealso cref="IRepository{Bet}" />
    public interface IBetRepository : IRepository<Bet>
    {
        /// <summary>
        /// Gets the by filters asynchronous.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<IEnumerable<Bet>> GetByFiltersAsync(DateTime startDate, DateTime endDate, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the by game identifier asynchronous.
        /// </summary>
        /// <param name="gameId">The game identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<Bet> GetByGameIdAsync(Guid gameId, CancellationToken cancellationToken);
    }
}