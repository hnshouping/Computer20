using System;
using System.Collections.Generic;
using System.Text;

namespace Computer
{
    public class CIMCard : CIMPhysicalPackage
    {
        private bool hostingBoard;
        private string requirementsDescription;
        private bool requiresDaughterBoard;
        private string slotLayout;
        private bool specialRequirements;

        /// <summary>
        /// ������棬�⿨�ǵװ壬������ֻ��һ�����̵Ļ���
        /// </summary>
        public bool HostingBoard
        {
            get { return hostingBoard; }
            set { hostingBoard = value; }
        }
        /// <summary>
        /// �⿨���������Ļ���Ҫ��
        /// </summary>
        public string RequirementsDescription
        {
            get { return requirementsDescription; }
            set { requirementsDescription = value; }
        }
        /// <summary>
        /// ����棬�����ӿ��Ǳ���ġ�
        /// </summary>
        public bool RequiresDaughterBoard
        {
            get { return requiresDaughterBoard; }
            set { requiresDaughterBoard = value; }
        }
        /// <summary>
        /// �Կ��ϲ۵�����
        /// </summary>
        public string SlotLayout
        {
            get { return slotLayout; }
            set { slotLayout = value; }
        }
        /// <summary>
        /// �Բ۵�����Ҫ��
        /// </summary>
        public bool SpecialRequirements
        {
            get { return specialRequirements; }
            set { specialRequirements = value; }
        }        
    }
}
