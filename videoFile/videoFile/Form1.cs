using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;

namespace videoFile
{
    public partial class Form1 : Form
    {
        private VideoCapture videocapture;
        private bool IsoPlaying = false;
        private int TotalFrame;
        private int CurrentFrameNo;
        private Mat CurrentFrame;
        private int FPS;

        private void initCapture()
        {
            try
            {
                videocapture = new VideoCapture(@"C:\Users\Tanaw\Downloads\Deadpool & Wolverine.mp4");
                if (videocapture == null || !videocapture.IsOpened)
                {
                    MessageBox.Show("Failed to open the video file.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        public Form1()
        {
            InitializeComponent();
            initCapture();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void processVideo()
        {
            Mat frame = new Mat();
            videocapture.Read(frame);

            if (!frame.IsEmpty)
            {
                pictureBox1.Image?.Dispose();
                pictureBox1.Image = frame.ToBitmap();
            }
            else
            {
                MessageBox.Show("Some thing wrong");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            processVideo();
        }
    }
}
