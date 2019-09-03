﻿using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;

namespace FacilityMonitoring.Common.Model {
    //High: High=true
    //Low:  Low=true
    public enum LogicType { HIGH, LOW }
    public enum Direction { INPUT,OUTPUT}

    public abstract class Channel {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ChannelNumber { get; set; }
        public bool Connected { get; set; }
        public bool Bypass { get; set; }
        public string PropertyMap { get; set; }

        public int GenericMonitorBoxId { get; set; }
        public virtual GenericMonitorBox GenericMonitorBox { get; set; }

    }

    public partial class AnalogChannel:Channel  {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public int ChannelNumber { get; set; }
        //public bool Connected { get; set; }
        //public bool Bypass { get; set; }

        //public int GenericMonitorBoxId { get; set; }
        //public virtual GenericMonitorBox GenericMonitorBox { get; set; }

        public int? SensorTypeId { get; set; }
        public virtual SensorType SensorType { get; set; }

        public double Slope { get; set; }
        public double Offset { get; set; }
        public double Resistance { get; set; }

        public double Alarm1SetPoint { get; set; }
        public double Alarm2SetPoint { get; set; }
        public double Alarm3SetPoint { get; set; }

        public AnalogChannel(string name, int chnum, bool connected, bool bypass){
            this.Name = name;
            this.ChannelNumber = chnum;
            this.Connected = connected;
            this.Bypass = bypass;

        }

        public AnalogChannel() {

        }

    }

    public partial class DigitalChannel:Channel  {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public int ChannelNumber { get; set; }
        //public bool Connected { get; set; }
        //public bool Bypass { get; set; }

        //public int GenericMonitorBoxId { get; set; }
        //public virtual GenericMonitorBox GenericMonitorBox { get; set; }

        public LogicType Logic { get; set; }
        public Direction Direction { get; set; }

        public DigitalChannel(string name, int chnum, bool connected, bool bypass,LogicType ltype,Direction dir) {
            this.Logic = ltype;
            this.Direction = dir;
            this.Name = name;
            this.ChannelNumber = chnum;
            this.Connected = connected;
            this.Bypass = bypass;
        }

        public DigitalChannel() {

        }
    }
}
