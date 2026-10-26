namespace Conecta4Semestral.Clases
{
    // Clase que controla la partida.
    // COMPOSICION: la partida crea su propio Tablero.
    // ASOCIACION: la partida recibe y guarda dos objetos Jugador.
    public class Partida
    {
        private Jugador jugador1;
        private Jugador jugador2;
        private Tablero tablero;

        private int turnoActual;        // 1 o 2
        private bool juegoTerminado;
        private Jugador ganador;

        // Propiedades para leer los datos desde los formularios.
        public Jugador Jugador1
        {
            get { return jugador1; }
        }

        public Jugador Jugador2
        {
            get { return jugador2; }
        }

        public Tablero Tablero
        {
            get { return tablero; }
        }

        public int TurnoActual
        {
            get { return turnoActual; }
        }

        public bool JuegoTerminado
        {
            get { return juegoTerminado; }
        }

        public Jugador Ganador
        {
            get { return ganador; }
        }

        // Constructor: recibe los dos jugadores (asociacion) y crea el tablero (composicion).
        public Partida(Jugador jugador1, Jugador jugador2)
        {
            this.jugador1 = jugador1;
            this.jugador2 = jugador2;
            this.tablero = new Tablero();
            this.turnoActual = 1;
            this.juegoTerminado = false;
            this.ganador = null;
        }

        // Prepara la partida para empezar.
        public void IniciarPartida()
        {
            tablero.Reiniciar();
            turnoActual = 1;
            juegoTerminado = false;
            ganador = null;
        }

        // Devuelve el jugador que tiene el turno actual.
        public Jugador ObtenerJugadorActual()
        {
            if (turnoActual == 1)
            {
                return jugador1;
            }
            else
            {
                return jugador2;
            }
        }

        // Cambia el turno de un jugador al otro.
        public void CambiarTurno()
        {
            if (turnoActual == 1)
            {
                turnoActual = 2;
            }
            else
            {
                turnoActual = 1;
            }
        }

        // Termina la partida y guarda al ganador (o null si es empate).
        public void FinalizarPartida(Jugador jugadorGanador)
        {
            juegoTerminado = true;
            ganador = jugadorGanador;
            if (jugadorGanador != null)
            {
                jugadorGanador.RegistrarVictoria();
            }
        }

        // Reinicia la partida con los mismos jugadores.
        public void ReiniciarPartida()
        {
            IniciarPartida();
        }
    }
}
