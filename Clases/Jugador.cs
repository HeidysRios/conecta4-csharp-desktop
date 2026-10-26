namespace Conecta4Semestral.Clases
{
    // La clase Jugador HEREDA de EntidadJuego (herencia).
    // Guarda el nombre, el color y las victorias de un jugador.
    public class Jugador : EntidadJuego
    {
        // Atributos privados (ENCAPSULAMIENTO).
        private string nombre;
        private int color;      // 1 = Rojo, 2 = Amarillo
        private int victorias;

        // Propiedades publicas tradicionales.
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Victorias
        {
            get { return victorias; }
            set { victorias = value; }
        }

        // Constructor sencillo.
        public Jugador(int id, string nombre, int color)
        {
            this.Id = id;
            this.nombre = nombre;
            this.color = color;
            this.victorias = 0;
        }

        // Cambia el color del jugador.
        public void SeleccionarColor(int nuevoColor)
        {
            color = nuevoColor;
        }

        // Suma una victoria a este jugador.
        public void RegistrarVictoria()
        {
            victorias = victorias + 1;
        }
    }
}
