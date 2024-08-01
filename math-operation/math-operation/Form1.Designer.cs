namespace math_operation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.plusOP = new System.Windows.Forms.RadioButton();
            this.minusOP = new System.Windows.Forms.RadioButton();
            this.mulOP = new System.Windows.Forms.RadioButton();
            this.divOP = new System.Windows.Forms.RadioButton();
            this.inputNum1 = new System.Windows.Forms.TextBox();
            this.inputNum2 = new System.Windows.Forms.TextBox();
            this.outputNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.computeBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.divOP);
            this.groupBox1.Controls.Add(this.mulOP);
            this.groupBox1.Controls.Add(this.minusOP);
            this.groupBox1.Controls.Add(this.plusOP);
            this.groupBox1.Location = new System.Drawing.Point(89, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Math Operation";
            // 
            // plusOP
            // 
            this.plusOP.AutoSize = true;
            this.plusOP.Location = new System.Drawing.Point(6, 34);
            this.plusOP.Name = "plusOP";
            this.plusOP.Size = new System.Drawing.Size(35, 20);
            this.plusOP.TabIndex = 0;
            this.plusOP.TabStop = true;
            this.plusOP.Text = "+";
            this.plusOP.UseVisualStyleBackColor = true;
            // 
            // minusOP
            // 
            this.minusOP.AutoSize = true;
            this.minusOP.Location = new System.Drawing.Point(6, 60);
            this.minusOP.Name = "minusOP";
            this.minusOP.Size = new System.Drawing.Size(32, 20);
            this.minusOP.TabIndex = 1;
            this.minusOP.TabStop = true;
            this.minusOP.Text = "-";
            this.minusOP.UseVisualStyleBackColor = true;
            this.minusOP.CheckedChanged += new System.EventHandler(this.minusOP_CheckedChanged);
            // 
            // mulOP
            // 
            this.mulOP.AutoSize = true;
            this.mulOP.Location = new System.Drawing.Point(6, 86);
            this.mulOP.Name = "mulOP";
            this.mulOP.Size = new System.Drawing.Size(33, 20);
            this.mulOP.TabIndex = 2;
            this.mulOP.TabStop = true;
            this.mulOP.Text = "*";
            this.mulOP.UseVisualStyleBackColor = true;
            // 
            // divOP
            // 
            this.divOP.AutoSize = true;
            this.divOP.Location = new System.Drawing.Point(6, 112);
            this.divOP.Name = "divOP";
            this.divOP.Size = new System.Drawing.Size(32, 20);
            this.divOP.TabIndex = 3;
            this.divOP.TabStop = true;
            this.divOP.Text = "/";
            this.divOP.UseVisualStyleBackColor = true;
            // 
            // inputNum1
            // 
            this.inputNum1.Location = new System.Drawing.Point(136, 193);
            this.inputNum1.Name = "inputNum1";
            this.inputNum1.Size = new System.Drawing.Size(100, 22);
            this.inputNum1.TabIndex = 1;
            this.inputNum1.Text = "0";
            // 
            // inputNum2
            // 
            this.inputNum2.Location = new System.Drawing.Point(136, 221);
            this.inputNum2.Name = "inputNum2";
            this.inputNum2.Size = new System.Drawing.Size(100, 22);
            this.inputNum2.TabIndex = 2;
            this.inputNum2.Text = "0";
            // 
            // outputNum
            // 
            this.outputNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputNum.Location = new System.Drawing.Point(89, 284);
            this.outputNum.Name = "outputNum";
            this.outputNum.Size = new System.Drawing.Size(162, 30);
            this.outputNum.TabIndex = 3;
            this.outputNum.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Num1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Num2";
            // 
            // computeBtn
            // 
            this.computeBtn.Location = new System.Drawing.Point(89, 255);
            this.computeBtn.Name = "computeBtn";
            this.computeBtn.Size = new System.Drawing.Size(162, 23);
            this.computeBtn.TabIndex = 6;
            this.computeBtn.Text = "Compute";
            this.computeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.computeBtn.UseVisualStyleBackColor = true;
            this.computeBtn.Click += new System.EventHandler(this.computeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 333);
            this.Controls.Add(this.computeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputNum);
            this.Controls.Add(this.inputNum2);
            this.Controls.Add(this.inputNum1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton divOP;
        private System.Windows.Forms.RadioButton mulOP;
        private System.Windows.Forms.RadioButton minusOP;
        private System.Windows.Forms.RadioButton plusOP;
        private System.Windows.Forms.TextBox inputNum1;
        private System.Windows.Forms.TextBox inputNum2;
        private System.Windows.Forms.TextBox outputNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button computeBtn;
    }
}

