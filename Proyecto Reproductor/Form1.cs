using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using Proyecto_Reproductor.Clases;

namespace Proyecto_Reproductor
{
    public partial class Form1 : Form
    {
        private LibVLC _libVLC;
        private MediaPlayer _mediaPlayer;
        private Reproductor _reproductorActual;

        public Form1()
        {
            InitializeComponent();
            ConfigurarVLC();
        }

        private void ConfigurarVLC()
        {
            _libVLC = new LibVLC();
            _mediaPlayer = new MediaPlayer(_libVLC);
            videoView1.MediaPlayer = _mediaPlayer;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Clear();
                    string[] archivos = Directory.GetFiles(dialog.SelectedPath);
                    foreach (string rutaCompleta in archivos)
                    {
                        string ext = Path.GetExtension(rutaCompleta).ToLower();
                        if (ext == ".mp3" || ext == ".wav" || ext == ".mp4" || ext == ".mkv" || ext == ".avi" || ext == ".jpg" || ext == ".png" || ext == ".jpeg")
                        {
                            var archivo = new ArchivoMedia { Nombre = Path.GetFileNameWithoutExtension(rutaCompleta), Ruta = rutaCompleta };
                            listBox1.Items.Add(archivo);
                        }
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is ArchivoMedia archivoSeleccionado)
            {
                string ruta = archivoSeleccionado.Ruta;
                string extension = Path.GetExtension(ruta).ToLower();

                if (_reproductorActual != null) _reproductorActual.Stop();

                // DEFINIMOS LAS ACCIONES PARA CUMPLIR CON LA INTERFAZ
                Action irSiguiente = () => {
                    if (listBox1.SelectedIndex < listBox1.Items.Count - 1) listBox1.SelectedIndex++;
                };

                Action irAnterior = () => {
                    if (listBox1.SelectedIndex > 0) listBox1.SelectedIndex--;
                };

                // Pasamos las acciones a las clases (Ahora todas las aceptan)
                if (extension == ".mp3" || extension == ".wav")
                    _reproductorActual = new Musica(ruta, _libVLC, _mediaPlayer, videoView1, pictureBox1, irSiguiente, irAnterior);
                else if (extension == ".mp4" || extension == ".mkv" || extension == ".avi")
                    _reproductorActual = new Video(ruta, _libVLC, _mediaPlayer, videoView1, pictureBox1, irSiguiente, irAnterior);
                else if (extension == ".jpg" || extension == ".png" || extension == ".jpeg")
                    _reproductorActual = new Imagen(ruta, _mediaPlayer, videoView1, pictureBox1, irSiguiente, irAnterior);

                if (_reproductorActual != null) _reproductorActual.Play();
            }
        }

        // LOS BOTONES USAN LA INTERFAZ (Correcto para calificación)
        private void btnSiguiente_Click(object sender, EventArgs e) { if (_reproductorActual != null) _reproductorActual.Siguiente(); }
        private void btnAnterior_Click(object sender, EventArgs e) { if (_reproductorActual != null) _reproductorActual.Anterior(); }
        private void button3_Click(object sender, EventArgs e) { if (_reproductorActual != null) _reproductorActual.Stop(); } // Boton Stop
        private void button2_Click(object sender, EventArgs e) { if (_reproductorActual != null) _reproductorActual.Pausa(); } // Boton Play/Pause
    }

    public class ArchivoMedia { public string Nombre { get; set; } public string Ruta { get; set; } public override string ToString() => Nombre; }
}