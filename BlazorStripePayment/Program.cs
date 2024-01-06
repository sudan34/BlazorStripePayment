using BlazorStripePayment.Components;
using Stripe;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents();
StripeConfiguration.ApiKey = "sk_test_51OVPr5SE59wav0prOp8qrCaY0Eo50W5yIfP7U060MIu1V8DntM7tf76QlBE0wSPE7Cp5fcDe3n0RlgePCZ0EWWv0008idPHERR";
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

app.MapRazorComponents<App>();

app.Run();
