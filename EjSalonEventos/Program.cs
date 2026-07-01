using EjSalonEventos;

Console.WriteLine("Tipo de reserva: ");
Console.WriteLine("1. Solo Evento");
Console.WriteLine("2. Con Catering");
Console.WriteLine("3. Full");
int tipoReserva = Convert.ToInt32(Console.ReadLine());

Console.Write("Nombre del cliente: ");
string nombreCliente = Console.ReadLine();

Console.Write("Cantidad de invitados: ");
int cantidadInvitados = Convert.ToInt32(Console.ReadLine());

Console.Write("Cantidad de horas: ");
int cantidadHoras = Convert.ToInt32(Console.ReadLine());

Console.Write("¿Incluye mozos? (S/N): ");
bool incluyeMozos = Console.ReadLine().ToUpper() == "S";

Console.Write("Día (V/S/D): ");
char dia = char.Parse(Console.ReadLine().ToUpper());

char tipoMenu = 'N';

if (tipoReserva == 2 || tipoReserva == 3)
{
    Console.Write("Tipo de menú (B/P): ");
    tipoMenu = char.Parse(Console.ReadLine().ToUpper());
}

int cantidadAnimaciones = 0;

if (tipoReserva == 3)
{
    Console.Write("Cantidad de animaciones: ");
    cantidadAnimaciones = Convert.ToInt32(Console.ReadLine());
}

Reserva reserva = new Reserva(
    nombreCliente,
    cantidadInvitados,
    cantidadHoras,
    incluyeMozos,
    dia,
    tipoReserva,
    tipoMenu,
    cantidadAnimaciones
);

Console.WriteLine();
Console.WriteLine(reserva.ObtenerResumen());