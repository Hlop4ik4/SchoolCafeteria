using SchoolCafeteriaDatabaseImplement.Implements;
using SchoolCafeteriaContracts.ViewModels;
using Swashbuckle.AspNetCore.Swagger;
using System.Text.Json.Serialization;
using System.Text.Json;
using SchoolCefeteriaContracts.ViewModels;

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

app.MapPost("/DeleteUser", (int id) =>
{
    var userStorage = new UserStorage();

    userStorage.Delete(id);

    return Results.Ok();
})
    .WithName("DeleteUser")
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

app.MapPost("/DeleteGoods", (int id) =>
{
    var goodsStorage = new GoodsStorage();

    goodsStorage.Delete(id);

    return Results.Ok();
})
    .WithName("DeleteGoods")
    .WithOpenApi();

app.MapGet("/GetGoodsComposition", () =>
{
    var goodsCompositionStorage = new GoodsCompositionStorage();
    var list = goodsCompositionStorage.GetFullList();

    return Results.Ok(list);
})
    .WithName("GoodsCompositionList")
    .WithOpenApi();

app.MapPost("/CreateGoodsComposition", (GoodsCompositionViewModel request) =>
{
    var goodsCompositionStorage = new GoodsCompositionStorage();

    goodsCompositionStorage.Insert(request);

    return Results.Ok();
})
    .WithName("CreateGoodsComposition")
    .WithOpenApi();

app.MapPost("/DeleteGoodsComposition", (int id) =>
{
    var goodsCompositionStorage = new GoodsCompositionStorage();

    goodsCompositionStorage.Delete(id);

    return Results.Ok();
})
    .WithName("DeleteGoodsComposition")
    .WithOpenApi();

app.MapGet("/GetTechMapComposition", () =>
{
    var techMapCompositionStorage = new TechMapCompositionStorage();
    var list = techMapCompositionStorage.GetFullList();

    return Results.Ok(list);
})
    .WithName("TechMapCompositionList")
    .WithOpenApi();

app.MapPost("/CreateTechMapComposition", (TechMapCompositionViewModel request) =>
{
    var techMapCompositionStorage = new TechMapCompositionStorage();

    techMapCompositionStorage.Insert(request);

    return Results.Ok();
})
    .WithName("CreateTechMapComposition")
    .WithOpenApi();

app.MapPost("/DeleteTechMapComposition", (int id) =>
{
    var techMapCompositionStorage = new TechMapCompositionStorage();

    techMapCompositionStorage.Delete(id);

    return Results.Ok();
})
    .WithName("DeleteTechMapComposition")
    .WithOpenApi();

app.Run();

