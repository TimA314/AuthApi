using AuthApi.Models;
using AuthApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSingleton<IRandomDataService, RandomDataService>();
builder.Services.AddSingleton<IUserService, UserService>();

var app = builder.Build();



app.MapPost("/create",
    (RandomData randomData, IRandomDataService service) => Create(randomData, service);

app.MapPut("/update",
    (RandomData newRandomData, IRandomDataService service) => Update(newRandomData, service));

app.MapGet("/get",
    (int id, IRandomDataService service) => Get(id, service));

app.MapGet("/list",
    (IRandomDataService service) => List(service));

app.MapDelete("/delete",
    (int id, IRandomDataService service) => Delete(id, service));




IResult Create(RandomData randomData, IRandomDataService service)
{
    var result = service.Create(randomData);
    return Results.Ok(result);
}

IResult Get(int id, IRandomDataService service)
{
    var randomData = service.Get(id);
    if (randomData is null) return Results.NotFound("Data not found");
    return Results.Ok(randomData);
}

IResult List(IRandomDataService service)
{
    var randomData = service.List();
    return Results.Ok(randomData);
}

IResult Update(RandomData randomData, IRandomDataService service)
{
    var updatedRandomData = service.Update(randomData);
    if (updatedRandomData is null) Results.NotFound("Data not found");
    return Results.Ok(updatedRandomData);
}

IResult Delete(int id, IRandomDataService service)
{
    var result = service.Delete(id);

    if (!result) Results.BadRequest("Something went wrong");

    return Results.Ok(result);
}

app.Run();
