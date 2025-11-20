using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Reproductor.Clases
{
    internal class Video : Reproductor
    {
        private string _ruta;
        private LibVLC _libVLC;
        private MediaPlayer _mp;
        private VideoView _videoView;
        private PictureBox _pb;

        // Recibimos todo lo necesario en el constructor
        public Video(string ruta, LibVLC libVLC, MediaPlayer mp, VideoView videoView, PictureBox pb)
        {
            _ruta = ruta;
            _libVLC = libVLC;
            _mp = mp;
            _videoView = videoView;
            _pb = pb;
        }

        public void Play()
        {
            // 1. Preparar interfaz
            _pb.Visible = false;       // Ocultar foto
            _videoView.Visible = true; // Mostrar video

            // 2. Cargar y reproducir con VLC
            var media = new Media(_libVLC, _ruta);
            _mp.Play(media);
        }

        public void Pausa() => _mp.Pause();
        public void Stop() => _mp.Stop();
        public void Siguiente() { /* Lógica futura */ }
        public void Anterior() { /* Lógica futura */ }
    }
}
