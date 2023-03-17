// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TeamBuilder.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// TeamBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Infrastructure.Configuration
{
    using ArbitrageFinder.Domain.AggregateModels.Bet.Repository;
    using ArbitrageFinder.Infrastructure.Repository;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// <see cref="ServiceCollection"/>
    /// </summary>
    public static class ServiceCollection
    {
        /// <summary>
        /// Registers the infrastructure services.
        /// </summary>
        /// <param name="services">The services.</param>
        public static void RegisterInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<ICombinationRepository, CombinationRepository>();

            services.AddScoped<IBetRepository, BetRepository>();
        }
    }
}