﻿namespace Totten.Solution.Ragstore.ApplicationService.Features.Items.Queries;

using MediatR;
using Totten.Solution.Ragstore.Domain.Features.Callbacks;
using Totten.Solution.Ragstore.Infra.Cross.Functionals;

public class CallbackCollectionQuery : IRequest<Result<Exception, List<Callback>>>
{
}