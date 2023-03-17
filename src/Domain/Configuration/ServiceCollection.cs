// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TeamBuilder.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// TeamBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.Configuration
{
    using ArbitrageFinder.Domain.AggregateModels.Bet.Builder.BetBuilder;
    using ArbitrageFinder.Domain.AggregateModels.Game.Builder.CombinationBuilder;
    using ArbitrageFinder.Domain.Services.Bet.ArbitrageCalculatorService;
    using ArbitrageFinder.Domain.Services.Bet.BetService;
    using ArbitrageFinder.Domain.Services.Bet.CombinationService;
    using ArbitrageFinder.Domain.Services.Bet.ProfitCalculatorService;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// <see cref="ServiceCollection"/>
    /// </summary>
    public static class ServiceCollection
    {
        /// <summary>
        /// Registers the domain services.
        /// </summary>
        /// <param name="services">The services.</param>
        public static void RegisterDomainServices(this IServiceCollection services)
        {
            services.AddScoped<ICombinationBuilder, CombinationBuilder>();

            services.AddScoped<IBetBuilder, BetBuilder>();

            services.AddScoped<IBetService, BetService>();

            services.AddScoped<ICombinationService, CombinationService>();

            services.AddScoped<IArbitrageCalculatorService, ArbitrageCalculatorService>();

            services.AddScoped<IProfitCalculatorService, ProfitCalculatorService>();
        }
    }
}