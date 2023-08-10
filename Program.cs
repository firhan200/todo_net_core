using Todov2.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();
app.UseHttpsRedirection();
// Configure the HTTP request pipeline.

var todoRouter = app.MapGroup("/todo");

todoRouter.MapGet("/", () =>
{
    List<string> todos = new List<string>();
    todos.Add("Eat");
    todos.Add("Sleep");
    todos.Add("Repeat");
    return Results.Ok(todos);
});

todoRouter.MapPost("/", (Todo todo) =>
{
    return todo;
});

todoRouter.MapPut("/{id}", (int id, Todo todo) =>
{
    todo.Id = id;
    return todo;
});

todoRouter.MapDelete("/", () =>
{
    return "delete todo";
});

app.Run();