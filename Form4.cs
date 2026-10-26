using System;
using System.Drawing;
using System.Windows.Forms;

namespace Conecta4Semestral
{
    // Form4 muestra las instrucciones del juego.
    public partial class Form4 : Form
    {
        // Referencia al menu principal para poder regresar.
        private Form1 menu;

        // Bandera para saber si estamos cambiando de formulario.
        private bool navegando = false;

        // Recibe el menu principal que lo abrio.
        public Form4(Form1 menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        // Dibuja un mini tablero 4x4 con una diagonal roja de ejemplo.
        // 0 = hueco azul, 1 = ficha roja, 2 = ficha amarilla.
        private void pnlEjemplo_Paint(object sender, PaintEventArgs e)
        {
            // Patron fijo que muestra la diagonal roja ganadora.
            int[,] patron = new int[4, 4]
            {
                { 0, 0, 2, 1 },
                { 0, 2, 1, 0 },
                { 2, 1, 0, 0 },
                { 1, 2, 1, 0 }
            };

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int tamano = 32;
            int margen = 6;
            int inicioX = 25;
            int inicioY = 20;

            for (int fila = 0; fila < 4; fila++)
            {
                for (int columna = 0; columna < 4; columna++)
                {
                    int valor = patron[fila, columna];

                    Color color;
                    if (valor == 1)
                    {
                        color = Color.Firebrick;
                    }
                    else if (valor == 2)
                    {
                        color = Color.Gold;
                    }
                    else
                    {
                        color = Color.FromArgb(10, 32, 90);
                    }

                    int x = inicioX + columna * (tamano + margen);
                    int y = inicioY + fila * (tamano + margen);

                    SolidBrush brocha = new SolidBrush(color);
                    g.FillEllipse(brocha, x, y, tamano, tamano);
                    brocha.Dispose();
                }
            }
        }

        // Boton Volver al Menu: muestra el menu y cierra este formulario.
        private void btnMenu_Click(object sender, EventArgs e)
        {
            navegando = true;
            menu.Show();
            this.Close();
        }

        // Si se cierra con la X, se cierra todo el programa.
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (navegando == true)
            {
                return;
            }
            Application.Exit();
        }

       }
}

