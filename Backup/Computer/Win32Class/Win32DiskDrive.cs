using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Computer.Win32Class
{
    public class Win32DiskDrive : CIMDiskDrive
    {
        private UInt32 bytesPerSector;
        private UInt32 index;
        private string interfaceType;
        private string manufacturer;
        private bool mediaLoaded;
        private string mediaType;
        private string model;
        private UInt32 partitions;
        private UInt32 sCSIBus;
        private UInt16 sCSILogicalUnit;
        private UInt16 sCSIPort;
        private UInt16 sCSITargetId;
        private UInt32 sectorsPerTrack;
        private UInt32 signature;
        private UInt64 size;
        private UInt64 totalCylinders;
        private UInt32 totalHeads;
        private UInt64 totalSectors;
        private UInt64 totalTracks;
        private UInt32 tracksPerCylinder;


        public UInt32 BytesPerSector
        {
            get { return bytesPerSector; }
            set { bytesPerSector = value; }
        }
        public UInt32 Index
        {
            get { return index; }
            set { index = value; }
        }
        public string InterfaceType
        {
            get { return interfaceType; }
            set { interfaceType = value; }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }
        public bool MediaLoaded
        {
            get { return mediaLoaded; }
            set { mediaLoaded = value; }
        }
        public string MediaType
        {
            get { return mediaType; }
            set { mediaType = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public UInt32 Partitions
        {
            get { return partitions; }
            set { partitions = value; }
        }
        public UInt32 SCSIBus
        {
            get { return sCSIBus; }
            set { sCSIBus = value; }
        }
        public UInt16 SCSILogicalUnit
        {
            get { return sCSILogicalUnit; }
            set { sCSILogicalUnit = value; }
        }
        public UInt16 SCSIPort
        {
            get { return sCSIPort; }
            set { sCSIPort = value; }
        }
        public UInt16 SCSITargetId
        {
            get { return sCSITargetId; }
            set { sCSITargetId = value; }
        }
        public UInt32 SectorsPerTrack
        {
            get { return sectorsPerTrack; }
            set { sectorsPerTrack = value; }
        }
        public UInt32 Signature
        {
            get { return signature; }
            set { signature = value; }
        }
        public UInt64 Size
        {
            get { return size; }
            set { size = value; }
        }
        public UInt64 TotalCylinders
        {
            get { return totalCylinders; }
            set { totalCylinders = value; }
        }
        public UInt32 TotalHeads
        {
            get { return totalHeads; }
            set { totalHeads = value; }
        }
        public UInt64 TotalSectors
        {
            get { return totalSectors; }
            set { totalSectors = value; }
        }
        public UInt64 TotalTracks
        {
            get { return totalTracks; }
            set { totalTracks = value; }
        }
        public UInt32 TracksPerCylinder
        {
            get { return tracksPerCylinder; }
            set { tracksPerCylinder = value; }
        }



        public override uint Reset()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override uint SetPowerState(ushort PowerState, DateTime Time)
        {
            throw new Exception("The method or operation is not implemented.");
        }
        public Win32DiskDrive()
        {
        }
    }
}
