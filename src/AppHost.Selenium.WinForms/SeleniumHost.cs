using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenQA.Selenium;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace AppHost.Selenium.WinForms {
    public partial class SeleniumHost : UserControl {

        private static class UnsafeNativeMethods {
            [DllImport("user32")]
            public static extern IntPtr SetParent(IntPtr hWnd, IntPtr hWndParent);

            [DllImport("user32.dll", SetLastError = true)]
            public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        }

        public SeleniumHost() {
            InitializeComponent();
        }


        public DriverService DriverService {
            get {
                return _DriverService;
            }
            set {
                
                if (_DriverService != null)
                    DetachDriverService(_DriverService);

                _DriverService = value;

                if (_DriverService != null)
                    AttachDriverService(_DriverService);
            }
        }
        private DriverService _DriverService;
        private IntPtr? _BrowserHandle;

        private void DetachDriverService(DriverService driverService) {
            if (_BrowserHandle.HasValue) {
                UnsafeNativeMethods.SetParent(_BrowserHandle.Value, IntPtr.Zero);
            }
        }

        public void AttachDriverService(DriverService service) {
            var driverProcess = Process.GetProcessById(service.ProcessId);

            var browserProcess = driverProcess.GetChildren()
                                    .Where(p => p.ProcessName != "conhost")
                                    .First();

            _BrowserHandle = browserProcess.MainWindowHandle;

            this.Resize += (sender, e) => {
                UnsafeNativeMethods.MoveWindow(_BrowserHandle.Value, 0, 0, Width, Height, true);
            };

            UnsafeNativeMethods.SetParent(_BrowserHandle.Value, this.Handle);
            UnsafeNativeMethods.MoveWindow(_BrowserHandle.Value, 0, 0, Width, Height, true);
        }
    }
}
