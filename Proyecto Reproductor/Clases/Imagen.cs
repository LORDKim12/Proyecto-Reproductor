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
        private Action _accionSiguiente;
        private Action _accionAnterior;

        public Imagen(string ruta, MediaPlayer mp, VideoView videoView, PictureBox pb, Action siguiente, Action anterior)
        {
            _ruta = ruta;
            _mp = mp;
            _videoView = videoView;
            _pb = pb;
            _accionSiguiente = siguiente;
            _accionAnterior = anterior;
        }

        public void Play()
        {
            if (_mp.IsPlaying) _mp.Stop();
            _videoView.Visible = false;
            _pb.Visible = true;
            _pb.BringToFront();
            _pb.ImageLocation = _ruta;
        }

        public void Pausa() { }
        public void Stop()
        {
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
