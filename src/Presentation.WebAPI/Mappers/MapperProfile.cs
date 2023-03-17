// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MapperProfile.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// MapperProfile
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Mappers
{
    using ArbitrageFinder.Domain.AggregateModels.Bet;
    using ArbitrageFinder.Presentation.WebAPI.Dtos.Input.Bet;
    using ArbitrageFinder.Presentation.WebAPI.Dtos.Output.Bet;
    using AutoMapper;

    /// <summary>
    /// <see cref="MapperProfile"/>
    /// </summary>
    /// <seealso cref="Profile"/>
    public class MapperProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapperProfile"/> class.
        /// </summary>
        public MapperProfile()
        {
            this.CreateMap<Bet, BetDto>();

            this.CreateMap<Bet, BetDetailsDto>();

            this.CreateMap<CalculateBetOddDto, Odd>();

            this.CreateMap<Odd, OddDetailsDto>();

            this.CreateMap<Combination, CombinationDetailsDto>()
                .ForMember(dest => dest.XOddId, src => src.MapFrom(p => p.XOdd.OddId))
                .ForMember(dest => dest.V2OddId, src => src.MapFrom(p => p.V2Odd.OddId))
                .ForMember(dest => dest.V1OddId, src => src.MapFrom(p => p.V1Odd.OddId));
        }
    }
}