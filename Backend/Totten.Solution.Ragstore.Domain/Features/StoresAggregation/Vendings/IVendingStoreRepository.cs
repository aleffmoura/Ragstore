﻿namespace Totten.Solution.Ragstore.Domain.Features.StoresAggregation.Vendings;
using Totten.Solution.Ragstore.Domain.Bases;

public interface IVendingStoreRepository : IRepository<VendingStore, int>
{
    IQueryable<VendingStore> GetAll();
    VendingStore? GetByCharacterId(int id);
}