using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Reproductor.Clases
{
    internal class Imagen : Reproductor
    {
        private string _ruta;
        private MediaPlayer _mp;
        private VideoView _videoView;
        private PictureBox _pb;

        public Imagen(string ruta, MediaPlayer mp, VideoView videoView, PictureBox pb)
        {
            _ruta = ruta;
            _mp = mp;
            _videoView = videoView;
            _pb = pb;
        }

        public void Play()
        {
            // 1. Detener VLC si algo está sonando
            if (_mp.IsPlaying) _mp.Stop();

            // 2. Cambiar interfaz
            _videoView.Visible = false;
            _pb.Visible = true;

            // 3. Cargar imagen
            _pb.ImageLocation = _ruta;
        }

        public void Pausa() { }
        public void Stop() { _pb.Image = null; }
        public void Siguiente() { }
        public void Anterior() { }
    }
}
