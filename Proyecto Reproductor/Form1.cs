using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using Proyecto_Reproductor.Clases;
using Proyecto_Reproductor.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Proyecto_Reproductor
{
    public partial class Form1 : Form
    {
        private LibVLC? _libVLC;
        private MediaPlayer? _mediaPlayer;
        private Reproductor? _reproductorActual;

        public Form1()
        {
            InitializeComponent();
            ConfigurarVLC();
        }

        private void ConfigurarVLC()
        {
            _libVLC = new LibVLC();
            _mediaPlayer = new MediaPlayer(_libVLC);
            videoView1.MediaPlayer = _mediaPlayer;
            _mediaPlayer.Volume = trackBarVolumen.Value;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Clear();
                    var listaMusica = new List<ArchivoMedia>();
                    var listaVideos = new List<ArchivoMedia>();
                    var listaFotos = new List<ArchivoMedia>();

                    string[] archivos = Directory.GetFiles(dialog.SelectedPath, "*.*", SearchOption.AllDirectories);

                    foreach (string rutaCompleta in archivos)
                    {
                        string ext = Path.GetExtension(rutaCompleta).ToLower();
                        var archivo = new ArchivoMedia { Nombre = Path.GetFileNameWithoutExtension(rutaCompleta), Ruta = rutaCompleta };

                        if (ext == ".mp3" || ext == ".wav") listaMusica.Add(archivo);
                        else if (ext == ".mp4" || ext == ".mkv" || ext == ".avi") listaVideos.Add(archivo);
                        else if (ext == ".jpg" || ext == ".png" || ext == ".jpeg") listaFotos.Add(archivo);
                    }

                    if (listaMusica.Count > 0)
                    {
                        listBox1.Items.Add(new ArchivoMedia { Nombre = "=== 🎵 MÚSICA ===", EsEncabezado = true });
                        foreach (var item in listaMusica) listBox1.Items.Add(item);
                        listBox1.Items.Add(new ArchivoMedia { Nombre = "", EsEncabezado = true });
                    }

                    if (listaVideos.Count > 0)
                    {
                        listBox1.Items.Add(new ArchivoMedia { Nombre = "=== 🎬 VIDEOS ===", EsEncabezado = true });
                        foreach (var item in listaVideos) listBox1.Items.Add(item);
                        listBox1.Items.Add(new ArchivoMedia { Nombre = "", EsEncabezado = true });
                    }

                    if (listaFotos.Count > 0)
                    {
                        listBox1.Items.Add(new ArchivoMedia { Nombre = "=== 📷 FOTOS ===", EsEncabezado = true });
                        foreach (var item in listaFotos) listBox1.Items.Add(item);
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is ArchivoMedia archivoSeleccionado)
            {
                if (archivoSeleccionado.EsEncabezado) return;

                string ruta = archivoSeleccionado.Ruta;
                string extension = Path.GetExtension(ruta).ToLower();

                if (_reproductorActual != null) _reproductorActual.Stop();

                Action irSiguiente = () =>
                {
                    if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
                    {
                        listBox1.SelectedIndex++;
                        if (listBox1.SelectedItem is ArchivoMedia sig && sig.EsEncabezado)
                            if (listBox1.SelectedIndex < listBox1.Items.Count - 1) listBox1.SelectedIndex++;
                    }
                };

                Action irAnterior = () =>
                {
                    if (listBox1.SelectedIndex > 0)
                    {
                        listBox1.SelectedIndex--;
                        if (listBox1.SelectedItem is ArchivoMedia ant && ant.EsEncabezado)
                            if (listBox1.SelectedIndex > 0) listBox1.SelectedIndex--;
                    }
                };

                if (extension == ".mp3" || extension == ".wav")
                    _reproductorActual = new Musica(ruta, _libVLC!, _mediaPlayer!, videoView1, pictureBox1, irSiguiente, irAnterior);
                else if (extension == ".mp4" || extension == ".mkv" || extension == ".avi")
                    _reproductorActual = new Video(ruta, _libVLC!, _mediaPlayer!, videoView1, pictureBox1, irSiguiente, irAnterior);
                else if (extension == ".jpg" || extension == ".png" || extension == ".jpeg")
                    _reproductorActual = new Imagen(ruta, _mediaPlayer!, videoView1, pictureBox1, irSiguiente, irAnterior);

                if (_reproductorActual != null) _reproductorActual.Play();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e) 
        { 
            if (_reproductorActual != null) _reproductorActual.Siguiente(); 
        }
        private void btnAnterior_Click(object sender, EventArgs e) 
        { 
            if (_reproductorActual != null) _reproductorActual.Anterior(); 
        }
        private void button3_Click(object sender, EventArgs e) 
        { 
            if (_reproductorActual != null) _reproductorActual.Stop(); 
        }
        private void button2_Click(object sender, EventArgs e) 
        { 
            if (_reproductorActual != null) _reproductorActual.Pausa(); 
        }
        private void trackBarVolumen_Scroll(object sender, EventArgs e) 
        { 
            if (_mediaPlayer != null) _mediaPlayer.Volume = trackBarVolumen.Value; 
        }
    }
}