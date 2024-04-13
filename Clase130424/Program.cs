using Clase130424.ClaseHija;

Nintendo nintendo = new Nintendo();
nintendo.anioLanzamiento = 2017;
nintendo.esPortable = true;
nintendo.Marca = "Switch";

Console.WriteLine(nintendo.MostrarDetalleNintendo());

//instancia de ps1
PlayStation ps = new PlayStation();
ps.Marca = "Play Station 1";
ps.anioLanzamiento = 1994;
ps.ModeloControlador = "DualSense";
Console.WriteLine($"{ps.MostrarDetallePlay()}");

//instancia XBOX
XBOX xb = new XBOX();
xb.Marca = "XBOX";
xb.anioLanzamiento = 2005;
xb.TieneHalo = true;
Console.WriteLine($"{xb.MostrarDetalleXBOX()}");

//instancia Sega
SegaDreamCast sega = new SegaDreamCast();
sega.Marca = "Sega Dream Cast";
sega.anioLanzamiento = 1998;
sega.ControlconPantallita = true;
Console.WriteLine($"{sega.MostrarDetalleSega()}");