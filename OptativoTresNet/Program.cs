
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using Infraestructura.Conexiones;
using Servicios.ContactosService;

//string connectionString = "Host=localhost;Username=root;Password=123456;Database=Optativo2;";
var connectionString = "Host=localhost;User Id=postgres;Password=654321;Database=Optativo2;";

CiudadService ciudadService = new CiudadService(connectionString);



ciudadService.insertarCiudad(new Infraestructura.Modelos.CiudadModel
{
    idCiudad = 2,
    descripcion = "Ciudad del Este",
    nombre_corto = "CDE",
    estado = "Activo"
});

var ciudad = ciudadService.obtenerCiudad(1);
Console.WriteLine($"Descripcion: {ciudad.descripcion}, nombre corto: {ciudad.nombre_corto}");

//ciudad.descripcion = "Mariano Roque Alonso";
//ciudadService.modificarCiudad(ciudad);

Console.WriteLine("...");
























//using OptativoTresNet.ClasePOO;

//Vehiculo vehiculo;

//vehiculo = new Auto("ASB-123",
//                      "Toyota Vitz",
//                      2010,
//                      "Gris",
//                      "Sucio",
//                      "Pequeño",
//                      "cortado");

//vehiculo.frenar();

//vehiculo = new Moto("ACD-987", "Dakar", 2020, "azul", "Limpio");

//vehiculo.frenar();





//Console.WriteLine(auto.getChapa());
//auto.setChapa("PEI-123");

//Console.WriteLine(auto.getChapa());