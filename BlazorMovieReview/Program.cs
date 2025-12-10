using BlazorMovieReview;
using BlazorMovieReview.Services;
using BlazorMovieReview.Components;

var builder = WebApplication.CreateBuilder(args);

var MyAllowSpecificOrigin = "_myAllowSpecificOrigins";

// Add services to the container.
builder.Services.AddRazorComponents().AddInteractiveServerComponents();

builder.Services.AddScoped<IMovieReviewService, MovieReviewService>(); /// Dependency injection for index

builder.Services.AddCors(options => {
    options.AddPolicy(MyAllowSpecificOrigin,
                     policy => {
                         policy.WithOrigins("http://localhost:5046")
                             .AllowAnyHeader()
                             .AllowAnyMethod();
                     });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
