using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;

namespace Proyecto_Reproductor
{
    public partial class Form1 : Form
    {
        public LibVLC _libVLC;
        public MediaPlayer _mediaPlayer;
        private VideoView _videoView;
        public Form1()
        {
            InitializeComponent();
            ConfigurarVLC();
        }
        private void ConfigurarVLC()
        {
            // 1. Inicializar motor y reproductor
            _libVLC = new LibVLC();
            _mediaPlayer = new MediaPlayer(_libVLC);

            // 2. Crear el control visual (pantalla)
            _videoView = new VideoView()
            {
                MediaPlayer = _mediaPlayer,
                Dock = DockStyle.Fill, // Ocupar todo el panel
                Visible = false // Oculto por defecto (para mostrar fotos si es necesario)
            };

            // 3. Agregarlo al panel2 (donde antes estaba el WMP)
            panel2.Controls.Add(_videoView);
        }

    }
}
