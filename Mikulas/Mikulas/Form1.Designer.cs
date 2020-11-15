namespace Mikulas
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.CAR = new System.Windows.Forms.Button();
            this.BALL = new System.Windows.Forms.Button();
            this.lblNext = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(0, 151);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1156, 278);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick_1);
            // 
            // CAR
            // 
            this.CAR.Location = new System.Drawing.Point(95, 498);
            this.CAR.Name = "CAR";
            this.CAR.Size = new System.Drawing.Size(248, 90);
            this.CAR.TabIndex = 1;
            this.CAR.Text = "CAR";
            this.CAR.UseVisualStyleBackColor = true;
            this.CAR.Click += new System.EventHandler(this.CAR_Click);
            // 
            // BALL
            // 
            this.BALL.Location = new System.Drawing.Point(760, 498);
            this.BALL.Name = "BALL";
            this.BALL.Size = new System.Drawing.Size(248, 90);
            this.BALL.TabIndex = 1;
            this.BALL.Text = "BALL";
            this.BALL.UseVisualStyleBackColor = true;
            this.BALL.Click += new System.EventHandler(this.BALL_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(491, 61);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(101, 20);
            this.lblNext.TabIndex = 2;
            this.lblNext.Text = "Coming next:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(507, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 63);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 622);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.BALL);
            this.Controls.Add(this.CAR);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button CAR;
        private System.Windows.Forms.Button BALL;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button button1;
    }
}

