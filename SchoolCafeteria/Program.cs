using SchoolCafeteriaDatabaseImplement.Implements;
using SchoolCafeteriaContracts.ViewModels;
using Swashbuckle.AspNetCore.Swagger;
using System.Text.Json.Serialization;
using System.Text.Json;
using SchoolCefeteriaContracts.ViewModels;
using Microsoft.AspNetCore.Mvc;
using SchoolCafeteria.OfficePackage;
using System.Xml.Linq;
using System.Xml;

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

app.MapGet("/CreateDocument/{id}", ([FromRoute] int id) =>
{
    var technologicalMapStorage = new TechnologicalMapStorage();
    var techMapCompositionStorage = new TechMapCompositionStorage();
    var goodsStorage = new GoodsStorage();

    var techMap = technologicalMapStorage.GetElement(id);
    var techMapComposition = techMapCompositionStorage.GetElementByTechMapId(id);

    List<GoodsViewModel> techMapGoods = new List<GoodsViewModel>();

    foreach(var idString in techMap.TechMapGoods)
    {
        int idInt = Convert.ToInt32(idString);

        var goods = goodsStorage.GetElement(idInt);

        if(goods != null)
        {
            techMapGoods.Add(goods);
        }
    }

    var xElement = new XElement("TechMap");

    if (techMap != null && techMapComposition != null)
    {
        xElement.Add(new XElement("Id", techMap.Id),
            new XElement("DishName", techMap.DishName),
            new XElement("RecipeNumber", techMap.RecipeNumber),
            new XElement("CookingTechnology", techMap.CookingTechnology),
            new XElement("Description", techMap.Description),
            new XElement("CreateDt", DateTime.Now.ToShortDateString()),
            new XElement("Composition",
                new XElement("Protein", techMapComposition.Protein),
                new XElement("Fat", techMapComposition.Fat),
                new XElement("Carb", techMapComposition.Carb),
                new XElement("B1", techMapComposition.B1),
                new XElement("C", techMapComposition.C),
                new XElement("A", techMapComposition.A),
                new XElement("E", techMapComposition.E),
                new XElement("Ca", techMapComposition.Ca),
                new XElement("P", techMapComposition.P),
                new XElement("Mg", techMapComposition.Mg),
                new XElement("Fe", techMapComposition.Fe)));

        if(techMapGoods.Count > 0)
        {
            var techMapGoodsXElement = new XElement("TechMapGoods");

            foreach(var goods in techMapGoods)
            {
                techMapGoodsXElement.Add(new XElement("Goods",
                    new XElement("Name", goods.Name),
                    new XElement("Brutto", goods.BruttoMass),
                    new XElement("Netto", goods.NettoMass),
                    new XElement("Brutto100", Convert.ToInt32(goods.BruttoMass) * 100),
                    new XElement("Netto100", Convert.ToInt32(goods.NettoMass) * 100)));
            }

            xElement.Add(techMapGoodsXElement);
        }
    }

    XDocument xDocument = new XDocument(xElement);

    xDocument.Save("xmlDoc.xml");

    CreateWordDoc.CreteDocument();

    return Results.File(Path.Combine(app.Environment.ContentRootPath, "шаблон.docx"), "application/vnd.openxmlformats-officedocument.wordprocessingml.document", "test.docx");
})
    .WithName("CreateDocument")
    .WithOpenApi();

app.Run();