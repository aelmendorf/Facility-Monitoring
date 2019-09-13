﻿using FacilityMonitoring.Common.Model;
using System.Threading.Tasks;

namespace FacilityMonitoring.Common.Hardware {

    public interface IMonitorBoxHardwareOperations {
        GenericMonitorBox Device { get; set; }

        bool SetAlarm(bool on_off);
        Task<bool> SetAlarmAsync(bool on_off);

        bool SetWarning(bool on_off);
        Task<bool> SetWarningAsync(bool on_off);

        bool SetMaintenance(bool on_off);
        Task<bool> SetMaintenanceAsync(bool on_off);

        GenericBoxReading ReadAll();
        Task<GenericBoxReading> ReadAllAsync();
    }

    public interface IMonitorBoxData {

    }
}
