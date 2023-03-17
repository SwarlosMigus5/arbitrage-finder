// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Bet.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// Bet
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.AggregateModels.Bet
{
    using System;
    using System.Collections.Generic;
    using ArbitrageFinder.Domain.AggregateModels.Bet.Enum;
    using ArbitrageFinder.Domain.SeedWork;

    /// <summary>
    ///   <see cref="Bet" />
    /// </summary>
    /// <seealso cref="EntityBase" />
    /// <seealso cref="IAggregateRoot" />
    public class Bet : EntityBase, IAggregateRoot
    {
        /// <summary>
        /// The combinations
        /// </summary>
        private readonly List<Combination> combinations;

        /// <summary>
        /// Initializes a new instance of the <see cref="Bet"/> class.
        /// </summary>
        /// <param name="gameId">The game identifier.</param>
        /// <param name="type">The type.</param>
        internal Bet(Guid gameId, BetType type)
            : this()
        {
            this.GameId = gameId;
            this.Type = type;
            this.Date = DateTime.UtcNow;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Bet"/> class.
        /// </summary>
        protected Bet()
        {
            this.combinations = new();
        }

        /// <summary>
        /// Gets the combinations.
        /// </summary>
        /// <value>
        /// The combinations.
        /// </value>
        public virtual IReadOnlyCollection<Combination> Combinations => this.combinations;

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the game identifier.
        /// </summary>
        /// <value>
        /// The game identifier.
        /// </value>
        public Guid GameId { get; set; }

        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public BetType Type { get; private set; }

        /// <summary>
        /// Adds the combination.
        /// </summary>
        /// <param name="combination">The combination.</param>
        /// <exception cref="ArgumentNullException">The Combination is null.</exception>
        public void AddCombination(Combination combination)
        {
            if (combination is null)
            {
                throw new ArgumentNullException("The Combination is null.");
            }

            this.combinations.Add(combination);
        }

        /// <summary>
        /// Gets the atomic values.
        /// </summary>
        /// <returns></returns>
        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return this.UUId;
        }
    }
}