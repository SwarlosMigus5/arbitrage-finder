// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetEntityTypeConfiguration.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetEntityTypeConfiguration
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Infrastructure.EntityConfiguration
{
    using System;
    using ArbitrageFinder.Domain.AggregateModels.Bet;
    using ArbitrageFinder.Domain.AggregateModels.Bet.Enum;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// <see cref="BetEntityTypeConfiguration"/>
    /// </summary>
    /// <seealso cref="EntityTypeConfiguration{Bet}" />
    internal class BetEntityTypeConfiguration : EntityTypeConfiguration<Bet>
    {
        /// <summary>
        /// Gets the name of the table.
        /// </summary>
        /// <value>
        /// The name of the table.
        /// </value>
        protected override string TableName => "Bet";

        /// <summary>
        /// Configures the entity.
        /// </summary>
        /// <param name="builder">The builder.</param>
        protected override void ConfigureEntity(EntityTypeBuilder<Bet> builder)
        {
            builder.Property(f => f.GameId)
                .IsRequired();

            builder.Property(f => f.Date)
                .IsRequired();

            builder.Property(f => f.Type)
                .HasConversion(
                    v => v.ToString(),
                    v => (BetType)Enum.Parse(typeof(BetType), v))
                .HasMaxLength(20);

            builder.HasMany(f => f.Combinations);
        }
    }
}