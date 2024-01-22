using SchoolCafeteriaDatabaseImplement.Implements;
using SchoolCafeteriaContracts.ViewModels;
using System.Text.Json.Serialization;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/GetUsers", () =>
{
    var userStorage = new UserStorage();
    var list = userStorage.GetFullList();

    return Results.Ok(list);
});

app.MapGet("/CreateUser", (UserViewModel request) =>
{
    var userStorage = new UserStorage();
    var list = userStorage.GetFullList();

    return Results.Ok(list);
})
    .WithName("Get");

app.Run();

