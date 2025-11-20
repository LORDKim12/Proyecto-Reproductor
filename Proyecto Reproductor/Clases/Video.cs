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

        // Variables para guardar las instrucciones del Formulario
        private Action _accionSiguiente;
        private Action _accionAnterior;

        // Constructor completo (7 argumentos)
        public Video(string ruta, LibVLC libVLC, MediaPlayer mp, VideoView videoView, PictureBox pb, Action siguiente, Action anterior)
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
            // Configuración visual para video
            _pb.Visible = false;
            _videoView.Visible = true;

            // Cargar y reproducir
            using (var media = new Media(_libVLC, _ruta))
            {
                _mp.Play(media);
            }
        }

        public void Pausa() => _mp.Pause();
        public void Stop() => _mp.Stop();

        // Implementación real de los métodos de la interfaz usando los Actions
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