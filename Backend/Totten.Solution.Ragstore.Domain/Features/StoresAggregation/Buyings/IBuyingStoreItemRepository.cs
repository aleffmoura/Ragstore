﻿namespace Totten.Solution.Ragstore.Domain.Features.StoresAggregation.Buyings;
using Totten.Solution.Ragstore.Domain.Bases;
using Totten.Solution.Ragstore.Infra.Cross.Functionals;
using CharacterId = int;
using Item = string;
using StoreId = int;

public interface IBuyingStoreItemRepository : IRepository<BuyingStoreItem, int>
{
    Task<Unit> DeleteAll(CharacterId id);
    IQueryable<BuyingStoreItem> GetAllByCharacterId(StoreId storeId);
    IQueryable<BuyingStoreItem> GetAllByItemName(Item name);
}