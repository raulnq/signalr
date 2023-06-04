using Microsoft.AspNetCore.SignalR.Client;

var connection = new HubConnectionBuilder()
    .WithUrl(new Uri("http://localhost:5194/chathub"))
    .WithAutomaticReconnect()
    .Build();

connection.On<string, string>("ReceiveMessage", (user, message) =>
{
    Console.WriteLine($"{user} says {message}");
});

try
{
    await connection.StartAsync();
    Console.WriteLine("SignalR Connected");
}
catch (Exception)
{
    Console.WriteLine("SignalR Error");
}

Console.WriteLine("Please enter user:");
var user = Console.ReadLine();

if (string.IsNullOrEmpty(user))
{
    return;
}

while (true)
{
    Console.WriteLine("Please enter message");
    var message = Console.ReadLine();
    if (string.IsNullOrEmpty(message))
    {
        break;
    }
    await connection.InvokeAsync("SendMessage", user, message);
}

Console.ReadLine();