using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;

namespace AppHost.Selenium {
    internal static class ProcessExtensions {
        public static IEnumerable<Process> GetChildren(this Process parent) {
            var query = new ManagementObjectSearcher($@"
                SELECT *
                FROM Win32_Process
                WHERE ParentProcessId={parent.Id}");

            return from item in query.Get().OfType<ManagementBaseObject>()
                   let childProcessId = (int)(UInt32)item["ProcessId"]
                   select Process.GetProcessById(childProcessId);
        }

    }
}
