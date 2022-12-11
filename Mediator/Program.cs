using Mediator.Application;

ServiceEventSender messageSender = new();
SteamEventReciver messageReceiver = new();
EventsMediator eventsMediator = new(messageReceiver, messageSender);

messageSender.RaiseEvent("Json message for Steam");

eventsMediator.Dispose();

Console.WriteLine("Steam: " + messageReceiver.Message);
Console.ReadKey();