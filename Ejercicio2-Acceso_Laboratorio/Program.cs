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
Console.WriteLine("¿Tiene compañia? (S/N)");
string compania = Console.ReadLine();


if (horaIngreso >= 0 && horaIngreso <= 23 && dia >= 1 && dia<=7 && (carnet=="S" || carnet=="N") && (autorizacion=="S" || autorizacion=="N") && (traeUSB=="S" || traeUSB=="N") && (compania == "S" || compania == "N"))
{
    switch (rol)
    {
        case 1:

            break;

        case 2:

            break;

        case 3:

            break;

        case 4:

            break;

        default:
            Console.WriteLine("Rol no válido. Por favor seleccione un rol válido.");
            break;
    }
}
else
{
    Console.WriteLine("Datos inválidos. Por favor ingrese datos válidos.");
}