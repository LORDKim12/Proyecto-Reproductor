using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Reproductor.Clases
{
    internal class Musica : Reproductor
    {
        private string _ruta;
        private LibVLC _libVLC;
        private MediaPlayer _mp;
        private VideoView _videoView;
        private PictureBox _pb;

        public Musica(string ruta, LibVLC libVLC, MediaPlayer mp, VideoView videoView, PictureBox pb)
        {
            _ruta = ruta;
            _libVLC = libVLC;
            _mp = mp;
            _videoView = videoView;
            _pb = pb;
        }

        public void Play()
        {
            // 1. Configurar Interfaz
            _pb.Visible = false;
            _videoView.Visible = true; // VLC necesita el view activo a veces para procesar bien

            // 2. Reproducir
            using (var media = new Media(_libVLC, _ruta))
            {
                _mp.Play(media);
            }
        }

        public void Pausa() => _mp.Pause();
        public void Stop() => _mp.Stop();
        public void Siguiente() { }
        public void Anterior() { }
    }
}
