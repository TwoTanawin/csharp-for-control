namespace threading
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startThread = new System.Windows.Forms.Button();
            this.stopThread = new System.Windows.Forms.Button();
            this.timmerStart = new System.Windows.Forms.Button();
            this.timmerStop = new System.Windows.Forms.Button();
            this.systemState = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // startThread
            // 
            this.startThread.Location = new System.Drawing.Point(210, 187);
            this.startThread.Name = "startThread";
            this.startThread.Size = new System.Drawing.Size(104, 45);
            this.startThread.TabIndex = 0;
            this.startThread.Text = "Th Start";
            this.startThread.UseVisualStyleBackColor = true;
            this.startThread.Click += new System.EventHandler(this.startThread_Click);
            // 
            // stopThread
            // 
            this.stopThread.Location = new System.Drawing.Point(210, 262);
            this.stopThread.Name = "stopThread";
            this.stopThread.Size = new System.Drawing.Size(104, 45);
            this.stopThread.TabIndex = 1;
            this.stopThread.Text = "Th Stop";
            this.stopThread.UseVisualStyleBackColor = true;
            this.stopThread.Click += new System.EventHandler(this.stopThread_Click);
            // 
            // timmerStart
            // 
            this.timmerStart.Location = new System.Drawing.Point(456, 187);
            this.timmerStart.Name = "timmerStart";
            this.timmerStart.Size = new System.Drawing.Size(104, 45);
            this.timmerStart.TabIndex = 2;
            this.timmerStart.Text = "Tm Start";
            this.timmerStart.UseVisualStyleBackColor = true;
            this.timmerStart.Click += new System.EventHandler(this.timmerStart_Click);
            // 
            // timmerStop
            // 
            this.timmerStop.Location = new System.Drawing.Point(456, 262);
            this.timmerStop.Name = "timmerStop";
            this.timmerStop.Size = new System.Drawing.Size(104, 45);
            this.timmerStop.TabIndex = 3;
            this.timmerStop.Text = "Tm Stop";
            this.timmerStop.UseVisualStyleBackColor = true;
            this.timmerStop.Click += new System.EventHandler(this.timmerStop_Click);
            // 
            // systemState
            // 
            this.systemState.AutoSize = true;
            this.systemState.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemState.Location = new System.Drawing.Point(288, 98);
            this.systemState.Name = "systemState";
            this.systemState.Size = new System.Drawing.Size(194, 45);
            this.systemState.TabIndex = 4;
            this.systemState.Text = "My Status";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(210, 345);
            this.hScrollBar1.Maximum = 1000;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(350, 45);
            this.hScrollBar1.TabIndex = 5;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.systemState);
            this.Controls.Add(this.timmerStop);
            this.Controls.Add(this.timmerStart);
            this.Controls.Add(this.stopThread);
            this.Controls.Add(this.startThread);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startThread;
        private System.Windows.Forms.Button stopThread;
        private System.Windows.Forms.Button timmerStart;
        private System.Windows.Forms.Button timmerStop;
        private System.Windows.Forms.Label systemState;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}

