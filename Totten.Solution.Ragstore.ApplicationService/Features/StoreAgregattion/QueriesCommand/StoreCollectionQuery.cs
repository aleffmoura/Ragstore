﻿namespace Totten.Solution.Ragstore.ApplicationService.Features.StoreAgregattion.QueriesCommand;

using MediatR;
using Totten.Solution.Ragstore.Domain.Features.StoresAgreggation.Vendings;
using Totten.Solution.Ragstore.Infra.Cross.Functionals;

public class StoreCollectionQuery : IRequest<Result<Exception, List<VendingStore>>>
{

}