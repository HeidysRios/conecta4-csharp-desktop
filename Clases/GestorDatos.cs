using System;
using System.IO;
using System.Text.Json;

namespace Conecta4Semestral.Clases
{
    // Clase sencilla para guardar los nombres, colores y victorias en un archivo JSON.
    // Si el archivo no existe, se usan valores predeterminados.
    public class GestorDatos
    {
        // Estos campos publicos se guardan y se cargan del archivo.
        public string NombreJugador1 { get; set; }
        public string NombreJugador2 { get; set; }
        public int ColorJugador1 { get; set; }   // 1 = Rojo, 2 = Amarillo
        public int ColorJugador2 { get; set; }
        public int VictoriasJugador1 { get; set; }
        public int VictoriasJugador2 { get; set; }

        // Ruta del archivo dentro de la carpeta de datos del usuario.
        private static string ObtenerRuta()
        {
            string carpeta = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "Conecta4Semestral");

            // Crea la carpeta si no existe.
            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }

            return Path.Combine(carpeta, "configuracion.json");
        }

        // Guarda los datos en el archivo JSON.
        public void GuardarDatos()
        {
            try
            {
                string ruta = ObtenerRuta();
                string texto = JsonSerializer.Serialize(this);
                File.WriteAllText(ruta, texto);
            }
            catch (Exception ex)
            {
                MessageBoxError("No se pudo guardar la configuracion: " + ex.Message);
            }
        }

        // Carga los datos del archivo. Si no existe o falla, devuelve valores predeterminados.
        public static GestorDatos CargarDatos()
        {
            try
            {
                string ruta = ObtenerRuta();
                if (File.Exists(ruta))
                {
                    string texto = File.ReadAllText(ruta);
                    GestorDatos datos = JsonSerializer.Deserialize<GestorDatos>(texto);
                    if (datos != null)
                    {
                        return datos;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxError("No se pudo cargar la configuracion: " + ex.Message);
            }

            // Valores predeterminados si no hay archivo.
            GestorDatos porDefecto = new GestorDatos();
            porDefecto.NombreJugador1 = "Jugador 1";
            porDefecto.NombreJugador2 = "Jugador 2";
            porDefecto.ColorJugador1 = 1;
            porDefecto.ColorJugador2 = 2;
            porDefecto.VictoriasJugador1 = 0;
            porDefecto.VictoriasJugador2 = 0;
            return porDefecto;
        }

        // Muestra un mensaje de error sin cerrar el programa.
        private static void MessageBoxError(string mensaje)
        {
            System.Windows.Forms.MessageBox.Show(mensaje, "Error",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Warning);
        }
    }
}
