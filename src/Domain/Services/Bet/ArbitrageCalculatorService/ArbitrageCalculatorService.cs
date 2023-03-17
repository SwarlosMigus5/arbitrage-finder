// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ArbitrageCalculatorService.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// ArbitrageCalculatorService
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.Services.Bet.ArbitrageCalculatorService
{
    using System.Threading;
    using System.Threading.Tasks;
    using ArbitrageFinder.Domain.AggregateModels.Bet;

    /// <summary>
    /// <see cref="ArbitrageCalculatorService"/>
    /// </summary>
    /// <seealso cref="IArbitrageCalculatorService"/>
    internal class ArbitrageCalculatorService : IArbitrageCalculatorService
    {
        /// <summary>
        /// The percentage
        /// </summary>
        private const decimal Percentage = 1M;

        /// <summary>
        /// Calculate2s the way bet arbitrage percentage asynchronous.
        /// </summary>
        /// <param name="teamAOdd">The team a odd.</param>
        /// <param name="teamBOdd">The team b odd.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public Task<decimal> Calculate2WayBetArbitragePercentageAsync(Odd teamAOdd, Odd teamBOdd, CancellationToken cancellationToken)
        {
            decimal teamAArbitrage = (Percentage / teamAOdd.RealOdd);

            decimal teamBArbitrage = (Percentage / teamBOdd.RealOdd);

            decimal totalArbitrage = teamAArbitrage + teamBArbitrage;

            return Task.FromResult(totalArbitrage);
        }

        /// <summary>
        /// Calculate3s the way bet arbitrage percentage asynchronous.
        /// </summary>
        /// <param name="teamAOdd">The team a odd.</param>
        /// <param name="teamBOdd">The team b odd.</param>
        /// <param name="drawOdd">The draw odd.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public Task<decimal> Calculate3WayBetArbitragePercentageAsync(Odd teamAOdd, Odd teamBOdd, Odd drawOdd, CancellationToken cancellationToken)
        {
            decimal teamAArbitrage = (Percentage / teamAOdd.RealOdd);

            decimal teamBArbitrage = (Percentage / teamBOdd.RealOdd);

            decimal drawArbitrage = (Percentage / drawOdd.RealOdd);

            decimal totalArbitrage = teamAArbitrage + teamBArbitrage + drawArbitrage;

            return Task.FromResult(totalArbitrage);
        }
    }
}