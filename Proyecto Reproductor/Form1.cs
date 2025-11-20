using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using Proyecto_Reproductor.Clases;

namespace Proyecto_Reproductor
{
    public partial class Form1 : Form
    {
        // Variables para el motor de VLC
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
            // 1. Inicializamos el motor (Core.Initialize ya debería estar en Program.cs)
            _libVLC = new LibVLC();
            _mediaPlayer = new MediaPlayer(_libVLC);

            // 2. Conectamos tu VideoView del diseño con el reproductor
            // IMPORTANTE: 'videoView1' es el nombre que le pusiste en Propiedades
            videoView1.MediaPlayer = _mediaPlayer;
        }

        // Este evento se ejecuta al dar clic a tu botón "Cargar"
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

                        // Filtramos los archivos compatibles
                        if (ext == ".mp3" || ext == ".wav" ||
                            ext == ".mp4" || ext == ".mkv" || ext == ".avi" ||
                            ext == ".jpg" || ext == ".png" || ext == ".jpeg")
                        {
                            // Creamos nuestro objeto auxiliar para guardar nombre y ruta
                            var archivo = new ArchivoMedia();
                            archivo.Nombre = Path.GetFileNameWithoutExtension(rutaCompleta);
                            archivo.Ruta = rutaCompleta;

                            listBox1.Items.Add(archivo);
                        }
                    }
                }
            }
        }

        // Este evento se ejecuta al seleccionar algo en la lista
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is ArchivoMedia archivoSeleccionado)
            {
                string ruta = archivoSeleccionado.Ruta;
                string extension = Path.GetExtension(ruta).ToLower();

                if (_reproductorActual != null) _reproductorActual.Stop();

                // DEFINIMOS LAS ACCIONES AQUÍ:
                // Qué hacer cuando la clase pida "Siguiente"
                Action irSiguiente = () =>
                {
                    if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
                        listBox1.SelectedIndex++;
                };

                // Qué hacer cuando la clase pida "Anterior"
                Action irAnterior = () =>
                {
                    if (listBox1.SelectedIndex > 0)
                        listBox1.SelectedIndex--;
                };

                // Se las pasamos al constructor (fíjate en las dos variables al final)
                if (extension == ".mp3" || extension == ".wav")
                {
                    _reproductorActual = new Musica(ruta, _libVLC, _mediaPlayer, videoView1, pictureBox1, irSiguiente, irAnterior);
                }
                else if (extension == ".mp4" || extension == ".mkv" || extension == ".avi")
                {
                    _reproductorActual = new Video(ruta, _libVLC, _mediaPlayer, videoView1, pictureBox1, irSiguiente, irAnterior);
                }
                else if (extension == ".jpg" || extension == ".png" || extension == ".jpeg")
                {
                    _reproductorActual = new Imagen(ruta, _mediaPlayer, videoView1, pictureBox1, irSiguiente, irAnterior);
                }

                if (_reproductorActual != null) _reproductorActual.Play();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (_reproductorActual != null)
            {
                _reproductorActual.Siguiente(); // ¡La clase Video se encarga de llamar a la lista!
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (_reproductorActual != null)
            {
                _reproductorActual.Anterior();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_reproductorActual != null)
            {
                _reproductorActual.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_reproductorActual != null)
            {
                _reproductorActual.Pausa();
            }
        }
    }


    // Clase auxiliar para mostrar solo el nombre en la lista
    public class ArchivoMedia
    {
        public string Nombre { get; set; }
        public string Ruta { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}