using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Proyecto_Reproductor.Properties; // Para acceder a tus Recursos

namespace Proyecto_Reproductor.Clases
{
    internal class Musica : Reproductor
    {
        private string _ruta;
        private LibVLC _libVLC;
        private MediaPlayer _mp;
        private VideoView _videoView;
        private PictureBox _pb;
        private Action _accionSiguiente;
        private Action _accionAnterior;

        public Musica(string ruta, LibVLC libVLC, MediaPlayer mp, VideoView videoView, PictureBox pb, Action siguiente, Action anterior)
        {
            _ruta = ruta;
            _libVLC = libVLC;
            _mp = mp;
            _videoView = videoView;
            _pb = pb;
            _accionSiguiente = siguiente;
            _accionAnterior = anterior;
        }

        public void Play()
        {
            // 1. Ocultamos el reproductor de video y mostramos el PictureBox
            _videoView.Visible = false;
            _pb.Visible = true;
            _pb.BringToFront();

            // 2. Asignamos el GIF desde los recursos
            // IMPORTANTE: Cambia 'AnimacionMusica' por el nombre real de tu archivo en Resources
            _pb.Image = Resources.AnimacionMusica;

            // 'StretchImage' hará que el GIF ocupe todo el espacio, aunque podría deformarse un poco.
            // Si prefieres que mantenga su forma, usa 'Zoom' (pero podrían quedar bordes vacíos).
            _pb.SizeMode = PictureBoxSizeMode.StretchImage;

            // 3. Reproducimos el audio
            using (var media = new Media(_libVLC, _ruta))
            {
                _mp.Play(media);
            }
        }

        public void Pausa() => _mp.Pause();

        public void Stop()
        {
            _mp.Stop();

            // Es buena práctica limpiar la imagen para liberar memoria y detener la animación
            _pb.Image = null;
            _pb.Visible = false;
        }

        public void Siguiente()
        {
            if (_accionSiguiente != null) _accionSiguiente();
        }
        public void Anterior()
        {
            if (_accionAnterior != null) _accionAnterior();
        }
    }
}