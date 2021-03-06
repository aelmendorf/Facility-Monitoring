﻿using System;
using System.Threading.Tasks;
using FacilityMonitoring.Common.Data.Entities;

namespace FacilityMonitoring.Common.ModbusServices.Operations {
    public interface IModbusOperations {
        string IpAddress { get; set; }
        int Port { get; set; }
        byte SlaveAddress { get; set; }

        ushort[] ReadRegisters(FunctionCode fc, int baseAddress, int length);
        Task<ushort[]> ReadRegistersAsync(FunctionCode fc,int address, int length);

        bool[] ReadCoils(int address, int length);
        Task<bool[]> ReadCoilsAsync(int address, int length);

        ushort[] ReadRegisters(int address, int length);
        Task<ushort[]> ReadRegistersAsync(int address, int length);

        Tuple<ushort[], bool[]> ReadRegistersAndCoils(int regAddress, int regLength, int coilAddr, int coilLength);
        Task<Tuple<ushort[], bool[]>> ReadRegistersAndCoilsAsync(int regAddress, int regLength, int coilAddr, int coilLength);

        bool WriteCoils(int address, bool[] values);
        Task<bool> WriteCoilsAsync(int address, bool[] values);

        bool WriteRegisters(int address, ushort[] values);
        Task<bool> WriteRegistersAsync(int address, ushort[] values);

        bool WriteSingleCoil(int address, bool value);
        Task<bool> WriteSingleCoilAsync(int address, bool value);

        bool WriteSingleRegister(int address, ushort value);
        Task<bool> WriteSingleRegisterAsync(int address, ushort value);
    }
}