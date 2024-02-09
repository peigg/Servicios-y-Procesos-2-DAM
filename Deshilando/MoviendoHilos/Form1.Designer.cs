namespace MoviendoHilos
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.avion1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(94, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 89);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.avion2;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(481, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(196, 68);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(338, 189);
            button1.Name = "button1";
            button1.Size = new Size(90, 23);
            button1.TabIndex = 2;
            button1.Text = "COMENZAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 254);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deshilando moviento de hilos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
    }
}