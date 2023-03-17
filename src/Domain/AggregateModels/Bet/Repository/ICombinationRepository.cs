// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICombinationRepository.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// ICombinationRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.AggregateModels.Bet.Repository
{
    using ArbitrageFinder.Domain.AggregateModels.Bet;
    using ArbitrageFinder.Domain.SeedWork;

    /// <summary>
    /// <see cref="ICombinationRepository"/>
    /// </summary>
    /// <seealso cref="IRepository{Combination}" />
    public interface ICombinationRepository : IRepository<Combination>
    {
    }
}