namespace EjSalonEventos
{
    public class Reserva
    {
        private const int PrecioSalonHora = 6000;
        private const int PrecioMozo = 3000;
        private const int PrecioCateringBasico = 5000;
        private const int PrecioCateringPremium = 11000;
        private const int PrecioAnimacion = 18000;

        private string _nombreCliente;
        private int _cantidadInvitados;
        private int _cantidadHoras;
        private bool _incluyeMozos;
        private char _dia;
        private int _tipoReserva;
        private char _tipoMenu;
        private int _cantidadAnimaciones;

        public string NombreCliente
        {
            get { return _nombreCliente; }
            set 
            {
                if(!string.IsNullOrEmpty(value))
                    _nombreCliente = value;
            }
        }

        public int CantidadInvitados
        {
            get { return _cantidadInvitados; }
            set { _cantidadInvitados = value; }
        }

        public int CantidadHoras
        {
            get { return _cantidadHoras; }
            set { _cantidadHoras = value; }
        }

        public bool IncluyeMozos
        {
            get { return _incluyeMozos; }
            set { _incluyeMozos = value; }
        }

        public char Dia
        {
            get { return _dia; }
            set { _dia = value; }
        }

        public int TipoReserva
        {
            get { return _tipoReserva; }
            set { _tipoReserva = value; }
        }

        public char TipoMenu
        {
            get { return _tipoMenu; }
            set { _tipoMenu = value; }
        }

        public int CantidadAnimaciones
        {
            get { return _cantidadAnimaciones; }
            set { _cantidadAnimaciones = value; }
        }
        public Reserva(string nombreCliente, int cantidadInvitados, int cantidadHoras, bool incluyeMozos, char dia, int tipoReserva, char tipoMenu, int cantidadAnimaciones)
        {
            NombreCliente = nombreCliente;
            CantidadInvitados = cantidadInvitados;
            CantidadHoras = cantidadHoras;
            IncluyeMozos = incluyeMozos;
            Dia = dia;
            TipoReserva = tipoReserva;
            TipoMenu = tipoMenu;
            CantidadAnimaciones = cantidadAnimaciones;
        }
        public int CalcularValor()
        {
            double total = CantidadHoras * PrecioSalonHora;

            if (IncluyeMozos)
            {
                int cantidadMozos = CantidadInvitados / 15;
                if (CantidadInvitados % 15 != 0)
                {
                    cantidadMozos++;
                }
                total += cantidadMozos * PrecioMozo;
            }

            if (Dia == 'S')
            {
                total *= 1.80;
            }
            else if (Dia == 'D')
            {
                total *= 1.50;
            }

            if (TipoReserva == 2 || TipoReserva == 3)
            {
                if (TipoMenu == 'B')
                {
                    total += CantidadInvitados * PrecioCateringBasico;
                }
                else if (TipoMenu == 'P')
                {
                    total += CantidadInvitados * PrecioCateringPremium;
                }
            }

            if (TipoReserva == 3)
            {
                total += CantidadAnimaciones * PrecioAnimacion;
            }

            return (int) total;
        }

        public string ObtenerResumen()
        {
            return NombreCliente + " - Inv: " + CantidadInvitados + " - Horas: " + CantidadHoras + " - PRECIO $ " + CalcularValor();
        }
    }
}
