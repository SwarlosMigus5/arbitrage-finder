// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IBetService.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// IBetService
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.Services.Bet.BetService
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using ArbitrageFinder.Domain.AggregateModels.Bet;
    using ArbitrageFinder.Domain.AggregateModels.Bet.Enum;

    /// <summary>
    /// <see cref="IBetService"/>
    /// </summary>
    public interface IBetService
    {
        /// <summary>
        /// Gets the bet type asynchronous.
        /// </summary>
        /// <param name="odds">The odds.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<BetType> GetBetTypeAsync(List<Odd> odds, CancellationToken cancellationToken);
    }
}