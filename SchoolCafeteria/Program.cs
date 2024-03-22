using SchoolCafeteriaDatabaseImplement.Implements;
using SchoolCafeteriaContracts.ViewModels;
using Swashbuckle.AspNetCore.Swagger;
using System.Text.Json.Serialization;
using System.Text.Json;
using SchoolCefeteriaContracts.ViewModels;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.AllowAnyOrigin();
            policy.AllowAnyHeader();
            policy.AllowAnyMethod();
        });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.MapGet("/Users/Get", () =>
{
    var userStorage = new UserStorage();
    var list = userStorage.GetFullList();

    return Results.Ok(list);
})
    .WithName("UserList")
    .WithOpenApi();

app.MapPost("/Users/Create", (UserViewModel request) =>
{
    var userStorage = new UserStorage();

    userStorage.Insert(request);

    return Results.Ok();
})
    .WithName("CreateUser")
    .WithOpenApi();

app.MapPatch("/Users/Update", (UserViewModel request) =>
{
    var userStorage = new UserStorage();

    userStorage.Update(request);

    return Results.Ok();
})
    .WithName("UpdateUser")
    .WithOpenApi();

app.MapPost("/Users/Delete", (UserViewModel request) =>
{
    int idInt = Convert.ToInt32(request.Id);

    var userStorage = new UserStorage();

    userStorage.Delete(idInt);

    return Results.Ok();
})
    .WithName("DeleteUser")
    .WithOpenApi();

app.MapGet("/Goods/Get", () =>
{
    var goodsStorage = new GoodsStorage();
    var list = goodsStorage.GetFullList();

    return Results.Ok(list);
})
    .WithName("GoodsList")
    .WithOpenApi();

app.MapGet("/Goods/Get/{id}", ([FromRoute] int id) =>
{
    var goodsStorage = new GoodsStorage();
    var item = goodsStorage.GetElement(id);

    return Results.Ok(item);
})
    .WithName("GoodsItem")
    .WithOpenApi();

app.MapPost("/Goods/Create", (GoodsViewModel request) =>
{
    var goodsStorage = new GoodsStorage();

    goodsStorage.Insert(request);

    return Results.Ok();
})
    .WithName("CreateGoods")
    .WithOpenApi();

app.MapPatch("/Goods/Update", (GoodsViewModel request) =>
{
    var goodsStorage = new GoodsStorage();

    goodsStorage.Update(request);

    return Results.Ok();
})
    .WithName("UpdateGoods")
    .WithOpenApi();

app.MapPost("/Goods/Delete", (GoodsViewModel request) =>
{
    int idInt = Convert.ToInt32(request.Id);

    var goodsStorage = new GoodsStorage();

    goodsStorage.Delete(idInt);

    return Results.Ok();
})
    .WithName("DeleteGoods")
    .WithOpenApi();

app.MapGet("/GoodsComposition/Get", () =>
{
    var goodsCompositionStorage = new GoodsCompositionStorage();
    var list = goodsCompositionStorage.GetFullList();

    return Results.Ok(list);
})
    .WithName("GoodsCompositionList")
    .WithOpenApi();

app.MapGet("/GoodsComposition/Get/{goodsid}", ([FromRoute] int goodsid) =>
{
    var goodsCompositionStorage = new GoodsCompositionStorage();
    var item = goodsCompositionStorage.GetElementByGoodsId(goodsid);

    return Results.Ok(item);
})
    .WithName("GoodsCompositionItem")
    .WithOpenApi();

app.MapPost("/GoodsComposition/Create", (GoodsCompositionViewModel request) =>
{
    var goodsCompositionStorage = new GoodsCompositionStorage();

    goodsCompositionStorage.Insert(request);

    return Results.Ok();
})
    .WithName("CreateGoodsComposition")
    .WithOpenApi();

app.MapPatch("/GoodsComposition/Update", (GoodsCompositionViewModel request) =>
{
    var goodsCompositionStorage = new GoodsCompositionStorage();

    goodsCompositionStorage.Update(request);

    return Results.Ok();
})
    .WithName("UpdateGoodsComposition")
    .WithOpenApi();

app.MapPost("/GoodsComposition/Delete", (GoodsCompositionViewModel request) =>
{
    int idInt = Convert.ToInt32(request.Id);

    var goodsCompositionStorage = new GoodsCompositionStorage();

    goodsCompositionStorage.Delete(idInt);

    return Results.Ok();
})
    .WithName("DeleteGoodsComposition")
    .WithOpenApi();

app.MapGet("/TechMapComposition/Get", () =>
{
    var techMapCompositionStorage = new TechMapCompositionStorage();
    var list = techMapCompositionStorage.GetFullList();

    return Results.Ok(list);
})
    .WithName("TechMapCompositionList")
    .WithOpenApi();

app.MapGet("/TechMapComposition/Get/{techmapid}", ([FromRoute] int techmapid) =>
{
    var techMapCompositionStorage = new TechMapCompositionStorage();
    var item = techMapCompositionStorage.GetElementByTechMapId(techmapid);

    return Results.Ok(item);
})
    .WithName("TechMapCompositionItem")
    .WithOpenApi();

app.MapPost("/TechMapComposition/Create", (TechMapCompositionViewModel request) =>
{
    var techMapCompositionStorage = new TechMapCompositionStorage();

    techMapCompositionStorage.Insert(request);

    return Results.Ok();
})
    .WithName("CreateTechMapComposition")
    .WithOpenApi();

app.MapPatch("/TechMapComposition/Update", (TechMapCompositionViewModel request) =>
{
    var techMapCompositionStorage = new TechMapCompositionStorage();

    techMapCompositionStorage.Update(request);

    return Results.Ok();
})
    .WithName("UpdateTechMapComposition")
    .WithOpenApi();

app.MapPost("/TechMapComposition/Delete", (TechMapCompositionViewModel request) =>
{
    int idInt = Convert.ToInt32(request.Id);

    var techMapCompositionStorage = new TechMapCompositionStorage();

    techMapCompositionStorage.Delete(idInt);

    return Results.Ok();
})
    .WithName("DeleteTechMapComposition")
    .WithOpenApi();

app.MapGet("/TechnologicalMaps/Get", () =>
{
    var technologicalMapStorage = new TechnologicalMapStorage();
    var list = technologicalMapStorage.GetFullList();

    return Results.Ok(list);
})
    .WithName("TechnologicalMapList")
    .WithOpenApi();

app.MapPost("/TechnologicalMaps/Create", (TechnologicalMapViewModel request) =>
{
    var technologicalMapStorage = new TechnologicalMapStorage();

    technologicalMapStorage.Insert(request);

    return Results.Ok();
})
    .WithName("CreateTechnologicalMap")
    .WithOpenApi();

app.MapPatch("/TechnologicalMaps/Update", (TechnologicalMapViewModel request) =>
{
    var technologicalMapStorage = new TechnologicalMapStorage();

    technologicalMapStorage.Update(request);

    return Results.Ok();
})
    .WithName("UpdateTechnologicalMap")
    .WithOpenApi();

app.MapPost("/TechnologicalMaps/Delete", (TechnologicalMapViewModel request) =>
{
    int idInt = Convert.ToInt32(request.Id);

    var technologicalMapStorage = new TechnologicalMapStorage();

    technologicalMapStorage.Delete(idInt);

    return Results.Ok();
})
    .WithName("DeleteTechnologicalMap")
    .WithOpenApi();

app.MapGet("/Dishes/Get", () =>
{
    var dishStorage = new DishStorage();
    var list = dishStorage.GetFullList();

    return Results.Ok(list);
})
    .WithName("DishList")
    .WithOpenApi();

app.MapGet("/Dishes/GetByOrder/{orderid}", ([FromRoute] int orderid) =>
{
    var dishStorage = new DishStorage();
    var list = dishStorage.GetFilteredListByOrderId(orderid);

    return Results.Ok(list);
})
    .WithName("DishFilteredList")
    .WithOpenApi();

app.MapGet("/Dishes/Get/{ids}", ([FromRoute] string ids) =>
{
    var dishStorage = new DishStorage();
    var item = dishStorage.GetElementsByIds(ids);

    return Results.Ok(item);
})
    .WithName("DishItem")
    .WithOpenApi();

app.MapPost("/Dishes/Create", (DishViewModel request) =>
{
    var dishStorage = new DishStorage();

    dishStorage.Insert(request);

    return Results.Ok();
})
    .WithName("CreateDish")
    .WithOpenApi();

app.MapPatch("/Dishes/Update", (DishViewModel request) =>
{
    var dishStorage = new DishStorage();

    dishStorage.Update(request);

    return Results.Ok();
})
    .WithName("UpdateDish")
    .WithOpenApi();

app.MapPost("/Dishes/Delete", (DishViewModel request) =>
{
    int idInt = Convert.ToInt32(request.Id);

    var dishStorage = new DishStorage();

    dishStorage.Delete(idInt);

    return Results.Ok();
})
    .WithName("DeleteDish")
    .WithOpenApi();

app.MapGet("/Orders/Get", () =>
{
    var orderStorage = new OrderStorage();
    var list = orderStorage.GetFullList();

    return Results.Ok(list);
})
    .WithName("OrderList")
    .WithOpenApi();

app.MapPost("/Orders/Create", (OrderViewModel request) =>
{
    var orderStorage = new OrderStorage();

    orderStorage.Insert(request);

    return Results.Ok();
})
    .WithName("CreateOrder")
    .WithOpenApi();

app.MapPatch("/Orders/Update", (OrderViewModel request) =>
{
    var orderStorage = new OrderStorage();

    orderStorage.Update(request);

    return Results.Ok();
})
    .WithName("UpdateOrder")
    .WithOpenApi();

app.MapPost("/Orders/Delete", (OrderViewModel request) =>
{
    int idInt = Convert.ToInt32(request.Id);

    var orderStorage = new OrderStorage();

    orderStorage.Delete(idInt);

    return Results.Ok();
})
    .WithName("DeleteOrder")
    .WithOpenApi();

app.Run();

