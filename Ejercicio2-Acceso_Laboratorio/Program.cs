Console.WriteLine("Seleccione su Rol (Número): ");
Console.WriteLine("");
Console.WriteLine("1. Estudiante");
Console.WriteLine("2. Docente");
Console.WriteLine("3. Técnico IT");
Console.WriteLine("4. Visitante");
Console.WriteLine("");
int rol = int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingrese la hora de ingreso (0-23):");
Console.WriteLine("");
int horaIngreso = int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingrese el día (1-7):");
Console.WriteLine("");
int dia = int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("¿Tiene carnet vigente? (S/N)");
Console.WriteLine("");
string carnet = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("¿Tiene autorización escrita? (S/N)");
Console.WriteLine("");
string autorizacion = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("¿Trae una USB? (S/N)");
Console.WriteLine("");
string traeUSB = Console.ReadLine();
if (traeUSB=="S")
{
    Console.WriteLine("¿Está acompañado? (S/N)");
    string acompa= Console.ReadLine();
}
else
{
    
}




