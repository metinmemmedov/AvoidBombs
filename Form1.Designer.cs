namespace AvoidBombs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bomb1 = new PictureBox();
            bomb2 = new PictureBox();
            man = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)bomb1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bomb2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)man).BeginInit();
            SuspendLayout();
            // 
            // bomb1
            // 
            bomb1.Location = new Point(12, 12);
            bomb1.Name = "bomb1";
            bomb1.Size = new Size(50, 50);
            bomb1.SizeMode = PictureBoxSizeMode.Zoom;
            bomb1.TabIndex = 0;
            bomb1.TabStop = false;
            // 
            // bomb2
            // 
            bomb2.Location = new Point(506, 12);
            bomb2.Name = "bomb2";
            bomb2.Size = new Size(50, 50);
            bomb2.SizeMode = PictureBoxSizeMode.Zoom;
            bomb2.TabIndex = 1;
            bomb2.TabStop = false;
            bomb2.Click += bomb2_Click;
            // 
            // man
            // 
            man.Image = (Image)resources.GetObject("man.Image");
            man.Location = new Point(252, 378);
            man.Name = "man";
            man.Size = new Size(60, 60);
            man.SizeMode = PictureBoxSizeMode.Zoom;
            man.TabIndex = 2;
            man.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 30;
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 450);
            Controls.Add(man);
            Controls.Add(bomb2);
            Controls.Add(bomb1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Avoid Bombs";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)bomb1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bomb2).EndInit();
            ((System.ComponentModel.ISupportInitialize)man).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox bomb1;
        private PictureBox bomb2;
        private PictureBox man;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
