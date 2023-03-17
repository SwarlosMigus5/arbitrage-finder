// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetController.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetController
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Controllers
{
    using System.Net;
    using ArbitrageFinder.Domain.AggregateModels.Bet;
    using ArbitrageFinder.Presentation.WebAPI.Command.Bet.CalculateBetByGameIdCommand;
    using ArbitrageFinder.Presentation.WebAPI.Dtos.Input.Bet;
    using ArbitrageFinder.Presentation.WebAPI.Dtos.Output.Bet;
    using ArbitrageFinder.Presentation.WebAPI.Queries.Bet.GetBetByBetIdQuery;
    using ArbitrageFinder.Presentation.WebAPI.Queries.Bet.GetBetByGameIdQuery;
    using ArbitrageFinder.Presentation.WebAPI.Queries.Bet.GetBetsByFilterQuery;
    using ArbitrageFinder.Presentation.WebAPI.Utils;
    using AutoMapper;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// <see cref="BetController"/>
    /// </summary>
    /// <seealso cref="Controller"/>
    [ApiController]
    [Route("api/v1")]
    public class BetController : Controller
    {
        /// <summary>
        /// The mapper
        /// </summary>
        private readonly IMapper mapper;

        /// <summary>
        /// The mediator
        /// </summary>
        private readonly IMediator mediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="BetController"/> class.
        /// </summary>
        /// <param name="mapper">The mapper.</param>
        /// <param name="mediator">The mediator.</param>
        public BetController(
            IMapper mapper,
            IMediator mediator)
        {
            this.mapper = mapper;
            this.mediator = mediator;
        }

        /// <summary>
        /// Calculates the bet by game identifier asynchronous.
        /// </summary>
        /// <param name="calculateBetDto">The calculate bet dto.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("Game/{GameId}/Bet")]
        [ProducesResponseType(typeof(BetDetailsDto), (int)HttpStatusCode.Created)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> CalculateBetByGameIdAsync([FromRoute] CalculateBetByGameIdDto calculateBetDto, CancellationToken cancellationToken)
        {
            Bet bet = await this.mediator.Send(new CalculateBetByGameIdCommand
            {
                GameId = calculateBetDto.GameId,
            }, cancellationToken);

            return this.Created(string.Empty, this.mapper.Map<BetDetailsDto>(bet));
        }

        /// <summary>
        /// Gets the by bet identifier asynchronous.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("Bet/{BetId}")]
        [ProducesResponseType(typeof(BetDetailsDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetByBetIdAsync([FromRoute] GetBetByBetIdDto filter, CancellationToken cancellationToken)
        {
            Bet bet = await this.mediator.Send(new GetBetByBetIdQuery
            {
                BetId = filter.BetId
            }, cancellationToken);

            return this.Ok(this.mapper.Map<BetDetailsDto>(bet));
        }

        /// <summary>
        /// Gets the by filter asynchronous.
        /// </summary>
        /// <param name="filters">The filters.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("Bet")]
        [ProducesResponseType(typeof(IEnumerable<BetDto>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetByFilterAsync([FromQuery] GetBetsByFilterDto filters, CancellationToken cancellationToken)
        {
            IEnumerable<Bet> bets = await this.mediator.Send(new GetBetsByFilterQuery
            {
                EndDate = filters.EndDate,
                StartDate = filters.StartDate,
            }, cancellationToken);

            return this.Ok(this.mapper.Map<IEnumerable<BetDto>>(bets));
        }

        /// <summary>
        /// Gets the by game asynchronous.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("Game/{GameId}/Bet")]
        [ProducesResponseType(typeof(BetDetailsDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetByGameIdAsync([FromRoute] GetBetByGameIdDto filter, CancellationToken cancellationToken)
        {
            Bet bet = await this.mediator.Send(new GetBetByGameIdQuery
            {
                GameId = filter.GameId,
            }, cancellationToken);

            return this.Ok(this.mapper.Map<BetDetailsDto>(bet));
        }
    }
}