﻿namespace Totten.Solution.Ragstore.ApplicationService.Features.Callbacks.QueriesHandler;

using MediatR;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Totten.Solution.Ragstore.ApplicationService.Features.Items.Queries;
using Totten.Solution.Ragstore.Domain.Features.Callbacks;
using Totten.Solution.Ragstore.Infra.Cross.Functionals;

public class CallbackCollectionByUserIdQueryHandler : IRequestHandler<CallbackCollectionByUserIdQuery, Result<Exception, List<Callback>>>
{
    private ICallbackRepository _repository;

    public CallbackCollectionByUserIdQueryHandler(ICallbackRepository repository)
    {
        _repository = repository;
    }

    public async Task<Result<Exception, List<Callback>>> Handle(CallbackCollectionByUserIdQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetAllByUser(request.UserId);
    }
}