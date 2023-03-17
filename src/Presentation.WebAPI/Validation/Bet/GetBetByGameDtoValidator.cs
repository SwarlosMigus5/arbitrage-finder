// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetBetByGameDtoValidator.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetBetByGameDtoValidator
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Validation.Bet
{
    using ArbitrageFinder.Presentation.WebAPI.Dtos.Input.Bet;
    using FluentValidation;

    /// <summary>
    /// <see cref="GetBetByGameDtoValidator"/>
    /// </summary>
    /// <seealso cref="AbstractValidator{GetBetsByGameFilterDto}" />
    public class GetBetByGameDtoValidator : AbstractValidator<GetBetByGameIdDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetBetByGameDtoValidator"/> class.
        /// </summary>
        public GetBetByGameDtoValidator()
        {
            this.RuleFor(p => p.GameId)
                .NotEqual(Guid.Empty)
                    .WithMessage("The GameId shouldn't have the default value.");
        }
    }
}