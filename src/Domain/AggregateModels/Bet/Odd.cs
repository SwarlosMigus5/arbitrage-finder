// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Odd.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// Odd
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.AggregateModels.Bet
{
    using System;
    using System.Collections.Generic;
    using ArbitrageFinder.Domain.AggregateModels.Bet.Enum;
    using ArbitrageFinder.Domain.SeedWork;

    /// <summary>
    /// <see cref="Odd"/>
    /// </summary>
    /// <seealso cref="ValueObject"/>
    public class Odd : ValueObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Odd"/> class.
        /// </summary>
        /// <param name="oddId">The odd identifier.</param>
        /// <param name="bookmakerId">The bookmaker identifier.</param>
        /// <param name="realOdd">The real odd.</param>
        /// <param name="type">The type.</param>
        public Odd(Guid oddId, Guid bookmakerId, decimal realOdd, OddType type)
        {
            this.OddId = oddId;
            this.BookmakerId = bookmakerId;
            this.RealOdd = realOdd;
            this.Type = type;
        }

        /// <summary>
        /// Gets or sets the bookmaker identifier.
        /// </summary>
        /// <value>The bookmaker identifier.</value>
        public Guid BookmakerId { get; set; }

        /// <summary>
        /// Gets or sets the odd identifier.
        /// </summary>
        /// <value>The odd identifier.</value>
        public Guid OddId { get; set; }

        /// <summary>
        /// Gets or sets the real odd.
        /// </summary>
        /// <value>The real odd.</value>
        public decimal RealOdd { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public OddType Type { get; set; }

        /// <summary>
        /// Gets the atomic values.
        /// </summary>
        /// <returns></returns>
        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return this.OddId;
            yield return this.BookmakerId;
        }
    }
}