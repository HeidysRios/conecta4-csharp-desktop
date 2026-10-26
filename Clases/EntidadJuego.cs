namespace Conecta4Semestral.Clases
{
    // Clase abstracta sencilla. Sirve para demostrar ABSTRACCION y HERENCIA.
    // La clase Jugador hereda de esta clase.
    public abstract class EntidadJuego
    {
        private int id;

        // Propiedad tradicional con get y set.
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
