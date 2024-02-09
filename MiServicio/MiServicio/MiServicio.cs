using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MiServicio
{
    public partial class MiServicio : ServiceBase
    {
        private int eventId = 1;

        [DllImport("advapi32.dll", SetLastError = true)]
        private static extern bool SetServiceStatus(System.IntPtr handle, ref ServiceStatus serviceStatus);
        public MiServicio()
        {
            InitializeComponent();
            eventLog1 = new System.Diagnostics.EventLog();
            if (!System.Diagnostics.EventLog.SourceExists("MySource"))
            {
                System.Diagnostics.EventLog.CreateEventSource(
                    "MySource", "MyNewLog");
            }
            eventLog1.Source = "MySource";
            eventLog1.Log = "MyNewLog";
        }

        protected override void OnStart(string[] args)
        {
            // Actualizar el estado del servicio a Start Pending.
            ServiceStatus serviceStatus = new ServiceStatus();
            serviceStatus.dwCurrentState = ServiceState.SERVICE_START_PENDING;
            serviceStatus.dwWaitHint = 100000;
            SetServiceStatus(this.ServiceHandle, ref serviceStatus);

            eventLog1.WriteEntry("In Onstart.");
            // Configurar un temporizador que se active cada minuto
            Timer timer = new Timer();
            timer.Interval = 60000; // 60 seconds
            timer.Elapsed += new ElapsedEventHandler(this.OnTimer);
            timer.Start();

            // Actualizar el estado del servicio a Running.
            serviceStatus.dwCurrentState = ServiceState.SERVICE_RUNNING;
            SetServiceStatus(this.ServiceHandle, ref serviceStatus);
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("In Onstop.");
        }
        public void OnTimer(object sender, ElapsedEventArgs args)
        {
            // Insertar las actividades de monitoreo aquí.    
            eventLog1.WriteEntry("Monitoreo", EventLogEntryType.Information, eventId++);
        }

        public enum ServiceState
        {
            SERVICE_STOPPED = 0x00000001,
            SERVICE_START_PENDING = 0x00000002,
            SERVICE_STOP_PENDING = 0x00000003,
            SERVICE_RUNNING = 0x00000004,
            SERVICE_CONTINUE_PENDING = 0x00000005,
            SERVICE_PAUSE_PENDING = 0x00000006,
            SERVICE_PAUSED = 0x00000007,
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct ServiceStatus
        {
            public int dwServiceType;
            public ServiceState dwCurrentState;
            public int dwControlsAccepted;
            public int dwWin32ExitCode;
            public int dwServiceSpecificExitCode;
            public int dwCheckPoint;
            public int dwWaitHint;
        };
    }
}
