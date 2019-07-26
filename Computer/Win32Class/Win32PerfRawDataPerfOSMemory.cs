using System;
using System.Collections.Generic;
using System.Text;

namespace Computer.Win32Class
{
    public class Win32PerfRawDataPerfOSMemory : Win32PerfRawData
    {
        private UInt64 availableBytes;
        private UInt64 availableKBytes;
        private UInt64 availableMBytes;
        private UInt64 cacheBytes;
        private UInt64 cacheBytesPeak;
        private UInt32 cacheFaultsPerSec;
        private UInt64 commitLimit;
        private UInt64 committedBytes;
        private UInt32 demandZeroFaultsPerSec;
        private UInt32 freeSystemPageTableEntries;
        private UInt32 pageFaultsPerSec;
        private UInt32 pageReadsPerSec;
        private UInt32 pagesInputPerSec;
        private UInt32 pagesOutputPerSec;
        private UInt32 pagesPerSec;
        private UInt32 pageWritesPerSec;
        private UInt32 percentCommittedBytesInUse;
        private UInt32 percentCommittedBytesInUse_Base;
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
        private UInt32 transitionFaultsPerSec;
        private UInt32 writeCopiesPerSec;

        /// <summary>
        ///运行在计算机上进程的物理内荐的总字节量
        /// </summary>        
        public UInt64 AvailableBytes
        {
            get { return availableBytes; }
            set { availableBytes = value; }
        }
        /// <summary>
        ///运行在计算机上进程的物理内荐的千字节数
        /// </summary>
        public UInt64 AvailableKBytes
        {
            get { return availableKBytes; }
            set { availableKBytes = value; }
        }
        /// <summary>
        /// 运行在计算机上进程的物理内荐的兆字节数
        /// </summary>
        public UInt64 AvailableMBytes
        {
            get { return availableMBytes; }
            set { availableMBytes = value; }
        }
        /// <summary>
        ///当前正在使用的文件系统缓荐的字节数
        /// </summary>        
        public UInt64 CacheBytes
        {
            get { return cacheBytes; }
            set { cacheBytes = value; }
        }
        /// <summary>
        ///在系统重启后最大的缓存数
        /// </summary>        
        public UInt64 CacheBytesPeak
        {
            get { return cacheBytesPeak; }
            set { cacheBytesPeak = value; }
        }
        /// <summary>
        ///when a page sought in the file system cache is not found there and must be retrieved from elsewhere in memory (soft fault) or from disk (hard fault).
        /// </summary>
        //当在文件系统中没有建立发出一页时发生错误的数量在那儿从内荐中或其它硬盘上必须被找回.
        public UInt32 CacheFaultsPerSec
        {
            get { return cacheFaultsPerSec; }
            set { cacheFaultsPerSec = value; }
        }
        /// <summary>
        ///对统计数据和指标的短的原文说明 
        /// </summary>        
        public UInt64 CommitLimit
        {
            get { return commitLimit; }
            set { commitLimit = value; }
        }
        /// <summary>
        ///虚拟内荐的总数,用字节,它能使用在没有扩展的文件名
        /// </summary>        
        public UInt64 CommittedBytes
        {
            get { return committedBytes; }
            set { committedBytes = value; }
        }
        /// <summary>
        ///过错页的数量,需要一个零页
        /// </summary>        
        public UInt32 DemandZeroFaultsPerSec
        {
            get { return demandZeroFaultsPerSec; }
            set { demandZeroFaultsPerSec = value; }
        }
        /// <summary>
        /// //系统没有使用时页的条目数量
        /// </summary>        
        public UInt32 FreeSystemPageTableEntries
        {
            get { return freeSystemPageTableEntries; }
            set { freeSystemPageTableEntries = value; }
        }
        /// <summary>
        ///从处理器中得到的失败页句柄的比率
        /// </summary>       
        public UInt32 PageFaultsPerSec
        {
            get { return pageFaultsPerSec; }
            set { pageFaultsPerSec = value; }
        }
        /// <summary>
        ///读解决硬盘分页错误的时间数量
        /// </summary>        
        public UInt32 PageReadsPerSec
        {
            get { return pageReadsPerSec; }
            set { pageReadsPerSec = value; }
        }
        /// <summary>
        ///读时,需要解快硬盘分页错误的页的数量
        /// </summary>
        public UInt32 PagesInputPerSec
        {
            get { return pagesInputPerSec; }
            set { pagesInputPerSec = value; }
        }
        /// <summary>
        ///写时,需要解快硬盘分页错误的页的数量
        /// </summary>
        public UInt32 PagesOutputPerSec
        {
            get { return pagesOutputPerSec; }
            set { pagesOutputPerSec = value; }
        }
        /// <summary>
        ///从硬盘上读和写时分页错误的数量
        /// </summary>       
        public UInt32 PagesPerSec
        {
            get { return pagesPerSec; }
            set { pagesPerSec = value; }
        }
        /// <summary>
        /// 从硬盘上写时,分页错误的数量
        /// </summary>
        public UInt32 PageWritesPerSec
        {
            get { return pageWritesPerSec; }
            set { pageWritesPerSec = value; }
        }
        /// <summary>
        ///记忆比率 
        /// </summary>
        public UInt32 PercentCommittedBytesInUse
        {
            get { return percentCommittedBytesInUse; }
            set { percentCommittedBytesInUse = value; }
        }
        /// <summary>
        /// PercentCommittedBytesInUse的Base值
        /// </summary>
        public UInt32 PercentCommittedBytesInUse_Base
        {
            get { return percentCommittedBytesInUse_Base; }
            set { percentCommittedBytesInUse_Base = value; }
        }
        /// <summary>
        ///未调页池字节数,只管总记不管分配的数量
        /// </summary>        
        public UInt32 PoolNonpagedAllocs
        {
            get { return poolNonpagedAllocs; }
            set { poolNonpagedAllocs = value; }
        }
        /// <summary>
        /// 未调页池字节数
        /// </summary>
        public UInt64 PoolNonpagedBytes
        {
            get { return poolNonpagedBytes; }
            set { poolNonpagedBytes = value; }
        }
        /// <summary>
        /// 已调页池总字节数
        /// </summary>
        public UInt32 PoolPagedAllocs
        {
            get { return poolPagedAllocs; }
            set { poolPagedAllocs = value; }
        }
        /// <summary>
        /// 已调页池字节数 
        /// </summary>
        public UInt64 PoolPagedBytes
        {
            get { return poolPagedBytes; }
            set { poolPagedBytes = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public UInt64 PoolPagedResidentBytes
        {
            get { return poolPagedResidentBytes; }
            set { poolPagedResidentBytes = value; }
        }
        /// <summary>
        ///在操作系统上文件系统缓荐可用页的字节数
        /// </summary>        
        public UInt64 SystemCacheResidentBytes
        {
            get { return systemCacheResidentBytes; }
            set { systemCacheResidentBytes = value; }
        }
        /// <summary>
        ///操作系统当前用的物理内荐能被写到硬盘上当不再使用时
        /// </summary>        
        public UInt64 SystemCodeResidentBytes
        {
            get { return systemCodeResidentBytes; }
            set { systemCodeResidentBytes = value; }
        }
        /// <summary>
        ///当前系统使用的虚拟内荐数量
        /// </summary>        
        public UInt64 SystemCodeTotalBytes
        {
            get { return systemCodeTotalBytes; }
            set { systemCodeTotalBytes = value; }
        }
        /// <summary>
        ///被驱动程序使用的物理内荐数量
        /// </summary>        
        public UInt64 SystemDriverResidentBytes
        {
            get { return systemDriverResidentBytes; }
            set { systemDriverResidentBytes = value; }
        }
        /// <summary>
        ///当前被驱动使用的虚拟内荐数量
        /// </summary>        
        public UInt64 SystemDriverTotalBytes
        {
            get { return systemDriverTotalBytes; }
            set { systemDriverTotalBytes = value; }
        }
        /// <summary>
        /// Number of page faults resolved by recovering pages that were on the modified page list, on the standby list, or being written to disk at the time of the page fault
        /// </summary>
        public UInt32 TransitionFaultsPerSec
        {
            get { return transitionFaultsPerSec; }
            set { transitionFaultsPerSec = value; }
        }
        /// <summary>
        /// Number of page faults caused by attempts to write that have been satisfied by copying the page from elsewhere in physical memory
        /// </summary>
        public UInt32 WriteCopiesPerSec
        {
            get { return writeCopiesPerSec; }
            set { writeCopiesPerSec = value; }
        }

    }
}
