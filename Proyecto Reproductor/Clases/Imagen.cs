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
            // 1. Detener VLC
            if (_mp.IsPlaying) _mp.Stop();

            // 2. Cambiar interfaz
            _videoView.Visible = false;
            _pb.Visible = true;
            _pb.BringToFront(); // <--- AGREGA ESTA LÍNEA: Obliga a la foto a ponerse encima de todo

            // 3. Cargar imagen
            _pb.ImageLocation = _ruta;
        }

        public void Pausa() { }
        public void Stop()
        {
            _pb.Image = null;
            _pb.Visible = false;
        }
        public void Siguiente() { }
        public void Anterior() { }
    }
}
