﻿namespace Totten.Solution.Ragstore.ApplicationService.Features.Callbacks.Commands;

using MediatR;
using System;
using Totten.Solution.Ragstore.Domain.Features.Callbacks;
using Totten.Solution.Ragstore.Infra.Cross.Functionals;
using Unit = Infra.Cross.Functionals.Unit;

public class CallbackSaveCommand : IRequest<Result<Exception, Unit>>
{
    public string Name { get; set; } = string.Empty;
    public string UserId { get; set; } = string.Empty;
    public string Server { get; set; } = string.Empty;
    public string UserCellphone { get; set; } = string.Empty;
    public Dictionary<string, double> Items { get; set; } = new Dictionary<string, double>();
    public ECallbackType Level { get; set; }
}