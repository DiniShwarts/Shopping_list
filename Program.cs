using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;//���� ������ � DB
using MyMinimalApi.Data;//���� ������ � DB
using MyMinimalApi.Models;////���� ������ � DB
using MyMinimalApi.Configuration;
using MyMinimalApi.Services;
using MyMinimalApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

// ���� �� ������ DbContext ������� Swagger
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// ���� ������ Swagger
// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCustomServices(); // ����� �������� ������� �� ��������

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
});

// ���� ������ CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});
var app = builder.Build();

// �� ���� �����, ���� �� Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        c.RoutePrefix = string.Empty; // �� ���� �-Swagger UI ������ ������ �������
    });

}
app.UseHttpsRedirection();
// ����� ��������� �� �-API
// ����� ������ �������� �-CORS
app.UseCors("AllowAllOrigins");
//����� �� ����� ���������
app.MapGet("/api/getCategories", async (IItemService service) =>
{
    var categories = await service.GetCategoriesAsync();
    return Results.Ok(categories);
});
app.MapPost("/api/AddItems", async (List<Item> items, IItemService service) =>
{
    await service.AddItemsAsync(items);
    return Results.Created("/api/items", items);
});
app.MapGet("/api/getAllItems", async (IItemService service) =>
{
    var items = await service.GetItemsAsync();
    return Results.Ok(items);
});

app.MapPost("/api/addComments", async (IEnumerable<Comments> comments, IItemService service) =>
{
    await service.AddCommentsAsync(comments);
    return Results.Created("/api/comments", comments);
});

app.MapGet("/api/GetAllComments", async (IItemService service) =>
{
    var comments1 = await service.GetAllCommentsAsync();
    return Results.Ok(comments1);
});

app.Run();
