using Greet;

using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc( ).AddJsonTranscoding( );
builder.Services.AddGrpcReflection( );
builder.Services.AddGrpcSwagger();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Hello gRPC transcoding", Version = "v1" });
});

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
});
app.MapGrpcService<GreeterService>( );

if (app.Environment.IsDevelopment())
{
    app.MapGrpcReflectionService();
}

app.Run( );
