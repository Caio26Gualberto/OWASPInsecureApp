using Microsoft.EntityFrameworkCore;
using OWASPInsecureApp.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<OWASPInsecureAppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), p => p.MigrationsAssembly(typeof(OWASPInsecureAppDbContext).Assembly.FullName)));

var app = builder.Build();
app.UseStaticFiles();
app.UseDeveloperExceptionPage();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    //app.UseHsts(); Uncommenting these middlewares will cause the vulnerability (Security Misconfiguration) to be exposed
}

//app.UseHttpsRedirection(); Uncommenting these middlewares will cause the vulnerability (Security Misconfiguration) to be exposed
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
