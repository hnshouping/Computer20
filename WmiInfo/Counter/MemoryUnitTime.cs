using System;
using System.Collections.Generic;
using System.Text;
using Computer.Win32Class;
using System.Threading;

namespace WmiInfo.Counter
{
    public class MemoryUnitTime
    {
        private WmiPerfRawDataPerfOSMemory mca;

        private UInt64 frequency_PerfTime;

        private UInt64 availableBytes;
        private UInt64 availableKBytes;
        private UInt64 availableMBytes;
        private UInt64 cacheBytes;
        private UInt64 cacheBytesPeak;
        private UInt64 commitLimit;
        private UInt64 committedBytes;
        private UInt32 freeSystemPageTableEntries;
        private UInt32 poolNonpagedAllocs;
        private UInt64 poolNonpagedBytes;
        private UInt32 poolPagedAllocs;
        private UInt64 poolPagedBytes;
        private UInt64 poolPagedResidentBytes;
        private UInt64 systemCacheResidentBytes;
        private UInt64 systemCodeResidentBytes;
        private UInt64 systemCodeTotalBytes;
        private UInt64 systemDriverResidentBytes;
        private UInt64 systemDriverTotalBytes;


        private uint newcacheFaultsPersec;
        private uint oldcacheFaultsPersec;

        private UInt64 newtimestamp_PerfTime;
        private UInt64 oldtimestamp_PerfTime;

        private UInt32 newdemandZeroFaultsPersec;
        private UInt32 olddemandZeroFaultsPersec;

        private UInt32 newpageFaultsPersec;
        private UInt32 oldpageFaultsPersec;

        private UInt32 newpageReadsPersec;
        private UInt32 oldpageReadsPersec;

        private UInt32 newpagesInputPersec;
        private UInt32 oldpagesInputPersec;

        private UInt32 newpagesOutputPersec;
        private UInt32 oldpagesOutputPersec;

        private UInt32 newpagesPersec;
        private UInt32 oldpagesPersec;

        private UInt32 newpageWritesPersec;
        private UInt32 oldpageWritesPersec;

        private UInt32 percentCommittedBytesInUse;
        private UInt32 percentCommittedBytesInUse_Base;

        private UInt32 newtransitionFaultsPersec;
        private UInt32 oldtransitionFaultsPersec;

        private UInt32 newwriteCopiesPersec;
        private UInt32 oldwriteCopiesPersec;


        public MemoryUnitTime()
        {
            mca = new WmiPerfRawDataPerfOSMemory();
            Win32PerfRawDataPerfOSMemory mc = mca.Win32PerfRawDataPerfOSMemorys[mca.Win32PerfRawDataPerfOSMemorysLength  - 1];
            availableBytes = mc.AvailableBytes;
            availableKBytes = mc.AvailableKBytes;
            availableMBytes = mc.AvailableMBytes;
            cacheBytes = mc.CacheBytes;
            cacheBytesPeak = mc.CacheBytesPeak;
            oldcacheFaultsPersec = mc.CacheFaultsPerSec;
            oldtimestamp_PerfTime = mc.Timestamp_PerfTime;
            frequency_PerfTime = mc.Frequency_PerfTime;
            commitLimit = mc.CommitLimit;
            committedBytes = mc.CommittedBytes;
            olddemandZeroFaultsPersec = mc.DemandZeroFaultsPerSec;
            freeSystemPageTableEntries = mc.FreeSystemPageTableEntries;
            oldpageFaultsPersec = mc.PageFaultsPerSec;
            oldpageReadsPersec = mc.PageFaultsPerSec;
            oldpagesInputPersec = mc.PagesInputPerSec;
            oldpagesOutputPersec = mc.PagesOutputPerSec;
            oldpagesPersec = mc.PagesPerSec;
            oldpageWritesPersec = mc.PageWritesPerSec;
            percentCommittedBytesInUse = mc.PercentCommittedBytesInUse;
            percentCommittedBytesInUse_Base = mc.PercentCommittedBytesInUse_Base;
            poolNonpagedAllocs = mc.PoolNonpagedAllocs;
            poolNonpagedBytes = mc.PoolNonpagedBytes;
            poolPagedAllocs = mc.PoolPagedAllocs;
            poolPagedBytes = mc.PoolPagedBytes;
            poolPagedResidentBytes = mc.PoolPagedResidentBytes;
            systemCacheResidentBytes = mc.SystemCacheResidentBytes;
            systemCodeResidentBytes = mc.SystemCodeResidentBytes;
            systemCodeTotalBytes = mc.SystemCodeTotalBytes;
            systemDriverResidentBytes = mc.SystemDriverResidentBytes;
            systemDriverTotalBytes = mc.SystemDriverTotalBytes;
            oldtransitionFaultsPersec = mc.TransitionFaultsPerSec;
            oldwriteCopiesPersec = mc.WriteCopiesPerSec;

            Thread.Sleep(1000);

            mca = new WmiPerfRawDataPerfOSMemory();
            Win32PerfRawDataPerfOSMemory mc1 = mca.Win32PerfRawDataPerfOSMemorys[mca.Win32PerfRawDataPerfOSMemorysLength - 1]; 
            newcacheFaultsPersec = mc1.CacheFaultsPerSec;
            newtimestamp_PerfTime = mc1.Timestamp_PerfTime;
            newdemandZeroFaultsPersec = mc1.DemandZeroFaultsPerSec;
            newpageFaultsPersec = mc1.PageFaultsPerSec;
            newpageReadsPersec = mc1.PageFaultsPerSec;
            newpagesInputPersec = mc1.PagesInputPerSec;
            newpagesOutputPersec = mc1.PagesOutputPerSec;
            newpagesPersec = mc1.PagesPerSec;
            newpageWritesPersec = mc1.PageWritesPerSec;
            newtransitionFaultsPersec = mc1.TransitionFaultsPerSec;
            newwriteCopiesPersec = mc1.WriteCopiesPerSec;


        }
        public MemoryUnitTime(string ip, string username, string password)
        {
            Win32PerfRawDataPerfOSMemory mc = mca.Win32PerfRawDataPerfOSMemorys[mca.Win32PerfRawDataPerfOSMemorysLength - 1];
            availableBytes = mc.AvailableBytes;
            availableKBytes = mc.AvailableKBytes;
            availableMBytes = mc.AvailableMBytes;
            cacheBytes = mc.CacheBytes;
            cacheBytesPeak = mc.CacheBytesPeak;
            oldcacheFaultsPersec = mc.CacheFaultsPerSec;
            oldtimestamp_PerfTime = mc.Timestamp_PerfTime;
            frequency_PerfTime = mc.Frequency_PerfTime;
            commitLimit = mc.CommitLimit;
            committedBytes = mc.CommittedBytes;
            olddemandZeroFaultsPersec = mc.DemandZeroFaultsPerSec;
            freeSystemPageTableEntries = mc.FreeSystemPageTableEntries;
            oldpageFaultsPersec = mc.PageFaultsPerSec;
            oldpageReadsPersec = mc.PageFaultsPerSec;
            oldpagesInputPersec = mc.PagesInputPerSec;
            oldpagesOutputPersec = mc.PagesOutputPerSec;
            oldpagesPersec = mc.PagesPerSec;
            oldpageWritesPersec = mc.PageWritesPerSec;
            percentCommittedBytesInUse = mc.PercentCommittedBytesInUse;
            percentCommittedBytesInUse_Base = mc.PercentCommittedBytesInUse_Base;
            poolNonpagedAllocs = mc.PoolNonpagedAllocs;
            poolNonpagedBytes = mc.PoolNonpagedBytes;
            poolPagedAllocs = mc.PoolPagedAllocs;
            poolPagedBytes = mc.PoolPagedBytes;
            poolPagedResidentBytes = mc.PoolPagedResidentBytes;
            systemCacheResidentBytes = mc.SystemCacheResidentBytes;
            systemCodeResidentBytes = mc.SystemCodeResidentBytes;
            systemCodeTotalBytes = mc.SystemCodeTotalBytes;
            systemDriverResidentBytes = mc.SystemDriverResidentBytes;
            systemDriverTotalBytes = mc.SystemDriverTotalBytes;
            oldtransitionFaultsPersec = mc.TransitionFaultsPerSec;
            oldwriteCopiesPersec = mc.WriteCopiesPerSec;

            Thread.Sleep(1000);

            Thread.Sleep(1000);

            mca = new WmiPerfRawDataPerfOSMemory(ip, username, password);
            Win32PerfRawDataPerfOSMemory mc1 = mca.Win32PerfRawDataPerfOSMemorys[mca.Win32PerfRawDataPerfOSMemorysLength - 1];
            newcacheFaultsPersec = mc1.CacheFaultsPerSec;
            newtimestamp_PerfTime = mc1.Timestamp_PerfTime;
            newdemandZeroFaultsPersec = mc1.DemandZeroFaultsPerSec;
            newpageFaultsPersec = mc1.PageFaultsPerSec;
            newpageReadsPersec = mc1.PageFaultsPerSec;
            newpagesInputPersec = mc1.PagesInputPerSec;
            newpagesOutputPersec = mc1.PagesOutputPerSec;
            newpagesPersec = mc1.PagesPerSec;
            newpageWritesPersec = mc1.PageWritesPerSec;
            newtransitionFaultsPersec = mc1.TransitionFaultsPerSec;
            newwriteCopiesPersec = mc1.WriteCopiesPerSec;
        }
        public ulong AvailableBytes
        {
            get { return this.availableBytes; }
        }
        public ulong AvailableKBytes
        {
            get { return this.availableKBytes; }
        }
        public ulong AvailableMBytes
        {
            get { return this.availableMBytes; }
        }
        public ulong CacheBytes
        {
            get { return this.cacheBytes; }
        }
        public ulong CacheBytesPeak
        {
            get { return this.cacheBytesPeak; }
        }
        public Decimal CacheFaultsPersecUnit
        {
            get
            {
                return Common.PERF_COUNTER_COUNTER(newcacheFaultsPersec, oldcacheFaultsPersec
                    , newtimestamp_PerfTime, oldtimestamp_PerfTime, frequency_PerfTime);
            }
        }
        public ulong CommitLimit
        {
            get { return this.commitLimit; }
        }
        public ulong CommittedBytes
        {
            get { return this.committedBytes; }
        }
        public Decimal DemandZeroFaultsPersecUnit
        {
            get
            {
                return Common.PERF_COUNTER_COUNTER(newdemandZeroFaultsPersec, olddemandZeroFaultsPersec
                    , newtimestamp_PerfTime, oldtimestamp_PerfTime, frequency_PerfTime);
            }
        }
        public uint FreeSystemPageTableEntries
        {
            get { return this.freeSystemPageTableEntries; }
        }
        public Decimal PageFaultsPersecUnit
        {
            get
            {
                return Common.PERF_COUNTER_COUNTER(newpageFaultsPersec, oldpageFaultsPersec
                    , newtimestamp_PerfTime, oldtimestamp_PerfTime, frequency_PerfTime);
            }
        }
        public Decimal PageReadsPersecUnit
        {
            get
            {
                return Common.PERF_COUNTER_COUNTER(newpageReadsPersec, oldpageReadsPersec
                    , newtimestamp_PerfTime, oldtimestamp_PerfTime, frequency_PerfTime);
            }
        }
        public Decimal PagesInputPersecUnit
        {
            get
            {
                return Common.PERF_COUNTER_COUNTER(newpagesInputPersec, oldpagesInputPersec
                    , newtimestamp_PerfTime, oldtimestamp_PerfTime, frequency_PerfTime);
            }
        }
        public Decimal PagesOutputPersecUnit
        {
            get
            {
                return Common.PERF_COUNTER_COUNTER(newpagesOutputPersec, oldpagesOutputPersec
                    , newtimestamp_PerfTime, oldtimestamp_PerfTime, frequency_PerfTime);
            }
        }
        public Decimal PagesPersecUnit
        {
            get
            {
                return Common.PERF_COUNTER_COUNTER(newpagesPersec, oldpagesPersec
                    , newtimestamp_PerfTime, oldtimestamp_PerfTime, frequency_PerfTime);
            }
        }
        public Decimal PageWritesPersecUnit
        {
            get
            {
                return Common.PERF_COUNTER_COUNTER(newpageWritesPersec, oldpageWritesPersec
                    , newtimestamp_PerfTime, oldtimestamp_PerfTime, frequency_PerfTime);
            }
        }
        public Decimal PercentCommittedBytesInUse
        {
            get
            {
                return Common.PERF_RAW_FRACTION(percentCommittedBytesInUse, percentCommittedBytesInUse_Base);
            }
        }
        public uint PoolNonpagedAllocs
        {
            get { return this.poolNonpagedAllocs; }
        }
        public ulong PoolNonpagedBytes
        {
            get { return this.poolNonpagedBytes; }
        }
        public uint PoolPagedAllocs
        {
            get { return this.poolPagedAllocs; }
        }
        public ulong PoolPagedBytes
        {
            get { return this.poolPagedBytes; }
        }
        public ulong PoolPagedResidentBytes
        {
            get { return this.poolPagedResidentBytes; }
        }
        public ulong SystemCacheResidentBytes
        {
            get { return this.systemCacheResidentBytes; }
        }
        public ulong SystemCodeResidentBytes
        {
            get { return this.systemCodeResidentBytes; }
        }
        public ulong SystemCodeTotalBytes
        {
            get { return this.systemCodeTotalBytes; }
        }
        public ulong SystemDriverResidentBytes
        {
            get { return this.systemDriverResidentBytes; }
        }
        public ulong SystemDriverTotalBytes
        {
            get { return this.systemDriverTotalBytes; }
        }
        public Decimal TransitionFaultsPersecUnit//=mc.;
        {
            get
            {
                return Common.PERF_COUNTER_COUNTER(newtransitionFaultsPersec, oldtransitionFaultsPersec
                    , newtimestamp_PerfTime, oldtimestamp_PerfTime, frequency_PerfTime);
            }
        }
        public Decimal WriteCopiesPersecUnit//=mc.;
        {
            get
            {
                return Common.PERF_COUNTER_COUNTER(newwriteCopiesPersec, oldwriteCopiesPersec
                    , newtimestamp_PerfTime, oldtimestamp_PerfTime, frequency_PerfTime);
            }
        }
    }
}
