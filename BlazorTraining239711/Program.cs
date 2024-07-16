using BlazorTraining239711.Components;
using BlazorTraining239711.Components.Pages.modul4;
using BlazorTraining239711.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents().AddCircuitOptions(o=>o.DetailedErrors=true);


 builder.Services.AddSingleton<BlazorTraining239711.Components.Pages.modul1.Person>();
builder.Services.AddHttpClient();
builder.Services.AddSingleton<ChatVM>();
builder.Services.AddDbContext<NorthwindContext>(o=>o.UseSqlServer
(builder.Configuration.GetConnectionString("northwind")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
