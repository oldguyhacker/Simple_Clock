namespace Clock
{
    partial class Clock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clock));
            clock_desplay = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // clock_desplay
            // 
            clock_desplay.AutoSize = true;
            clock_desplay.Font = new Font("OCR A Extended", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clock_desplay.ForeColor = Color.SpringGreen;
            clock_desplay.Location = new Point(42, 55);
            clock_desplay.Name = "clock_desplay";
            clock_desplay.Size = new Size(457, 66);
            clock_desplay.TabIndex = 0;
            clock_desplay.Text = "00:00:00 AM";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Clock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(549, 183);
            Controls.Add(clock_desplay);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
            Name = "Clock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clock";
            Load += Clock_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label clock_desplay;
        private System.Windows.Forms.Timer timer1;
    }
}
