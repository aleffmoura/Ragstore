﻿namespace Totten.Solution.Ragstore.Domain.Features.StoresAggregation.Buyings;
using Totten.Solution.Ragstore.Domain.Features.StoresAggregation.Bases;

public class BuyingStoreItem : StoreItem<BuyingStoreItem>
{
    public int BuyingStoreId { get; set; }
    public virtual BuyingStore BuyingStore { get; set; }
}