// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CombinationRepository.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CombinationRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Infrastructure.Repository
{
    using ArbitrageFinder.Domain.AggregateModels.Bet;
    using ArbitrageFinder.Domain.AggregateModels.Bet.Repository;

    /// <summary>
    /// <see cref="CombinationRepository"/>
    /// </summary>
    /// <seealso cref="GenericRepository{Combination}" />
    /// <seealso cref="ICombinationRepository" />
    internal class CombinationRepository : GenericRepository<Combination>, ICombinationRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CombinationRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public CombinationRepository(
                ArbitrageFinderDBContext context)
                : base(context)
        {
        }
    }
}