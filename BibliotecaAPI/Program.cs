using Application.FakeData;
using Application.Interfaces;
using Application.Negocio;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Singleton
builder.Services.AddSingleton<IPrestamosData>(new PrestamosData());
builder.Services.AddSingleton<ILibrosData>(new LibrosData());
builder.Services.AddSingleton<IUsuariosData>(new UsuariosData());
builder.Services.AddSingleton<IEjemplaresData>(new EjemplaresData());
#endregion

builder.Services.AddScoped<IPrestamosManager, PrestamosManager>();
builder.Services.AddScoped<IUsuariosManager, UsuariosManager>();
builder.Services.AddScoped<ILibrosManager, LibrosManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true) // allow any origin 
    .AllowCredentials());

app.UseAuthorization();

app.MapControllers();

app.Run();
