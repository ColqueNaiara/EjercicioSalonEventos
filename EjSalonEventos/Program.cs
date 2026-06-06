using EjSalonEventos;

Reserva reserva = new Reserva();

Console.WriteLine("Tipo de reserva: ");
Console.WriteLine("1. Solo Evento");
Console.WriteLine("2. Con Catering");
Console.WriteLine("3. Full");
reserva.TipoReserva = Convert.ToInt32(Console.ReadLine());

Console.Write("Nombre del cliente: ");
reserva.NombreCliente = Console.ReadLine();

Console.Write("Cantidad de invitados: ");
reserva.CantidadInvitados = Convert.ToInt32(Console.ReadLine());

Console.Write("Cantidad de horas: ");
reserva.CantidadHoras = Convert.ToInt32(Console.ReadLine());

Console.Write("¿Incluye mozos? (S/N): ");
reserva.IncluyeMozos = Console.ReadLine().ToUpper() == "S";

Console.Write("Día (V/S/D): ");
reserva.Dia = char.Parse(Console.ReadLine().ToUpper());

reserva.TipoMenu = 'N';

if (reserva.TipoReserva == 2 || reserva.TipoReserva == 3)
{
    Console.Write("Tipo de menú (B/P): ");
    reserva.TipoMenu = char.Parse(Console.ReadLine().ToUpper());
}

if (reserva.TipoReserva == 3)
{
    Console.Write("Cantidad de animaciones: ");
    reserva.CantidadAnimaciones = int.Parse(Console.ReadLine());
}

string resumen = reserva.ObtenerResumen();
Console.WriteLine();
Console.WriteLine(resumen);
        