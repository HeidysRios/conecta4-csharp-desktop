using Conecta4Semestral.Clases;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Conecta4Semestral
{
    // Form3 es el formulario del juego.
    public partial class Form3 : Form
    {
        // La partida contiene los jugadores y el tablero (composicion y asociacion).
        private Partida partida;

        // Referencia al menu principal para poder regresar.
        private Form1 menu;

        // Matriz de controles visuales del tablero (42 PictureBox).
        private PictureBox[,] ControlesTablero = new PictureBox[6, 7];

        // Bandera para saber si estamos cambiando de formulario.
        private bool navegando = false;

        // Constructor: recibe la partida creada en Form2 y el menu principal.
        public Form3(Partida partida, Form1 menu)
        {
            InitializeComponent();
            this.partida = partida;
            this.menu = menu;

            GenerarTablero();
            ActualizarLabelsUI();
        }

        // Crea los 42 espacios del tablero usando dos ciclos for.
        private void GenerarTablero()
        {
            pnlTablero.Controls.Clear();

            int tamano = 65;   // tamano de cada espacio
            int margen = 10;   // separacion entre espacios

            for (int fila = 0; fila < 6; fila++)
            {
                for (int columna = 0; columna < 7; columna++)
                {
                    PictureBox espacio = new PictureBox();

                    espacio.Size = new Size(tamano, tamano);
                    espacio.Location = new Point(
                        margen + columna * (tamano + margen),
                        margen + fila * (tamano + margen));

                    espacio.BackColor = System.Drawing.Color.FromArgb(10, 32, 90);

                    // Guardamos la fila y la columna en el Tag.
                    espacio.Tag = new Point(fila, columna);

                    // Todas las posiciones usan el mismo evento Click.
                    espacio.Click += Espacio_Click;

                    ControlesTablero[fila, columna] = espacio;
                    pnlTablero.Controls.Add(espacio);
                }
            }

            // Ajusta el tamano del panel al tablero.
            pnlTablero.Size = new Size(
                margen + 7 * (tamano + margen),
                margen + 6 * (tamano + margen));

            RedibujarFichas();
        }

        // Se ejecuta al hacer clic en cualquier espacio del tablero.
        private void Espacio_Click(object sender, EventArgs e)
        {
            // Si el juego termino, no se puede jugar.
            if (partida.JuegoTerminado)
            {
                return;
            }

            // Obtenemos la columna donde se hizo clic desde el Tag.
            PictureBox espacio = (PictureBox)sender;
            Point posicion = (Point)espacio.Tag;
            int columna = posicion.Y;

            ColocarFicha(columna);
        }

        // Coloca la ficha del jugador actual en la columna elegida.
        private void ColocarFicha(int columna)
        {
            // Validacion: columna llena.
            if (partida.Tablero.ColumnaEstaLlena(columna))
            {
                MessageBox.Show("Esa columna esta llena. Elige otra.");
                return;
            }

            int jugadorActual = partida.TurnoActual;

            // Coloca la ficha y obtiene la fila donde cayo.
            int fila = partida.Tablero.ColocarFicha(columna, jugadorActual);

            if (fila == -1)
            {
                return;
            }

            RedibujarFichas();

            // Revisa si el jugador gano con esta ficha.
            if (partida.Tablero.VerificarGanador(fila, columna, jugadorActual))
            {
                Jugador ganador = partida.ObtenerJugadorActual();
                partida.FinalizarPartida(ganador);
                MostrarGanador(ganador);
                GuardarEstadisticas();
                return;
            }

            // Revisa si el tablero se lleno (empate).
            if (partida.Tablero.EstaLleno())
            {
                partida.FinalizarPartida(null);
                lblResultado.Text = "Empate";
                lblResultado.BackColor = System.Drawing.Color.RoyalBlue;
                lblResultado.ForeColor = System.Drawing.Color.White;
                lblResultado.Visible = true;
                return;
            }

            // Si nadie gano, cambia el turno.
            partida.CambiarTurno();
            ActualizarLabelsUI();
        }

        // Dibuja todas las fichas del tablero segun la matriz.
        private void RedibujarFichas()
        {
            for (int fila = 0; fila < 6; fila++)
            {
                for (int columna = 0; columna < 7; columna++)
                {
                    PictureBox espacio = ControlesTablero[fila, columna];

                    // Volvemos a conectar el evento Paint para redibujar la ficha.
                    espacio.Paint -= Espacio_Paint;
                    espacio.Paint += Espacio_Paint;
                    espacio.Invalidate();
                }
            }
        }

        // Dibuja el circulo de la ficha (rojo, amarillo o vacio).
        private void Espacio_Paint(object sender, PaintEventArgs e)
        {
            PictureBox espacio = (PictureBox)sender;
            Point posicion = (Point)espacio.Tag;
            int fila = posicion.X;
            int columna = posicion.Y;

            int valor = partida.Tablero.ObtenerValor(fila, columna);

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Determina el color segun a que jugador pertenece la ficha.
            Color color;
            if (valor == 0)
            {
                color = System.Drawing.Color.FromArgb(5, 20, 60);
            }
            else if (valor == 1)
            {
                color = ColorDelJugador(partida.Jugador1);
            }
            else
            {
                color = ColorDelJugador(partida.Jugador2);
            }

            int margen = 6;
            SolidBrush brocha = new SolidBrush(color);
            g.FillEllipse(brocha, margen, margen,
                espacio.Width - margen * 2, espacio.Height - margen * 2);
            brocha.Dispose();
        }

        // Devuelve el color real segun el numero de color del jugador.
        private Color ColorDelJugador(Jugador jugador)
        {
            if (jugador.Color == 1)
            {
                return System.Drawing.Color.Firebrick;
            }
            else
            {
                return System.Drawing.Color.Gold;
            }
        }

        // Actualiza los labels de turno y nombres de jugadores.
        private void ActualizarLabelsUI()
        {
            lblJugador1.Text = partida.Jugador1.Nombre;
            lblJugador2.Text = partida.Jugador2.Nombre;

            // Pinta cada tarjeta con el color del jugador.
            lblJugador1.BackColor = ColorDelJugador(partida.Jugador1);
            lblJugador2.BackColor = ColorDelJugador(partida.Jugador2);

            if (partida.Jugador1.Color == 2)
            {
                lblJugador1.ForeColor = System.Drawing.Color.MidnightBlue;
            }
            else
            {
                lblJugador1.ForeColor = System.Drawing.Color.White;
            }

            if (partida.Jugador2.Color == 2)
            {
                lblJugador2.ForeColor = System.Drawing.Color.MidnightBlue;
            }
            else
            {
                lblJugador2.ForeColor = System.Drawing.Color.White;
            }

            // Muestra de quien es el turno.
            Jugador actual = partida.ObtenerJugadorActual();
            lblTurno.Text = "Turno de " + actual.Nombre;
            lblTurno.ForeColor = ColorDelJugador(actual);
        }

        // Muestra el mensaje del ganador.
        private void MostrarGanador(Jugador ganador)
        {
            lblResultado.Text = "Gano " + ganador.Nombre + "!";
            lblResultado.BackColor = System.Drawing.Color.Gold;
            lblResultado.ForeColor = System.Drawing.Color.MidnightBlue;
            lblResultado.Visible = true;
            lblTurno.Text = "Gano " + ganador.Nombre + "!";
        }

        // Guarda las victorias en el archivo.
        private void GuardarEstadisticas()
        {
            GestorDatos datos = GestorDatos.CargarDatos();
            datos.NombreJugador1 = partida.Jugador1.Nombre;
            datos.NombreJugador2 = partida.Jugador2.Nombre;
            datos.ColorJugador1 = partida.Jugador1.Color;
            datos.ColorJugador2 = partida.Jugador2.Color;
            datos.VictoriasJugador1 = partida.Jugador1.Victorias;
            datos.VictoriasJugador2 = partida.Jugador2.Victorias;
            datos.GuardarDatos();
        }

        // Boton Reiniciar: limpia el tablero y empieza otra vez.
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            partida.ReiniciarPartida();
            lblResultado.Visible = false;
            RedibujarFichas();
            ActualizarLabelsUI();
        }

        // Boton Menu: regresa al menu principal.
        private void btnMenu_Click(object sender, EventArgs e)
        {
            // Si la partida sigue en curso, pide confirmacion.
            if (partida.JuegoTerminado == false)
            {
                DialogResult respuesta = MessageBox.Show("Desea abandonar la partida en curso?",
                    "Volver al menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta != DialogResult.Yes)
                {
                    return;
                }
            }

            RegresarMenu();
        }

        // Abre el menu principal y cierra este formulario.
        private void RegresarMenu()
        {
            navegando = true;
            menu.Show();
            this.Close();
        }

        // Al cerrar con la X, pregunta si la partida sigue en curso.
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Si estamos navegando a otro formulario, no cerramos la app.
            if (navegando == true)
            {
                return;
            }

            if (partida.JuegoTerminado == false)
            {
                DialogResult respuesta = MessageBox.Show("Desea abandonar la partida en curso?",
                    "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta != DialogResult.Yes)
                {
                    e.Cancel = true;
                    return;
                }
            }

            Application.Exit();
        }

        

        }
}

