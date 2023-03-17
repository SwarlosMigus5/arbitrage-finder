// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetBetByBetIdDtoValidator.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetBetByBetIdDtoValidator
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Validation.Bet
{
    using ArbitrageFinder.Presentation.WebAPI.Dtos.Input.Bet;
    using FluentValidation;

    /// <summary>
    /// <see cref="GetBetByBetIdDtoValidator"/>
    /// </summary>
    /// <seealso cref="AbstractValidator{GetBetByBetIdDto}" />
    public class GetBetByBetIdDtoValidator : AbstractValidator<GetBetByBetIdDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetBetByBetIdDtoValidator"/> class.
        /// </summary>
        public GetBetByBetIdDtoValidator()
        {
            this.RuleFor(p => p.BetId)
                .NotEqual(Guid.Empty)
                    .WithMessage("The BetId shouldn't have the default value.");
        }
    }
}