// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IArbitrageCalculatorService.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// IArbitrageCalculatorService
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.Services.Bet.ArbitrageCalculatorService
{
    using System.Threading;
    using System.Threading.Tasks;
    using ArbitrageFinder.Domain.AggregateModels.Bet;

    /// <summary>
    /// <see cref="IArbitrageCalculatorService"/>
    /// </summary>
    public interface IArbitrageCalculatorService
    {
        /// <summary>
        /// Calculate2s the way bet arbitrage percentage asynchronous.
        /// </summary>
        /// <param name="teamAOdd">The team a odd.</param>
        /// <param name="teamBOdd">The team b odd.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<decimal> Calculate2WayBetArbitragePercentageAsync(Odd teamAOdd, Odd teamBOdd, CancellationToken cancellationToken);

        /// <summary>
        /// Calculate3s the way bet arbitrage percentage asynchronous.
        /// </summary>
        /// <param name="teamAOdd">The team a odd.</param>
        /// <param name="teamBOdd">The team b odd.</param>
        /// <param name="drawOdd">The draw odd.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<decimal> Calculate3WayBetArbitragePercentageAsync(Odd teamAOdd, Odd teamBOdd, Odd drawOdd, CancellationToken cancellationToken);
    }
}