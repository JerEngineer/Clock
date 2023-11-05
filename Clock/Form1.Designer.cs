namespace Clock
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
            components = new System.ComponentModel.Container();
            Time = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            Date = new Label();
            label1 = new Label();
            label2 = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            Day = new Label();
            SuspendLayout();
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.Font = new Font("Calibri", 34.8F, FontStyle.Bold, GraphicsUnit.Point);
            Time.Location = new Point(98, 89);
            Time.Name = "Time";
            Time.Size = new Size(176, 71);
            Time.TabIndex = 0;
            Time.Text = "label1";
            
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Font = new Font("Calibri", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Date.Location = new Point(31, 9);
            Date.Name = "Date";
            Date.Size = new Size(83, 41);
            Date.TabIndex = 1;
            Date.Text = "Date";
            Date.Click += Date_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 50);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 165);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // timer2
            // 
            timer2.Interval = 500;
           
            // 
            // Day
            // 
            Day.AutoSize = true;
            Day.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Day.Location = new Point(358, 9);
            Day.Name = "Day";
            Day.Size = new Size(65, 28);
            Day.TabIndex = 7;
            Day.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(570, 185);
            Controls.Add(Day);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Date);
            Controls.Add(Time);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "Clock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Time;
        private System.Windows.Forms.Timer timer1;
        private Label Date;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer2;
        private Label Day;
    }
}