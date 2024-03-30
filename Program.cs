var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<VedhaDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("VedhaCS")));
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.TryAddScoped<ILoginService, LoginService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}");

app.Run();
