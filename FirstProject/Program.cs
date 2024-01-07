using FirstProject.BL;
using FirstProject.DAL;
using FirstProject.Filters;
using FirstProject.MiddelWare;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//ioc container 
builder.Services.AddDataAccessLayer(builder.Configuration);
builder.Services.AddBussinesLogin();

builder.Services.AddScoped<TestActionFitlerAttribute>();
builder.Services.AddScoped<testResourceFilterAttribute>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles();
app.UseHttpsRedirection();


app.Use(async (next,context) => {
    Console.Write("inline middel ware bfore 1");
    //logic before
    await context.Invoke(next);

    //logic after
    Console.Write("inline middel ware after 1");

});

app.UseMiddleware<TestMiddelware>();

app.UseAuthentication();
app.UseAuthorization();

//mvc middelware
app.MapControllers();

app.Run();
//during middelware the httpcontext his body still json not c# object  [modelbinding]
