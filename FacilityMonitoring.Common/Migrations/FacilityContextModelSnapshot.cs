﻿// <auto-generated />
using System;
using FacilityMonitoring.Common.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FacilityMonitoring.Common.Migrations
{
    [DbContext(typeof(FacilityContext))]
    partial class FacilityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FacilityMonitoring.Common.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Category");
                });

            modelBuilder.Entity("FacilityMonitoring.Common.Model.Channel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Bypass");

                    b.Property<int>("ChannelNumber");

                    b.Property<bool>("Connected");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int>("GenericMonitorBoxId");

                    b.Property<string>("Name");

                    b.Property<string>("PropertyMap");

                    b.HasKey("Id");

                    b.HasIndex("GenericMonitorBoxId");

                    b.ToTable("Channels");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Channel");
                });

            modelBuilder.Entity("FacilityMonitoring.Common.Model.ModbusDevice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("DisplayName");

                    b.Property<string>("Identifier");

                    b.Property<string>("IpAddress");

                    b.Property<int>("Port");

                    b.Property<int>("SlaveAddress");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.ToTable("ModbusDevices");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ModbusDevice");
                });

            modelBuilder.Entity("FacilityMonitoring.Common.Model.Reading", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Identifier");

                    b.Property<int>("ModbusDeviceId");

                    b.Property<DateTime>("TimeStamp");

                    b.HasKey("Id");

                    b.HasIndex("ModbusDeviceId");

                    b.ToTable("Readings");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Reading");
                });

            modelBuilder.Entity("FacilityMonitoring.Common.Model.SensorType", b =>
                {
                    b.HasBaseType("FacilityMonitoring.Common.Model.Category");

                    b.Property<double>("MaxCalibration");

                    b.Property<double>("MaxValue");

                    b.Property<double>("ZeroCalibration");

                    b.Property<double>("ZeroValue");

                    b.HasDiscriminator().HasValue("SensorType");
                });

            modelBuilder.Entity("FacilityMonitoring.Common.Model.AnalogChannel", b =>
                {
                    b.HasBaseType("FacilityMonitoring.Common.Model.Channel");

                    b.Property<double>("Alarm1SetPoint");

                    b.Property<double>("Alarm2SetPoint");

                    b.Property<double>("Alarm3SetPoint");

                    b.Property<double>("Offset");

                    b.Property<double>("Resistance");

                    b.Property<int?>("SensorTypeId");

                    b.Property<double>("Slope");

                    b.HasIndex("SensorTypeId");

                    b.HasDiscriminator().HasValue("AnalogChannel");
                });

            modelBuilder.Entity("FacilityMonitoring.Common.Model.DigitalChannel", b =>
                {
                    b.HasBaseType("FacilityMonitoring.Common.Model.Channel");

                    b.Property<int>("Direction");

                    b.Property<int>("Logic");

                    b.HasDiscriminator().HasValue("DigitalChannel");
                });

            modelBuilder.Entity("FacilityMonitoring.Common.Model.GenericMonitorBox", b =>
                {
                    b.HasBaseType("FacilityMonitoring.Common.Model.ModbusDevice");

                    b.Property<int>("AnalogChannelCount");

                    b.Property<int>("DigitalInputChannelCount");

                    b.Property<int>("DigitalOutputChannelCount");

                    b.HasDiscriminator().HasValue("GenericMonitorBox");
                });

            modelBuilder.Entity("FacilityMonitoring.Common.Model.AmmoniaBoxReading", b =>
                {
                    b.HasBaseType("FacilityMonitoring.Common.Model.Reading");

                    b.Property<string>("ActiveTank");

                    b.Property<int>("Heater1DutyCycle");

                    b.Property<int>("Heater2DutyCycle");

                    b.Property<int>("Heater3DutyCycle");

                    b.Property<int>("Heater4DutyCycle");

                    b.Property<string>("Scale1Status");

                    b.Property<string>("Scale2Status");

                    b.Property<string>("Scale3Status");

                    b.Property<string>("Scale4Status");

                    b.Property<bool>("Tank1Alarm");

                    b.Property<int>("Tank1Tare");

                    b.Property<double>("Tank1Temperature");

                    b.Property<bool>("Tank1Warning");

                    b.Property<int>("Tank1Weight");

                    b.Property<bool>("Tank2Alarm");

                    b.Property<int>("Tank2Tare");

                    b.Property<double>("Tank2Temperature");

                    b.Property<bool>("Tank2Warning");

                    b.Property<int>("Tank2Weight");

                    b.Property<bool>("Tank3Alarm");

                    b.Property<int>("Tank3Tare");

                    b.Property<double>("Tank3Temperature");

                    b.Property<bool>("Tank3Warning");

                    b.Property<int>("Tank3Weight");

                    b.Property<bool>("Tank4Alarm");

                    b.Property<int>("Tank4Tare");

                    b.Property<double>("Tank4Temperature");

                    b.Property<bool>("Tank4Warning");

                    b.Property<int>("Tank4Weight");

                    b.HasDiscriminator().HasValue("AmmoniaBoxReading");
                });

            modelBuilder.Entity("FacilityMonitoring.Common.Model.GenericBoxReading", b =>
                {
                    b.HasBaseType("FacilityMonitoring.Common.Model.Reading");

                    b.Property<double>("AnalogCh1");

                    b.Property<double>("AnalogCh10");

                    b.Property<double>("AnalogCh11");

                    b.Property<double>("AnalogCh12");

                    b.Property<double>("AnalogCh13");

                    b.Property<double>("AnalogCh14");

                    b.Property<double>("AnalogCh15");

                    b.Property<double>("AnalogCh16");

                    b.Property<double>("AnalogCh2");

                    b.Property<double>("AnalogCh3");

                    b.Property<double>("AnalogCh4");

                    b.Property<double>("AnalogCh5");

                    b.Property<double>("AnalogCh6");

                    b.Property<double>("AnalogCh7");

                    b.Property<double>("AnalogCh8");

                    b.Property<double>("AnalogCh9");

                    b.Property<bool>("DigitalCh1");

                    b.Property<bool>("DigitalCh10");

                    b.Property<bool>("DigitalCh11");

                    b.Property<bool>("DigitalCh12");

                    b.Property<bool>("DigitalCh13");

                    b.Property<bool>("DigitalCh14");

                    b.Property<bool>("DigitalCh15");

                    b.Property<bool>("DigitalCh16");

                    b.Property<bool>("DigitalCh17");

                    b.Property<bool>("DigitalCh18");

                    b.Property<bool>("DigitalCh19");

                    b.Property<bool>("DigitalCh2");

                    b.Property<bool>("DigitalCh20");

                    b.Property<bool>("DigitalCh21");

                    b.Property<bool>("DigitalCh22");

                    b.Property<bool>("DigitalCh23");

                    b.Property<bool>("DigitalCh24");

                    b.Property<bool>("DigitalCh25");

                    b.Property<bool>("DigitalCh26");

                    b.Property<bool>("DigitalCh27");

                    b.Property<bool>("DigitalCh28");

                    b.Property<bool>("DigitalCh29");

                    b.Property<bool>("DigitalCh3");

                    b.Property<bool>("DigitalCh30");

                    b.Property<bool>("DigitalCh31");

                    b.Property<bool>("DigitalCh32");

                    b.Property<bool>("DigitalCh33");

                    b.Property<bool>("DigitalCh34");

                    b.Property<bool>("DigitalCh35");

                    b.Property<bool>("DigitalCh36");

                    b.Property<bool>("DigitalCh37");

                    b.Property<bool>("DigitalCh38");

                    b.Property<bool>("DigitalCh4");

                    b.Property<bool>("DigitalCh5");

                    b.Property<bool>("DigitalCh6");

                    b.Property<bool>("DigitalCh7");

                    b.Property<bool>("DigitalCh8");

                    b.Property<bool>("DigitalCh9");

                    b.Property<bool>("OutputCh1");

                    b.Property<bool>("OutputCh10");

                    b.Property<bool>("OutputCh2");

                    b.Property<bool>("OutputCh3");

                    b.Property<bool>("OutputCh4");

                    b.Property<bool>("OutputCh5");

                    b.Property<bool>("OutputCh6");

                    b.Property<bool>("OutputCh7");

                    b.Property<bool>("OutputCh8");

                    b.Property<bool>("OutputCh9");

                    b.HasDiscriminator().HasValue("GenericBoxReading");
                });

            modelBuilder.Entity("FacilityMonitoring.Common.Model.H2GenReading", b =>
                {
                    b.HasBaseType("FacilityMonitoring.Common.Model.Reading");

                    b.Property<bool>("A200_Drain_Valve");

                    b.Property<bool>("A200_Inlet_Valve");

                    b.Property<bool>("A200_Level_Empty");

                    b.Property<bool>("A200_Level_Flooded");

                    b.Property<bool>("A200_Level_High");

                    b.Property<bool>("A200_Level_Low");

                    b.Property<bool>("A300_Drain_Valve");

                    b.Property<bool>("A300_Level_Empty");

                    b.Property<bool>("A300_Level_Flooded");

                    b.Property<bool>("A300_Level_High");

                    b.Property<bool>("A300_Level_Low");

                    b.Property<string>("All_System_Errors");

                    b.Property<string>("All_System_Warnings");

                    b.Property<double>("Ambient_Temperature");

                    b.Property<double>("CG220_level");

                    b.Property<double>("DI_water_quality");

                    b.Property<bool>("Dryer_Valve1");

                    b.Property<bool>("Dryer_Valve2");

                    b.Property<bool>("Dryer_Valve3");

                    b.Property<bool>("Dryer_Valve4");

                    b.Property<double>("Ext_Water_Quality");

                    b.Property<double>("Heat_Exchanger_Water_Temp");

                    b.Property<double>("Heat_sink_Temperature");

                    b.Property<double>("Hydrogen_flow");

                    b.Property<int>("Operation_Mode");

                    b.Property<int>("PSV_A1");

                    b.Property<int>("PSV_A1_A2");

                    b.Property<int>("PSV_A3");

                    b.Property<int>("PSV_B1");

                    b.Property<int>("PSV_B2");

                    b.Property<int>("PSV_B3");

                    b.Property<int>("PSV_C1");

                    b.Property<int>("PSV_C2");

                    b.Property<int>("PSV_C3");

                    b.Property<int>("PS_Fault_A1");

                    b.Property<int>("PS_Fault_A2");

                    b.Property<int>("PS_Fault_A3");

                    b.Property<int>("PS_Fault_B1");

                    b.Property<int>("PS_Fault_B2");

                    b.Property<int>("PS_Fault_B3");

                    b.Property<int>("PS_Fault_C1");

                    b.Property<int>("PS_Fault_C2");

                    b.Property<int>("PS_Fault_C3");

                    b.Property<double>("Product_pressure");

                    b.Property<int>("Ps_card_enable_A1");

                    b.Property<int>("Ps_card_enable_A2");

                    b.Property<int>("Ps_card_enable_A3");

                    b.Property<int>("Ps_card_enable_B1");

                    b.Property<int>("Ps_card_enable_B2");

                    b.Property<int>("Ps_card_enable_B3");

                    b.Property<int>("Ps_card_enable_C1");

                    b.Property<int>("Ps_card_enable_C2");

                    b.Property<int>("Ps_card_enable_C3");

                    b.Property<bool>("Pump_control");

                    b.Property<bool>("Stack_A_Water_Flow");

                    b.Property<int>("Stack_A_monitor_Current");

                    b.Property<bool>("Stack_A_valve");

                    b.Property<bool>("Stack_B_Water_Flow");

                    b.Property<int>("Stack_B_monitor_Current");

                    b.Property<bool>("Stack_B_valve");

                    b.Property<bool>("Stack_C_Water_Flow");

                    b.Property<int>("Stack_C_monitor_Current");

                    b.Property<bool>("Stack_C_valve");

                    b.Property<double>("System_24V_power");

                    b.Property<double>("System_3V_power");

                    b.Property<double>("System_5V_power");

                    b.Property<double>("System_Pressure");

                    b.Property<int>("System_State");

                    b.Property<int>("System_mode");

                    b.Property<double>("Thermal_Control_Valve");

                    b.Property<bool>("Vent_Valve");

                    b.Property<double>("Water_Quality");

                    b.Property<double>("Water_Temperature");

                    b.Property<int>("ps_unit_status");

                    b.HasDiscriminator().HasValue("H2GenReading");
                });

            modelBuilder.Entity("FacilityMonitoring.Common.Model.Channel", b =>
                {
                    b.HasOne("FacilityMonitoring.Common.Model.GenericMonitorBox", "GenericMonitorBox")
                        .WithMany("Channels")
                        .HasForeignKey("GenericMonitorBoxId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FacilityMonitoring.Common.Model.Reading", b =>
                {
                    b.HasOne("FacilityMonitoring.Common.Model.ModbusDevice", "ModbusDevice")
                        .WithMany("Readings")
                        .HasForeignKey("ModbusDeviceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FacilityMonitoring.Common.Model.AnalogChannel", b =>
                {
                    b.HasOne("FacilityMonitoring.Common.Model.SensorType", "SensorType")
                        .WithMany("AnalogChannels")
                        .HasForeignKey("SensorTypeId");
                });
#pragma warning restore 612, 618
        }
    }
}
