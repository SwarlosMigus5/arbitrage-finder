// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CombinationEntityTypeConfiguration.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CombinationEntityTypeConfiguration
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Infrastructure.EntityConfiguration
{
    using ArbitrageFinder.Domain.AggregateModels.Bet;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// <see cref="CombinationEntityTypeConfiguration"/>
    /// </summary>
    /// <seealso cref="EntityTypeConfiguration{Combination}"/>
    internal class CombinationEntityTypeConfiguration : EntityTypeConfiguration<Combination>
    {
        /// <summary>
        /// Gets the name of the table.
        /// </summary>
        /// <value>The name of the table.</value>
        protected override string TableName => "Combination";

        /// <summary>
        /// Configures the entity.
        /// </summary>
        /// <param name="builder">The builder.</param>
        protected override void ConfigureEntity(EntityTypeBuilder<Combination> builder)
        {
            builder.Property(f => f.ProfitMargin)
                .IsRequired();

            builder.OwnsOne(p => p.V1Odd, b =>
            {
                b.Property(p => p.OddId)
                    .IsRequired();

                b.Property(p => p.BookmakerId)
                    .IsRequired();

                b.Property(p => p.RealOdd)
                    .IsRequired();

                b.Property(p => p.Type)
                    .IsRequired();
            });

            builder.OwnsOne(p => p.XOdd, b =>
            {
                b.Property(p => p.OddId)
                    .IsRequired();

                b.Property(p => p.BookmakerId)
                    .IsRequired();

                b.Property(p => p.RealOdd)
                    .IsRequired();

                b.Property(p => p.Type)
                    .IsRequired();
            });

            builder.OwnsOne(p => p.V2Odd, b =>
            {
                b.Property(p => p.OddId)
                    .IsRequired();

                b.Property(p => p.BookmakerId)
                    .IsRequired();

                b.Property(p => p.RealOdd)
                    .IsRequired();

                b.Property(p => p.Type)
                    .IsRequired();
            });
        }
    }
}