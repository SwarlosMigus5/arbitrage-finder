// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IProfitCalculatorService.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// IProfitCalculatorService
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.Services.Bet.ProfitCalculatorService
{
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// <see cref="IProfitCalculatorService"/>
    /// </summary>
    public interface IProfitCalculatorService
    {
        /// <summary>
        /// Calculates the profit margin asynchronous.
        /// </summary>
        /// <param name="arbitragePercentage">The arbitrage percentage.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<decimal> CalculateProfitMarginAsync(decimal arbitragePercentage, CancellationToken cancellationToken);
    }
}