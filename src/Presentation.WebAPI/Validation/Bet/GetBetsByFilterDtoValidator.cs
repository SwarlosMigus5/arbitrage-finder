// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetBetsByFilterDtoValidator.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetBetsByFilterDtoValidator
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Validation.Bet
{
    using ArbitrageFinder.Presentation.WebAPI.Dtos.Input.Bet;
    using FluentValidation;

    /// <summary>
    /// <see cref="GetBetsByFilterDtoValidator"/>
    /// </summary>
    /// <seealso cref="AbstractValidator{GetBetsByFilterDto}" />
    public class GetBetsByFilterDtoValidator : AbstractValidator<GetBetsByFilterDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetBetsByFilterDtoValidator"/> class.
        /// </summary>
        public GetBetsByFilterDtoValidator()
        {
            this.RuleFor(p => p.StartDate)
                .NotEqual(default(DateTime))
                    .WithMessage("The StartDate shouldn't have the default value.")
                .GreaterThan(p => p.EndDate)
                    .WithMessage("The StartDate shouldn't be higher than the EndDate.");

            this.RuleFor(p => p.EndDate)
                .NotEqual(default(DateTime))
                    .WithMessage("The EndDate shouldn't have the default value.")
                .LessThan(p => p.StartDate)
                    .WithMessage("The EndDate shouldn't be lower than the StartDate.");
        }
    }
}