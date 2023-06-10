using WebAPI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddCors();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSignalR().AddStackExchangeRedis("<OUTPUT_REDIS_CONFIGURATION_ENDPOINT>:6379,ssl=True,abortConnect=False"); ;

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseCors(cp => cp
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true)
    .AllowCredentials()
);
app.MapHub<ChatHub>("/chathub");

app.MapControllers();

app.Run();
