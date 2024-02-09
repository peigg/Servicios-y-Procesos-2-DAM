namespace PipeFromCliente
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
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSistema = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMensajes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(30, 260);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(737, 114);
            this.txtMensaje.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Olive;
            this.btnEnviar.Location = new System.Drawing.Point(289, 380);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(215, 58);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Olive;
            this.button1.Location = new System.Drawing.Point(99, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 71);
            this.button1.TabIndex = 2;
            this.button1.Text = "Activar recepción de mensajes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // txtSistema
            // 
            this.txtSistema.Location = new System.Drawing.Point(381, 12);
            this.txtSistema.Multiline = true;
            this.txtSistema.Name = "txtSistema";
            this.txtSistema.Size = new System.Drawing.Size(362, 71);
            this.txtSistema.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Envío de mensajes";
            // 
            // txtMensajes
            // 
            this.txtMensajes.Location = new System.Drawing.Point(30, 102);
            this.txtMensajes.Multiline = true;
            this.txtMensajes.Name = "txtMensajes";
            this.txtMensajes.Size = new System.Drawing.Size(737, 124);
            this.txtMensajes.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Recepción de mensajes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMensajes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSistema);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSistema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMensajes;
        private System.Windows.Forms.Label label2;
    }
}

