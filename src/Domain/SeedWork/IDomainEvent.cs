// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDomainEvent.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// IDomainEvent
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.SeedWork
{
    using MediatR;

    /// <summary>
    /// <see cref="IDomainEvent"/>
    /// </summary>
    /// <seealso cref="INotification"/>
    public interface IDomainEvent : INotification
    {
    }
}