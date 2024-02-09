namespace ConsumoWeb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCall = new System.Windows.Forms.Button();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCall
            // 
            resources.ApplyResources(this.btnCall, "btnCall");
            this.btnCall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(187)))), ((int)(((byte)(101)))));
            this.btnCall.Name = "btnCall";
            this.btnCall.UseVisualStyleBackColor = false;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // txtResponse
            // 
            this.txtResponse.BackColor = System.Drawing.Color.Black;
            this.txtResponse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtResponse, "txtResponse");
            this.txtResponse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(187)))), ((int)(((byte)(101)))));
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ConsumoWeb.Properties.Resources.USD_EXCHANGE_RATES;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnOut
            // 
            resources.ApplyResources(this.btnOut, "btnOut");
            this.btnOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(187)))), ((int)(((byte)(101)))));
            this.btnOut.Name = "btnOut";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnCall);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOut;
    }
}

