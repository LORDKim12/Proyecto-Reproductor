using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Reproductor.Clases
{
    internal interface Reproductor
    {
        void Play();
        void Pausa();
        void Stop();
        void Siguiente();
        void Anterior();
    }
}
