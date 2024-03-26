using Galaxy.Sale.Api.Aplication.Domain;

var builder = WebApplication.CreateBuilder(args);
// builder: permite realizar configuraciones como inyección de dependencias, utilizar REDIS, conexión a BDD, Usar autentificación

// Add services to the container.
// Alinear lo configurado, puede agregar filtros, parametrizaciones 
var app = builder.Build();

app.MapGet("/articulos", () =>
{
    List<Artilcle> list = new List<Artilcle>() { new Artilcle { Codigo = 1, Nombre = "Compuer", Precio = 23} };
    list.Add(new Artilcle { Codigo = 2, Nombre = "Desk", Precio = 10 });
    return list;
});
    
app.Run();
