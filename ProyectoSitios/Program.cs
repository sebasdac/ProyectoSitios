using ProyectoSitios.Repository;
using ProyectoSitios.Services;
using ProyectoSitios.Services.Abstract;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddSingleton<IDbConnectionFactory, DbConnectionFactory>();
builder.Services.AddScoped<BitacoraRepository>();
builder.Services.AddScoped<IBitacoraService, BitacoraService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
if (!app.Environment.IsProduction())
{
    app.UseDeveloperExceptionPage(); // ?? Esto muestra los errores en el navegador
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
