namespace Conecta4Semestral.Clases
{
    // Clase que representa el tablero del juego.
    // Usa una matriz de 6 filas y 7 columnas.
    // 0 = vacio, 1 = ficha del jugador 1, 2 = ficha del jugador 2.
    public class Tablero
    {
        public const int Filas = 6;
        public const int Columnas = 7;

        // Matriz logica del tablero (ENCAPSULAMIENTO).
        private int[,] matriz = new int[Filas, Columnas];

        // Constructor: deja el tablero vacio.
        public Tablero()
        {
            InicializarTablero();
        }

        // Pone todas las posiciones en 0 (vacias).
        public void InicializarTablero()
        {
            for (int fila = 0; fila < Filas; fila++)
            {
                for (int columna = 0; columna < Columnas; columna++)
                {
                    matriz[fila, columna] = 0;
                }
            }
        }

        // Devuelve el valor de una posicion.
        public int ObtenerValor(int fila, int columna)
        {
            return matriz[fila, columna];
        }

        // Busca desde la ultima fila hacia arriba para simular la caida de la ficha.
        // Devuelve la fila disponible o -1 si la columna esta llena.
        public int BuscarFilaDisponible(int columna)
        {
            for (int fila = Filas - 1; fila >= 0; fila--)
            {
                if (matriz[fila, columna] == 0)
                {
                    return fila;
                }
            }
            return -1;
        }

        // Coloca la ficha del jugador en la columna indicada.
        // Devuelve la fila donde quedo, o -1 si no se pudo colocar.
        public int ColocarFicha(int columna, int jugador)
        {
            int fila = BuscarFilaDisponible(columna);
            if (fila == -1)
            {
                return -1;
            }
            matriz[fila, columna] = jugador;
            return fila;
        }

        // Indica si una columna ya esta llena.
        public bool ColumnaEstaLlena(int columna)
        {
            if (matriz[0, columna] == 0)
            {
                return false;
            }
            return true;
        }

        // Indica si todo el tablero esta lleno (para el empate).
        public bool EstaLleno()
        {
            for (int columna = 0; columna < Columnas; columna++)
            {
                if (matriz[0, columna] == 0)
                {
                    return false;
                }
            }
            return true;
        }

        // Cuenta cuantas fichas iguales hay a partir de una posicion,
        // avanzando en una direccion (cambioFila, cambioColumna).
        // No cuenta la ficha inicial.
        private int ContarFichas(int fila, int columna, int cambioFila, int cambioColumna, int jugador)
        {
            int cuenta = 0;
            int f = fila + cambioFila;
            int c = columna + cambioColumna;

            // Avanza mientras siga dentro del tablero y sea del mismo jugador.
            while (f >= 0 && f < Filas && c >= 0 && c < Columnas && matriz[f, c] == jugador)
            {
                cuenta = cuenta + 1;
                f = f + cambioFila;
                c = c + cambioColumna;
            }
            return cuenta;
        }

        // Verifica si el jugador tiene 4 en linea a partir de la ultima ficha.
        // Revisa horizontal, vertical y las dos diagonales.
        public bool VerificarGanador(int fila, int columna, int jugador)
        {
            // Horizontal (izquierda y derecha).
            int total = 1 + ContarFichas(fila, columna, 0, 1, jugador)
                          + ContarFichas(fila, columna, 0, -1, jugador);
            if (total >= 4)
            {
                return true;
            }

            // Vertical (arriba y abajo).
            total = 1 + ContarFichas(fila, columna, 1, 0, jugador)
                      + ContarFichas(fila, columna, -1, 0, jugador);
            if (total >= 4)
            {
                return true;
            }

            // Diagonal descendente ( \ ).
            total = 1 + ContarFichas(fila, columna, 1, 1, jugador)
                      + ContarFichas(fila, columna, -1, -1, jugador);
            if (total >= 4)
            {
                return true;
            }

            // Diagonal ascendente ( / ).
            total = 1 + ContarFichas(fila, columna, 1, -1, jugador)
                      + ContarFichas(fila, columna, -1, 1, jugador);
            if (total >= 4)
            {
                return true;
            }

            return false;
        }

        // Vacia el tablero para empezar de nuevo.
        public void Reiniciar()
        {
            InicializarTablero();
        }
    }
}
