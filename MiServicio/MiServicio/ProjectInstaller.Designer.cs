namespace MiServicio
{
    partial class ProjectInstaller
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceProcessInstaller1 = new System.ServiceProcess.ServiceProcessInstaller();
            this.Miservicio = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceProcessInstaller1
            // 
            this.serviceProcessInstaller1.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.serviceProcessInstaller1.Password = null;
            this.serviceProcessInstaller1.Username = null;
            // 
            // Miservicio
            // 
            this.Miservicio.Description = "Servicio Generado por Pablo Guerrero";
            this.Miservicio.DisplayName = "ServicioClase";
            this.Miservicio.ServiceName = "Service1";
            this.Miservicio.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            this.Miservicio.AfterInstall += new System.Configuration.Install.InstallEventHandler(this.Miservicio_AfterInstall);
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessInstaller1,
            this.Miservicio});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstaller1;
        private System.ServiceProcess.ServiceInstaller Miservicio;
    }
}