﻿namespace Totten.Solution.Ragstore.WebApi.Mappers.StoreAggregation;

using AutoMapper;
using Totten.Solution.Ragstore.ApplicationService.Features.StoreAgregattion.Commons;
using Totten.Solution.Ragstore.ApplicationService.Features.StoreAgregattion.ResponseModels;
using Totten.Solution.Ragstore.Domain.Features.StoresAggregation.Vendings;

/// <summary>
/// 
/// </summary>
public class VendingStoreItemMappingProfile : Profile
{
    /// <summary>
    /// 
    /// </summary>
    public VendingStoreItemMappingProfile()
    {
        CreateMap<VendingStoreItemCommand, VendingStoreItem>()
            .ForMember(ds => ds.InfoCards, m => m.MapFrom(src => src.InfoCards))
            .ForMember(ds => ds.InfoOptions, m => m.MapFrom(src => src.InfoOptions));

        CreateMap<StoreItemResponseModel, StoreItemResponseModel>();
    }
}