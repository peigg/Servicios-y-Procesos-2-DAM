namespace PipeFormServidor
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
            this.btnActivar = new System.Windows.Forms.Button();
            this.lblMensajes = new System.Windows.Forms.Label();
            this.txtMensajes = new System.Windows.Forms.TextBox();
            this.txtSistema = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnviar = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnActivar
            // 
            this.btnActivar.BackColor = System.Drawing.Color.Olive;
            this.btnActivar.Location = new System.Drawing.Point(43, 30);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(268, 76);
            this.btnActivar.TabIndex = 2;
            this.btnActivar.Text = "Activar el Server";
            this.btnActivar.UseVisualStyleBackColor = false;
            this.btnActivar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblMensajes
            // 
            this.lblMensajes.AutoSize = true;
            this.lblMensajes.Location = new System.Drawing.Point(298, 376);
            this.lblMensajes.Name = "lblMensajes";
            this.lblMensajes.Size = new System.Drawing.Size(209, 25);
            this.lblMensajes.TabIndex = 3;
            this.lblMensajes.Text = "Mensajes del cliente";
            this.lblMensajes.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtMensajes
            // 
            this.txtMensajes.Location = new System.Drawing.Point(43, 305);
            this.txtMensajes.Multiline = true;
            this.txtMensajes.Name = "txtMensajes";
            this.txtMensajes.Size = new System.Drawing.Size(721, 96);
            this.txtMensajes.TabIndex = 4;
            this.txtMensajes.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtSistema
            // 
            this.txtSistema.Location = new System.Drawing.Point(359, 30);
            this.txtSistema.Multiline = true;
            this.txtSistema.Name = "txtSistema";
            this.txtSistema.Size = new System.Drawing.Size(405, 76);
            this.txtSistema.TabIndex = 5;
            this.txtSistema.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSistema.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mensajes del servidor";
            this.label1.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtEnviar
            // 
            this.txtEnviar.BackColor = System.Drawing.Color.Olive;
            this.txtEnviar.Location = new System.Drawing.Point(334, 243);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(110, 46);
            this.txtEnviar.TabIndex = 7;
            this.txtEnviar.Text = "Enviar";
            this.txtEnviar.UseVisualStyleBackColor = false;
            this.txtEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(43, 143);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(721, 94);
            this.txtMensaje.TabIndex = 8;
            this.txtMensaje.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mensajes al cliente";
            this.label2.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMensajes);
            this.Controls.Add(this.txtMensajes);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.txtEnviar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSistema);
            this.Controls.Add(this.btnActivar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Label lblMensajes;
        private System.Windows.Forms.TextBox txtMensajes;
        private System.Windows.Forms.TextBox txtSistema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtEnviar;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label label2;
    }
}


