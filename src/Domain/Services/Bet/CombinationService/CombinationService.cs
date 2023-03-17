// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CombinationService.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CombinationService
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.Services.Bet.CombinationService
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using ArbitrageFinder.Domain.AggregateModels.Bet;
    using ArbitrageFinder.Domain.AggregateModels.Bet.Enum;
    using ArbitrageFinder.Domain.AggregateModels.Game.Builder.CombinationBuilder;
    using ArbitrageFinder.Domain.Services.Bet.ArbitrageCalculatorService;
    using ArbitrageFinder.Domain.Services.Bet.ProfitCalculatorService;

    /// <summary>
    /// <see cref="CombinationService"/>
    /// </summary>
    /// <seealso cref="ICombinationService"/>
    internal class CombinationService : ICombinationService
    {
        /// <summary>
        /// The arbitrage calculator service
        /// </summary>
        private readonly IArbitrageCalculatorService arbitrageCalculatorService;

        /// <summary>
        /// The combination builder
        /// </summary>
        private readonly ICombinationBuilder combinationBuilder;

        /// <summary>
        /// The profit calculator service
        /// </summary>
        private readonly IProfitCalculatorService profitCalculatorService;

        /// <summary>
        /// Initializes a new instance of the <see cref="CombinationService"/> class.
        /// </summary>
        /// <param name="arbitrageCalculatorService">The arbitrage calculator service.</param>
        /// <param name="combinationBuilder">The combination builder.</param>
        /// <param name="profitCalculatorService">The profit calculator service.</param>
        public CombinationService(
            IArbitrageCalculatorService arbitrageCalculatorService,
            ICombinationBuilder combinationBuilder,
            IProfitCalculatorService profitCalculatorService)
        {
            this.arbitrageCalculatorService = arbitrageCalculatorService;
            this.profitCalculatorService = profitCalculatorService;
            this.combinationBuilder = combinationBuilder;
        }

        /// <summary>
        /// Calculates the combinations asynchronous.
        /// </summary>
        /// <param name="odds">The odds.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<IEnumerable<Combination>> CalculateCombinationsAsync(List<Odd> odds, CancellationToken cancellationToken)
        {
            List<Odd> teamAOdds = odds
                .Where(odd => odd.Type == OddType.V1)
                .ToList();

            List<Odd> teamBOdds = odds
                .Where(odd => odd.Type == OddType.V2)
                .ToList();

            List<Odd> drawOdds = odds
                .Where(odd => odd.Type is OddType.X)
                .ToList();

            if (drawOdds.Any())
            {
                return await this.Calculate3WayBetCombinationsAsync(teamAOdds, teamBOdds, drawOdds, cancellationToken);
            }

            return await this.Calculate2WayBetCombinationsAsync(teamAOdds, teamBOdds, cancellationToken);
        }

        /// <summary>
        /// Calculate2s the way bet combinations asynchronous.
        /// </summary>
        /// <param name="teamAOdds">The team a odds.</param>
        /// <param name="teamBOdds">The team b odds.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        private async Task<IEnumerable<Combination>> Calculate2WayBetCombinationsAsync(List<Odd> teamAOdds, List<Odd> teamBOdds, CancellationToken cancellationToken)
        {
            List<Combination> combinations = new();

            foreach (Odd teamAOdd in teamAOdds)
            {
                foreach (Odd teamBOdd in teamBOdds)
                {
                    decimal arbitragePercentage = await this.arbitrageCalculatorService.Calculate2WayBetArbitragePercentageAsync(teamAOdd, teamBOdd, cancellationToken);

                    decimal profitMargin = await this.profitCalculatorService.CalculateProfitMarginAsync(arbitragePercentage, cancellationToken);

                    if (profitMargin > 0)
                    {
                        this.CreateCombination(combinations, teamAOdd, teamBOdd, null, profitMargin);
                    }
                }
            }

            return combinations;
        }

        /// <summary>
        /// Calculate3s the way bet combinations asynchronous.
        /// </summary>
        /// <param name="teamAOdds">The team a odds.</param>
        /// <param name="teamBOdds">The team b odds.</param>
        /// <param name="drawOdds">The draw odds.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        private async Task<IEnumerable<Combination>> Calculate3WayBetCombinationsAsync(List<Odd> teamAOdds, List<Odd> teamBOdds, List<Odd> drawOdds, CancellationToken cancellationToken)
        {
            List<Combination> combinations = new();

            foreach (Odd teamAOdd in teamAOdds)
            {
                foreach (Odd teamBOdd in teamBOdds)
                {
                    foreach (Odd drawOdd in drawOdds)
                    {
                        decimal arbitragePercentage = await this.arbitrageCalculatorService.Calculate3WayBetArbitragePercentageAsync(teamAOdd, teamBOdd, drawOdd, cancellationToken);

                        decimal profitMargin = await this.profitCalculatorService.CalculateProfitMarginAsync(arbitragePercentage, cancellationToken);

                        if (profitMargin > 0)
                        {
                            this.CreateCombination(combinations, teamAOdd, teamBOdd, drawOdd, profitMargin);
                        }
                    }
                }
            }

            return combinations;
        }

        /// <summary>
        /// Creates the combination.
        /// </summary>
        /// <param name="combinations">The combinations.</param>
        /// <param name="teamAOdd">The team a odd.</param>
        /// <param name="teamBOdd">The team b odd.</param>
        /// <param name="drawOdd">The draw odd.</param>
        /// <param name="profitMargin">The profit margin.</param>
        private void CreateCombination(List<Combination> combinations, Odd teamAOdd, Odd teamBOdd, Odd drawOdd, decimal profitMargin)
        {
            Combination combination = this.combinationBuilder
                .NewCombination(teamAOdd, drawOdd, teamBOdd, profitMargin)
                .Build();

            combinations.Add(combination);
        }
    }
}