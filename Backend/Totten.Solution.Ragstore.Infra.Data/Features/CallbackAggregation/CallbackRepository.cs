﻿namespace Totten.Solution.Ragstore.Infra.Data.Features.CallbackAggregation;
using Totten.Solution.Ragstore.Domain.Features.CallbackAggregation;
using Totten.Solution.Ragstore.Infra.Data.Bases;
using Totten.Solution.Ragstore.Infra.Data.Contexts.RagnaStoreContexts;

public class CallbackRepository(RagnaStoreContext context)
    : RepositoryBase<Callback>(context), ICallbackRepository
{
}