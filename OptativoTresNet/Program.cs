
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using Infraestructura.Conexiones;
using Servicios.ContactosService;

CiudadService ciudadService = new CiudadService("Server=localhost;Port=15432;User Id=postgres;Password=12345;Database=Optativo2;");
//ciudadService.insertarCiudad(new Infraestructura.Modelos.CiudadModel
//{
//    idCiudad = 3,
//    descripcion = "",
//    nombre_corto = "MRA",
//    estado = "Activo"
//});

var ciudad = ciudadService.obtenerCiudad(2);
Console.WriteLine($"Descripcion: {ciudad.descripcion}, nombre corto: {ciudad.nombre_corto}");

ciudad.descripcion = "Mariano Roque Alonso";
ciudadService.modificarCiudad(ciudad);

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