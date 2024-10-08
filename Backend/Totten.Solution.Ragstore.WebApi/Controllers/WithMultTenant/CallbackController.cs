﻿namespace Totten.Solution.Ragstore.WebApi.Controllers.WithMultTenant;

using Autofac;
using FunctionalConcepts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Totten.Solution.Ragstore.ApplicationService.Features.Callbacks.Commands;
using Totten.Solution.Ragstore.ApplicationService.Features.ItemsAggregation.Queries;
using Totten.Solution.Ragstore.ApplicationService.ViewModels.Items;
using Totten.Solution.Ragstore.Domain.Features.CallbackAggregation;
using Totten.Solution.Ragstore.Infra.Cross.CrossDTOs;
using Totten.Solution.Ragstore.WebApi.Bases;
using Totten.Solution.Ragstore.WebApi.Dtos.Callbacks;

/// <summary>
/// Endpoint responsavel por notificações de items com baixos valores.
/// </summary>
[ApiController]
public class CallbackController : BaseApiController
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="lifetimeScope"></param>
    public CallbackController(ILifetimeScope lifetimeScope) : base(lifetimeScope)
    {
    }

    /// <summary>
    /// Busca todas as notificações do servidor.
    /// </summary>
    /// <param name="server">Servidor</param>
    /// <param name="queryOptions">Filtro Dinamico</param>
    /// <returns></returns>
    [HttpGet("{server}/callbacks")]
    [ProducesResponseType<IQueryable<ItemResumeViewModel>>(statusCode: 200)]
    public async Task<IActionResult> Get([FromRoute] string server, ODataQueryOptions<ItemResumeViewModel> queryOptions)
        => await HandleQueryable(new CallbackCollectionQuery(), server, queryOptions);

    /// <summary>
    /// Busca todas as notificações do usuário no servidor especificado.
    /// </summary>
    /// <param name="server">Servidor</param>
    /// <param name="queryOptions">Filtro Dinamico</param>
    /// <returns></returns>
    [HttpGet("{server}/callbacks-user")]
    [ProducesResponseType<IQueryable<Callback>>(statusCode: 200)]
    public async Task<IActionResult> GetUsers([FromRoute] string server, ODataQueryOptions<Callback> queryOptions)
        => await HandleQueryable(new CallbackCollectionByUserIdQuery
        {
            UserId = "d7aeb595-44a5-4f5d-822e-980f35ace12d"
        }, server, queryOptions);

    /// <summary>
    /// Cria uma notificação no servidor especificado.
    /// </summary>
    /// <param name="server">Servidor</param>
    /// <param name="createDto">Objeto de criação de notificação</param>
    /// <returns></returns>
    [HttpPost("{server}/callbacks-items")]
    [ProducesResponseType<Success>(statusCode: 200)]
    public async Task<IActionResult> PostItems([FromRoute] string server, [FromBody] CallbackCreateDto createDto)
        => await HandleCommand(_mapper.Map<CallbackSaveCommand>((createDto, new UserData
        {
            Id = $"d7aeb595-44a5-4f5d-822e-980f35ace12d",
            Email = "aleffmds@gmail.com",
            Cellphone = "+5584988633251",
            Level = EUserLevel.SYSTEM
        })), server);
}
