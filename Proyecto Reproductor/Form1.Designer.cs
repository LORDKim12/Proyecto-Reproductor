namespace Proyecto_Reproductor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            panel2 = new Panel();
            trackBarVolumen = new TrackBar();
            button3 = new Button();
            btnSiguiente = new Button();
            videoView1 = new LibVLCSharp.WinForms.VideoView();
            pictureBox1 = new PictureBox();
            btnCargar = new Button();
            button2 = new Button();
            btnAnterior = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarVolumen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)videoView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(107, 155);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(194, 319);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.Fondoaplicacion;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(trackBarVolumen);
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(btnSiguiente);
            panel2.Controls.Add(videoView1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnCargar);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnAnterior);
            panel2.Location = new Point(-4, -29);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(946, 583);
            panel2.TabIndex = 1;
            // 
            // trackBarVolumen
            // 
            trackBarVolumen.Location = new Point(686, 444);
            trackBarVolumen.Margin = new Padding(3, 2, 3, 2);
            trackBarVolumen.Maximum = 100;
            trackBarVolumen.Name = "trackBarVolumen";
            trackBarVolumen.Size = new Size(127, 45);
            trackBarVolumen.TabIndex = 7;
            trackBarVolumen.TickFrequency = 10;
            trackBarVolumen.Value = 50;
            trackBarVolumen.Scroll += trackBarVolumen_Scroll;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = Properties.Resources.Botonstop;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(631, 381);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(96, 48);
            button3.TabIndex = 5;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.Transparent;
            btnSiguiente.BackgroundImage = Properties.Resources.Botonsiguiente;
            btnSiguiente.BackgroundImageLayout = ImageLayout.Stretch;
            btnSiguiente.Location = new Point(733, 381);
            btnSiguiente.Margin = new Padding(3, 2, 3, 2);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(96, 48);
            btnSiguiente.TabIndex = 6;
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // videoView1
            // 
            videoView1.BackColor = Color.Black;
            videoView1.Location = new Point(325, 155);
            videoView1.Margin = new Padding(3, 2, 3, 2);
            videoView1.MediaPlayer = null;
            videoView1.Name = "videoView1";
            videoView1.Size = new Size(505, 212);
            videoView1.TabIndex = 1;
            videoView1.Text = "videoView1";
            videoView1.Click += videoView1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(324, 155);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(505, 212);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnCargar
            // 
            btnCargar.BackColor = Color.Transparent;
            btnCargar.BackgroundImage = Properties.Resources.Botoncargar;
            btnCargar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCargar.Location = new Point(325, 381);
            btnCargar.Margin = new Padding(3, 2, 3, 2);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(96, 48);
            btnCargar.TabIndex = 2;
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.play;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(529, 381);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(96, 48);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = Color.Transparent;
            btnAnterior.BackgroundImage = Properties.Resources.botonanterioraa;
            btnAnterior.BackgroundImageLayout = ImageLayout.Stretch;
            btnAnterior.Location = new Point(427, 381);
            btnAnterior.Margin = new Padding(3, 2, 3, 2);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(96, 48);
            btnAnterior.TabIndex = 3;
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_ixu71hixu71hixu7;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1068, 588);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarVolumen).EndInit();
            ((System.ComponentModel.ISupportInitialize)videoView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button btnSiguiente;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private LibVLCSharp.WinForms.VideoView videoView1;
        private Button btnCargar;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnAnterior;
        private TrackBar trackBarVolumen;
    }
}
