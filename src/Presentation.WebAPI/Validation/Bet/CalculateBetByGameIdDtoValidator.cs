// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CalculateBetByGameIdDtoValidator.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CalculateBetByGameIdDtoValidator
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Validation.Bet
{
    using ArbitrageFinder.Presentation.WebAPI.Dtos.Input.Bet;
    using FluentValidation;

    /// <summary>
    /// <see cref="CalculateBetByGameIdDtoValidator"/>
    /// </summary>
    /// <seealso cref="AbstractValidator{CalculateBetByGameIdDto}" />
    public class CalculateBetByGameIdDtoValidator : AbstractValidator<CalculateBetByGameIdDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculateBetByGameIdDtoValidator"/> class.
        /// </summary>
        public CalculateBetByGameIdDtoValidator()
        {
            this.RuleFor(p => p.GameId)
                .NotEqual(Guid.Empty)
                    .WithMessage("The GameId shouldn't have the default value.");
        }
    }
}