// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CalculateBetByGameIdCommand.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CalculateBetByGameIdCommand
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Command.Bet.CalculateBetByGameIdCommand
{
    using ArbitrageFinder.Domain.AggregateModels.Bet;
    using ArbitrageFinder.Presentation.WebAPI.Dtos.Input.Bet;
    using MediatR;

    /// <summary>
    /// <see cref="CalculateBetByGameIdCommand"/>
    /// </summary>
    /// <seealso cref="IRequest{Bet}"/>
    public class CalculateBetByGameIdCommand : IRequest<Bet>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculateBetByGameIdCommand"/> class.
        /// </summary>
        public CalculateBetByGameIdCommand()
        {
            this.Odds = new();
        }

        /// <summary>
        /// Gets or sets the game identifier.
        /// </summary>
        /// <value>The game identifier.</value>
        public Guid GameId { get; set; }

        /// <summary>
        /// Gets or sets the odds.
        /// </summary>
        /// <value>The odds.</value>
        public List<CalculateBetOddDto> Odds { get; set; }
    }
}