// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProfitCalculatorService.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// ProfitCalculatorService
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.Services.Bet.ProfitCalculatorService
{
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// <see cref="ProfitCalculatorService"/>
    /// </summary>
    /// <seealso cref="IProfitCalculatorService" />
    internal class ProfitCalculatorService : IProfitCalculatorService
    {
        /// <summary>
        /// The stake
        /// </summary>
        private const decimal Stake = 100M;

        /// <summary>
        /// Calculates the profit margin asynchronous.
        /// </summary>
        /// <param name="arbitragePercentage">The arbitrage percentage.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public Task<decimal> CalculateProfitMarginAsync(decimal arbitragePercentage, CancellationToken cancellationToken)
        {
            decimal profitMargin = (Stake / arbitragePercentage) - Stake;

            return Task.FromResult(profitMargin);
        }
    }
}