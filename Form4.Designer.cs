namespace Conecta4Semestral
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlEjemplo;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            pnlEjemplo = new System.Windows.Forms.Panel();
            label11 = new System.Windows.Forms.Label();
            btnMenu = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            panel5 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            pnlEjemplo.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlEjemplo
            // 
            pnlEjemplo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            pnlEjemplo.BackColor = System.Drawing.Color.FromArgb(255, 247, 230);
            pnlEjemplo.Controls.Add(label11);
            pnlEjemplo.Location = new System.Drawing.Point(72, 375);
            pnlEjemplo.Name = "pnlEjemplo";
            pnlEjemplo.Size = new System.Drawing.Size(760, 170);
            pnlEjemplo.TabIndex = 6;
            pnlEjemplo.Paint += pnlEjemplo_Paint;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label11.ForeColor = System.Drawing.Color.FromArgb(60, 75, 110);
            label11.Location = new System.Drawing.Point(182, 79);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(575, 17);
            label11.TabIndex = 2;
            label11.Text = "Ejemplo de una conexión diagonal ganadora: cuatro fichas rojas alineadas de esquina a esquina.";
            // 
            // btnMenu
            // 
            btnMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            btnMenu.BackColor = System.Drawing.Color.FromArgb(35, 75, 195);
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnMenu.ForeColor = System.Drawing.Color.White;
            btnMenu.Location = new System.Drawing.Point(340, 560);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new System.Drawing.Size(180, 40);
            btnMenu.TabIndex = 7;
            btnMenu.Text = "← Volver al Menú";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // panel3
            // 
            panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            panel3.BackColor = System.Drawing.Color.FromArgb(15, 35, 120);
            panel3.Location = new System.Drawing.Point(340, 560);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(180, 45);
            panel3.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            panel4.BackColor = System.Drawing.Color.White;
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label10);
            panel4.Location = new System.Drawing.Point(470, 235);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(364, 90);
            panel4.TabIndex = 14;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(5, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(32, 29);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // label9
            // 
            label9.BackColor = System.Drawing.Color.Transparent;
            label9.ForeColor = System.Drawing.Color.FromArgb(80, 80, 115);
            label9.Location = new System.Drawing.Point(5, 35);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(353, 40);
            label9.TabIndex = 1;
            label9.Text = "Si el tablero se llena por completo sin que nadie logre 4 en línea, la partida termina en empate.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label10.ForeColor = System.Drawing.Color.FromArgb(19, 38, 85);
            label10.Location = new System.Drawing.Point(37, 9);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(62, 20);
            label10.TabIndex = 0;
            label10.Text = "Empate";
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Location = new System.Drawing.Point(67, 235);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(364, 90);
            panel1.TabIndex = 15;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(5, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(32, 29);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.ForeColor = System.Drawing.Color.FromArgb(80, 80, 115);
            label7.Location = new System.Drawing.Point(5, 35);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(353, 40);
            label7.TabIndex = 1;
            label7.Text = "Cada ficha cae hasta el espacio más bajo disponible de la columna seleccionada.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.Color.FromArgb(19, 38, 85);
            label8.Location = new System.Drawing.Point(37, 9);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(113, 20);
            label8.TabIndex = 0;
            label8.Text = "Caída de fichas";
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            panel2.BackColor = System.Drawing.Color.White;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Location = new System.Drawing.Point(470, 117);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(364, 90);
            panel2.TabIndex = 16;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(5, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(32, 29);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.ForeColor = System.Drawing.Color.FromArgb(80, 80, 115);
            label5.Location = new System.Drawing.Point(5, 35);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(353, 40);
            label5.TabIndex = 1;
            label5.Text = "Los jugadores alternan turnos, colocando una ficha por turno en la columna que elijan.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.FromArgb(19, 38, 85);
            label6.Location = new System.Drawing.Point(37, 9);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(57, 20);
            label6.TabIndex = 0;
            label6.Text = "Turnos";
            // 
            // panel5
            // 
            panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            panel5.BackColor = System.Drawing.Color.White;
            panel5.Controls.Add(pictureBox1);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Location = new System.Drawing.Point(67, 117);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(364, 90);
            panel5.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(32, 29);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.ForeColor = System.Drawing.Color.FromArgb(80, 80, 115);
            label4.Location = new System.Drawing.Point(5, 35);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(353, 40);
            label4.TabIndex = 1;
            label4.Text = "Sé el primer jugador en alinear 4 fichas de tu color: en horizontal, vertical o diagonal.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.FromArgb(19, 38, 85);
            label3.Location = new System.Drawing.Point(37, 9);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(68, 20);
            label3.TabIndex = 0;
            label3.Text = "Objetivo";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.FromArgb(90, 115, 160);
            label2.Location = new System.Drawing.Point(362, 79);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(176, 20);
            label2.TabIndex = 12;
            label2.Text = "Cómo se juega conecta 4";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(19, 38, 85);
            label1.Location = new System.Drawing.Point(342, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(216, 45);
            label1.TabIndex = 11;
            label1.Text = "Instrucciones";
            // 
            // Form4
            // 
            BackColor = System.Drawing.Color.FromArgb(235, 241, 253);
            ClientSize = new System.Drawing.Size(900, 650);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMenu);
            Controls.Add(panel3);
            Controls.Add(pnlEjemplo);
            MinimumSize = new System.Drawing.Size(916, 689);
            Name = "Form4";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form4 - Instrucciones";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosing += Form4_FormClosing;
            pnlEjemplo.ResumeLayout(false);
            pnlEjemplo.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
    }
}
