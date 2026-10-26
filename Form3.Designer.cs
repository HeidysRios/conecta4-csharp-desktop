namespace Conecta4Semestral
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblJugador1;
        private System.Windows.Forms.Label lblJugador2;
        private System.Windows.Forms.Label lblTituloTablero;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Panel pnlTablero;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnMenu;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblJugador1 = new System.Windows.Forms.Label();
            lblJugador2 = new System.Windows.Forms.Label();
            lblTituloTablero = new System.Windows.Forms.Label();
            lblTurno = new System.Windows.Forms.Label();
            pnlTablero = new System.Windows.Forms.Panel();
            lblResultado = new System.Windows.Forms.Label();
            btnReiniciar = new System.Windows.Forms.Button();
            btnMenu = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblJugador1
            // 
            lblJugador1.BackColor = System.Drawing.Color.RoyalBlue;
            lblJugador1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblJugador1.ForeColor = System.Drawing.Color.White;
            lblJugador1.Location = new System.Drawing.Point(60, 30);
            lblJugador1.Name = "lblJugador1";
            lblJugador1.Size = new System.Drawing.Size(200, 45);
            lblJugador1.TabIndex = 0;
            lblJugador1.Text = "Jugador 1";
            lblJugador1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJugador2
            // 
            lblJugador2.BackColor = System.Drawing.Color.RoyalBlue;
            lblJugador2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblJugador2.ForeColor = System.Drawing.Color.White;
            lblJugador2.Location = new System.Drawing.Point(640, 30);
            lblJugador2.Name = "lblJugador2";
            lblJugador2.Size = new System.Drawing.Size(200, 45);
            lblJugador2.TabIndex = 1;
            lblJugador2.Text = "Jugador 2";
            lblJugador2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloTablero
            // 
            lblTituloTablero.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            lblTituloTablero.ForeColor = System.Drawing.Color.LightSteelBlue;
            lblTituloTablero.Location = new System.Drawing.Point(350, 35);
            lblTituloTablero.Name = "lblTituloTablero";
            lblTituloTablero.Size = new System.Drawing.Size(200, 30);
            lblTituloTablero.TabIndex = 2;
            lblTituloTablero.Text = "TABLERO 7x6";
            lblTituloTablero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTurno
            // 
            lblTurno.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            lblTurno.ForeColor = System.Drawing.Color.White;
            lblTurno.Location = new System.Drawing.Point(250, 80);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new System.Drawing.Size(400, 35);
            lblTurno.TabIndex = 3;
            lblTurno.Text = "Turno de Jugador 1";
            lblTurno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTablero
            // 
            pnlTablero.BackColor = System.Drawing.Color.RoyalBlue;
            pnlTablero.Location = new System.Drawing.Point(190, 130);
            pnlTablero.Name = "pnlTablero";
            pnlTablero.Size = new System.Drawing.Size(525, 450);
            pnlTablero.TabIndex = 4;
            // 
            // lblResultado
            // 
            lblResultado.BackColor = System.Drawing.Color.Gold;
            lblResultado.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            lblResultado.ForeColor = System.Drawing.Color.MidnightBlue;
            lblResultado.Location = new System.Drawing.Point(190, 595);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new System.Drawing.Size(230, 45);
            lblResultado.TabIndex = 5;
            lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblResultado.Visible = false;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = System.Drawing.Color.FromArgb(25, 45, 105);
            btnReiniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(65, 90, 145);
            btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReiniciar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnReiniciar.ForeColor = System.Drawing.Color.White;
            btnReiniciar.Location = new System.Drawing.Point(440, 595);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new System.Drawing.Size(130, 45);
            btnReiniciar.TabIndex = 6;
            btnReiniciar.Text = "⟳ Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = System.Drawing.Color.FromArgb(25, 45, 105);
            btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(65, 90, 145);
            btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMenu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnMenu.ForeColor = System.Drawing.Color.White;
            btnMenu.Location = new System.Drawing.Point(585, 595);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new System.Drawing.Size(130, 45);
            btnMenu.TabIndex = 7;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // Form3
            // 
            BackColor = System.Drawing.Color.FromArgb(13, 35, 95);
            ClientSize = new System.Drawing.Size(900, 670);
            Controls.Add(lblJugador1);
            Controls.Add(lblJugador2);
            Controls.Add(lblTituloTablero);
            Controls.Add(lblTurno);
            Controls.Add(pnlTablero);
            Controls.Add(lblResultado);
            Controls.Add(btnReiniciar);
            Controls.Add(btnMenu);
            MinimumSize = new System.Drawing.Size(916, 709);
            Name = "Form3";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form3 - Juego";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosing += Form3_FormClosing;
            ResumeLayout(false);
        }
    }
}
