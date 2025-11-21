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
            _pb.Visible = false;
            _videoView.Visible = true;
            using (var media = new Media(_libVLC, _ruta))
            {
                _mp.Play(media);
            }
        }

        public void Pausa() => _mp.Pause();
        public void Stop() => _mp.Stop();
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