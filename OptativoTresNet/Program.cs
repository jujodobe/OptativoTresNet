
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using OptativoTresNet.Conexiones;

ConexionDB objBaseDatos = new ConexionDB("Server=localhost;Port=15432;User Id=postgres;Password=12345;Database=Optativo2;");
if (objBaseDatos.probarConexion())
    Console.WriteLine("Se conectó a la base de datos");

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