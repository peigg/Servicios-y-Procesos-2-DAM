namespace CarreraMotos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbMoto1 = new System.Windows.Forms.PictureBox();
            this.pbMoto4 = new System.Windows.Forms.PictureBox();
            this.pbMoto3 = new System.Windows.Forms.PictureBox();
            this.pbMoto2 = new System.Windows.Forms.PictureBox();
            this.lblMeta = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnControl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoto4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoto2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarreraMotos.Properties.Resources.WallpaperAppMotos;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1017, 668);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbMoto1
            // 
            this.pbMoto1.Image = global::CarreraMotos.Properties.Resources.Moto1;
            this.pbMoto1.Location = new System.Drawing.Point(12, 12);
            this.pbMoto1.Name = "pbMoto1";
            this.pbMoto1.Size = new System.Drawing.Size(117, 84);
            this.pbMoto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMoto1.TabIndex = 1;
            this.pbMoto1.TabStop = false;
            // 
            // pbMoto4
            // 
            this.pbMoto4.Image = global::CarreraMotos.Properties.Resources.Moto4;
            this.pbMoto4.Location = new System.Drawing.Point(12, 342);
            this.pbMoto4.Name = "pbMoto4";
            this.pbMoto4.Size = new System.Drawing.Size(117, 80);
            this.pbMoto4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMoto4.TabIndex = 2;
            this.pbMoto4.TabStop = false;
            // 
            // pbMoto3
            // 
            this.pbMoto3.Image = global::CarreraMotos.Properties.Resources.Moto3;
            this.pbMoto3.Location = new System.Drawing.Point(12, 231);
            this.pbMoto3.Name = "pbMoto3";
            this.pbMoto3.Size = new System.Drawing.Size(117, 83);
            this.pbMoto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMoto3.TabIndex = 3;
            this.pbMoto3.TabStop = false;
            // 
            // pbMoto2
            // 
            this.pbMoto2.Image = global::CarreraMotos.Properties.Resources.Moto2;
            this.pbMoto2.Location = new System.Drawing.Point(12, 126);
            this.pbMoto2.Name = "pbMoto2";
            this.pbMoto2.Size = new System.Drawing.Size(117, 76);
            this.pbMoto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMoto2.TabIndex = 4;
            this.pbMoto2.TabStop = false;
            // 
            // lblMeta
            // 
            this.lblMeta.Location = new System.Drawing.Point(900, 0);
            this.lblMeta.Name = "lblMeta";
            this.lblMeta.Size = new System.Drawing.Size(100, 668);
            this.lblMeta.TabIndex = 5;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Black;
            this.btnStart.Font = new System.Drawing.Font("Palatino Linotype", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Cyan;
            this.btnStart.Location = new System.Drawing.Point(142, 518);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 38);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Empezar";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Cyan;
            this.button1.Location = new System.Drawing.Point(602, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Reiniciar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnControl
            // 
            this.btnControl.BackColor = System.Drawing.Color.Black;
            this.btnControl.Font = new System.Drawing.Font("Palatino Linotype", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControl.ForeColor = System.Drawing.Color.Cyan;
            this.btnControl.Location = new System.Drawing.Point(122, 562);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(164, 49);
            this.btnControl.TabIndex = 10;
            this.btnControl.Text = "Avanzar";
            this.btnControl.UseVisualStyleBackColor = false;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 670);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbMoto2);
            this.Controls.Add(this.pbMoto3);
            this.Controls.Add(this.pbMoto4);
            this.Controls.Add(this.pbMoto1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMeta);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoto4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoto3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoto2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbMoto1;
        private System.Windows.Forms.PictureBox pbMoto4;
        private System.Windows.Forms.PictureBox pbMoto3;
        private System.Windows.Forms.PictureBox pbMoto2;
        private System.Windows.Forms.Label lblMeta;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnControl;
    }
}

