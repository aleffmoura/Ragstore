﻿namespace Totten.Solution.Ragstore.ApplicationService.Notifications.Callbacks.Handlers;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Totten.Solution.Ragstore.ApplicationService.Notifications.Messages;
using Totten.Solution.Ragstore.Domain.Features.CallbackAggregation;

public class CallbackNotificationHandler : INotificationHandler<CallbackNotification>
{
    private IMediator _mediator;
    private ICallbackScheduleRepository _callbackScheduleRepository;
    public CallbackNotificationHandler(IServiceProvider provider, ICallbackScheduleRepository callbackScheduleRepository)
    {
        _callbackScheduleRepository = callbackScheduleRepository;
        var scoped = provider.CreateScope();
        _mediator = scoped.ServiceProvider.GetService<IMediator>() ?? throw new Exception();
    }

    public async Task Handle(CallbackNotification notify, CancellationToken cancellationToken)
    {
        try
        {
            var message = new MessageNotification
            {
                Contact = notify.UserCellphone,
                Body = @$"RagnaStore, item: *{notify.ItemId}* em *{notify.Location}* por *{notify.Price}* servidor: {notify.Server}"
            };

            if (notify.Level is ECallbackType.AGENT or ECallbackType.SYSTEM)
            {
                _ = _mediator.Publish(message);
                return;
            }

            _ = await _callbackScheduleRepository.Save(new CallbackSchedule
            {
                Id = 0,
                Name = $"Server:{notify.Server}-ItemId:{notify.ItemId}-Price:{notify.Price}",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Contact = message.Contact,
                SendIn = DateTime.Now.AddMinutes(notify.Level.GetMinutesToSendMessage()),
                Body = message.Body
            });
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}