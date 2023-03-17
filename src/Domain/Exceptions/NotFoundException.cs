// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotFoundException.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// NotFoundException
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// <see cref="NotFoundException"/>
    /// </summary>
    /// <seealso cref="ArbitrageFinderException"/>
    [Serializable]
    public sealed class NotFoundException : ArbitrageFinderException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotFoundException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public NotFoundException(string message)
            : base(message, (int)Exceptions.Enum.ErrorCode.NotFound)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotFoundException"/> class.
        /// </summary>
        /// <param name="info">
        /// The <see cref="T:System.Runtime.Serialization.SerializationInfo"/> that holds the
        /// serialized object data about the exception being thrown.
        /// </param>
        /// <param name="context">
        /// The <see cref="T:System.Runtime.Serialization.StreamingContext"/> that contains
        /// contextual information about the source or destination.
        /// </param>
        private NotFoundException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}