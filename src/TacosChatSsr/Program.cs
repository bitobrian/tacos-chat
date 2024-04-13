using Blazored.LocalStorage;
using TacosChatSsr.Models;
using TacosChatSsr.Repos;
using TacosChatSsr.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddCascadingValue("ErrorContext", builder => new ErrorContext());
builder.Services.AddSingleton<SettingsRepo>();

builder.Services.AddSingleton<IDeviceStorage, StorageService>();

builder.Services.AddSingleton<FakeChatService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
