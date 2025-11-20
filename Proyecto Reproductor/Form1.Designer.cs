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
            panel1 = new Panel();
            listBox1 = new ListBox();
            panel2 = new Panel();
            btnSiguiente = new Button();
            button3 = new Button();
            button2 = new Button();
            btnAnterior = new Button();
            btnCargar = new Button();
            videoView1 = new LibVLCSharp.WinForms.VideoView();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)videoView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(listBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 426);
            panel1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(3, 1);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(244, 424);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSiguiente);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnAnterior);
            panel2.Controls.Add(btnCargar);
            panel2.Controls.Add(videoView1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(268, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(520, 426);
            panel2.TabIndex = 1;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(369, 364);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(79, 29);
            btnSiguiente.TabIndex = 6;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // button3
            // 
            button3.Location = new Point(284, 364);
            button3.Name = "button3";
            button3.Size = new Size(79, 29);
            button3.TabIndex = 5;
            button3.Text = "Stop";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(178, 364);
            button2.Name = "button2";
            button2.Size = new Size(100, 29);
            button2.TabIndex = 4;
            button2.Text = "Play/Pause";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(93, 364);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(79, 29);
            btnAnterior.TabIndex = 3;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(16, 307);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(94, 29);
            btnCargar.TabIndex = 2;
            btnCargar.Text = "Cargar ";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // videoView1
            // 
            videoView1.BackColor = Color.Black;
            videoView1.Location = new Point(16, 22);
            videoView1.MediaPlayer = null;
            videoView1.Name = "videoView1";
            videoView1.Size = new Size(489, 279);
            videoView1.TabIndex = 1;
            videoView1.Text = "videoView1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(16, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(489, 279);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)videoView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
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
    }
}
