namespace Client
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
            this.txtEleccion = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEleccion
            // 
            this.txtEleccion.Location = new System.Drawing.Point(200, 150);
            this.txtEleccion.Name = "txtEleccion";
            this.txtEleccion.Size = new System.Drawing.Size(200, 30);
            this.txtEleccion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEleccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(240, 250);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(120, 40);
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(64, 64, 64); // Fondo oscuro
            this.btnEnviar.ForeColor = System.Drawing.Color.White; // Texto blanco
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(128, 128, 128); // Cambia el fondo al pasar el ratón
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtEleccion);
            this.Name = "Form1";
            this.Text = "Piedra, papel, tijeras";
            this.BackColor = System.Drawing.Color.LightSteelBlue; // Fondo del formulario
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle; // Borde fijo
            this.MaximizeBox = false; // Deshabilita el botón de maximizar
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; // Centra el formulario en la pantalla
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.TextBox txtEleccion;
        private System.Windows.Forms.Button btnEnviar;


    }
}

