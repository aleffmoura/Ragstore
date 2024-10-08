﻿namespace Totten.Solution.Ragstore.ApplicationService.Mappers.StoreAggregation;
using AutoMapper;
using Totten.Solution.Ragstore.ApplicationService.Features.StoreAgregattion.Commons;
using Totten.Solution.Ragstore.Domain.Features.StoresAggregation.Buyings;

/// <summary>
/// 
/// </summary>
public class BuyingStoreItemStoreMappingProfile : Profile
{
    /// <summary>
    /// 
    /// </summary>
    public BuyingStoreItemStoreMappingProfile()
    {
        CreateMap<BuyingStoreItemCommand, BuyingStoreItem>()
            .ForMember(ds => ds.CreatedAt, m => m.MapFrom(src => DateTime.Now))
            .ForMember(ds => ds.UpdatedAt, m => m.MapFrom(src => DateTime.Now));
    }
}