using SchoolCafeteriaDatabaseImplement.Implements;
using SchoolCafeteriaContracts.ViewModels;
using Swashbuckle.AspNetCore.Swagger;
using System.Text.Json.Serialization;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/GetUsers", () =>
{
    var userStorage = new UserStorage();
    var list = userStorage.GetFullList();

    return Results.Ok(list);
})
    .WithName("UserList")
    .WithOpenApi();

app.MapPost("/CreateUser", (UserViewModel request) =>
{
    var userStorage = new UserStorage();

    userStorage.Insert(request);

    return Results.Ok();
})
    .WithName("CreateUser")
    .WithOpenApi();

app.MapGet("/GetGoods", () =>
{
    var goodsStorage = new GoodsStorage();
    var list = goodsStorage.GetFullList();

    return Results.Ok(list);
})
    .WithName("GoodsList")
    .WithOpenApi();

app.MapPost("/CreateGoods", (GoodsViewModel request) =>
{
    var goodsStorage = new GoodsStorage();

    goodsStorage.Insert(request);

    return Results.Ok();
})
    .WithName("CreateGoods")
    .WithOpenApi();

app.Run();

