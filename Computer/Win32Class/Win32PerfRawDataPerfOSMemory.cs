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
        ///�����ڼ�����Ͻ��̵������ڼ������ֽ���
        /// </summary>        
        public UInt64 AvailableBytes
        {
            get { return availableBytes; }
            set { availableBytes = value; }
        }
        /// <summary>
        ///�����ڼ�����Ͻ��̵������ڼ���ǧ�ֽ���
        /// </summary>
        public UInt64 AvailableKBytes
        {
            get { return availableKBytes; }
            set { availableKBytes = value; }
        }
        /// <summary>
        /// �����ڼ�����Ͻ��̵������ڼ������ֽ���
        /// </summary>
        public UInt64 AvailableMBytes
        {
            get { return availableMBytes; }
            set { availableMBytes = value; }
        }
        /// <summary>
        ///��ǰ����ʹ�õ��ļ�ϵͳ�������ֽ���
        /// </summary>        
        public UInt64 CacheBytes
        {
            get { return cacheBytes; }
            set { cacheBytes = value; }
        }
        /// <summary>
        ///��ϵͳ���������Ļ�����
        /// </summary>        
        public UInt64 CacheBytesPeak
        {
            get { return cacheBytesPeak; }
            set { cacheBytesPeak = value; }
        }
        /// <summary>
        ///when a page sought in the file system cache is not found there and must be retrieved from elsewhere in memory (soft fault) or from disk (hard fault).
        /// </summary>
        //�����ļ�ϵͳ��û�н�������һҳʱ����������������Ƕ����ڼ��л�����Ӳ���ϱ��뱻�һ�.
        public UInt32 CacheFaultsPerSec
        {
            get { return cacheFaultsPerSec; }
            set { cacheFaultsPerSec = value; }
        }
        /// <summary>
        ///��ͳ�����ݺ�ָ��Ķ̵�ԭ��˵�� 
        /// </summary>        
        public UInt64 CommitLimit
        {
            get { return commitLimit; }
            set { commitLimit = value; }
        }
        /// <summary>
        ///�����ڼ�������,���ֽ�,����ʹ����û����չ���ļ���
        /// </summary>        
        public UInt64 CommittedBytes
        {
            get { return committedBytes; }
            set { committedBytes = value; }
        }
        /// <summary>
        ///����ҳ������,��Ҫһ����ҳ
        /// </summary>        
        public UInt32 DemandZeroFaultsPerSec
        {
            get { return demandZeroFaultsPerSec; }
            set { demandZeroFaultsPerSec = value; }
        }
        /// <summary>
        /// //ϵͳû��ʹ��ʱҳ����Ŀ����
        /// </summary>        
        public UInt32 FreeSystemPageTableEntries
        {
            get { return freeSystemPageTableEntries; }
            set { freeSystemPageTableEntries = value; }
        }
        /// <summary>
        ///�Ӵ������еõ���ʧ��ҳ����ı���
        /// </summary>       
        public UInt32 PageFaultsPerSec
        {
            get { return pageFaultsPerSec; }
            set { pageFaultsPerSec = value; }
        }
        /// <summary>
        ///�����Ӳ�̷�ҳ�����ʱ������
        /// </summary>        
        public UInt32 PageReadsPerSec
        {
            get { return pageReadsPerSec; }
            set { pageReadsPerSec = value; }
        }
        /// <summary>
        ///��ʱ,��Ҫ���Ӳ�̷�ҳ�����ҳ������
        /// </summary>
        public UInt32 PagesInputPerSec
        {
            get { return pagesInputPerSec; }
            set { pagesInputPerSec = value; }
        }
        /// <summary>
        ///дʱ,��Ҫ���Ӳ�̷�ҳ�����ҳ������
        /// </summary>
        public UInt32 PagesOutputPerSec
        {
            get { return pagesOutputPerSec; }
            set { pagesOutputPerSec = value; }
        }
        /// <summary>
        ///��Ӳ���϶���дʱ��ҳ���������
        /// </summary>       
        public UInt32 PagesPerSec
        {
            get { return pagesPerSec; }
            set { pagesPerSec = value; }
        }
        /// <summary>
        /// ��Ӳ����дʱ,��ҳ���������
        /// </summary>
        public UInt32 PageWritesPerSec
        {
            get { return pageWritesPerSec; }
            set { pageWritesPerSec = value; }
        }
        /// <summary>
        ///������� 
        /// </summary>
        public UInt32 PercentCommittedBytesInUse
        {
            get { return percentCommittedBytesInUse; }
            set { percentCommittedBytesInUse = value; }
        }
        /// <summary>
        /// PercentCommittedBytesInUse��Baseֵ
        /// </summary>
        public UInt32 PercentCommittedBytesInUse_Base
        {
            get { return percentCommittedBytesInUse_Base; }
            set { percentCommittedBytesInUse_Base = value; }
        }
        /// <summary>
        ///δ��ҳ���ֽ���,ֻ���ܼǲ��ܷ��������
        /// </summary>        
        public UInt32 PoolNonpagedAllocs
        {
            get { return poolNonpagedAllocs; }
            set { poolNonpagedAllocs = value; }
        }
        /// <summary>
        /// δ��ҳ���ֽ���
        /// </summary>
        public UInt64 PoolNonpagedBytes
        {
            get { return poolNonpagedBytes; }
            set { poolNonpagedBytes = value; }
        }
        /// <summary>
        /// �ѵ�ҳ�����ֽ���
        /// </summary>
        public UInt32 PoolPagedAllocs
        {
            get { return poolPagedAllocs; }
            set { poolPagedAllocs = value; }
        }
        /// <summary>
        /// �ѵ�ҳ���ֽ��� 
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
        ///�ڲ���ϵͳ���ļ�ϵͳ��������ҳ���ֽ���
        /// </summary>        
        public UInt64 SystemCacheResidentBytes
        {
            get { return systemCacheResidentBytes; }
            set { systemCacheResidentBytes = value; }
        }
        /// <summary>
        ///����ϵͳ��ǰ�õ������ڼ��ܱ�д��Ӳ���ϵ�����ʹ��ʱ
        /// </summary>        
        public UInt64 SystemCodeResidentBytes
        {
            get { return systemCodeResidentBytes; }
            set { systemCodeResidentBytes = value; }
        }
        /// <summary>
        ///��ǰϵͳʹ�õ������ڼ�����
        /// </summary>        
        public UInt64 SystemCodeTotalBytes
        {
            get { return systemCodeTotalBytes; }
            set { systemCodeTotalBytes = value; }
        }
        /// <summary>
        ///����������ʹ�õ������ڼ�����
        /// </summary>        
        public UInt64 SystemDriverResidentBytes
        {
            get { return systemDriverResidentBytes; }
            set { systemDriverResidentBytes = value; }
        }
        /// <summary>
        ///��ǰ������ʹ�õ������ڼ�����
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
