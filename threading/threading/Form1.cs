using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace threading
{
    public partial class Form1 : Form
    {
        private Thread workerThread;
        private bool isRunning, isGreen=true;
        private int speed = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void startThread_Click(object sender, EventArgs e)
        {
            if (workerThread == null || !workerThread.IsAlive)
            {
                isRunning = true;
                workerThread = new Thread(doWork);
                workerThread.Start();
                systemState.Text = "Thread IsAlive";
            }
        }

        private void stopThread_Click(object sender, EventArgs e)
        {
            if (workerThread != null && workerThread.IsAlive)
            {
                isRunning = false;
                workerThread.Join();
                systemState.Text = "My Status";
            }
        }
        private void doWork()
        {
            while (isRunning)
            {
                if (isGreen)
                {
                    this.BackColor = Color.Red;
                }
                else
                {
                    this .BackColor = Color.Green;
                }
                isGreen = !isGreen;

                Thread.Sleep(speed);
            }
        }

        private void timmerStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            systemState.Text = "Timmer IsAlive";
        }

        private void timmerStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            systemState.Text = "My Status";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isGreen)
            {
                this.BackColor = Color.Yellow;
            }
            else
            {
                this.BackColor = Color.Purple;
            }
            isGreen = !isGreen;
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            if (workerThread.IsAlive)
            {
                speed = hScrollBar1.Value;
                timer1.Interval = hScrollBar1.Value + 100;
            }
            else if (timer1.Enabled == true)
            {
                speed = hScrollBar1.Value+100;
                timer1.Interval = hScrollBar1.Value;
            }
            else
            {
                speed = hScrollBar1.Value + 100;
                timer1.Interval = hScrollBar1.Value+200;
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            isRunning = false;
            if (workerThread != null && workerThread.IsAlive)
            {
                workerThread.Join();
            }
            base.OnFormClosed(e);

            timer1.Stop();
        }
    }
}
