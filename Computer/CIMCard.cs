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
        /// 如果是真，这卡是底板，甚至是只有一个底盘的基板
        /// </summary>
        public bool HostingBoard
        {
            get { return hostingBoard; }
            set { hostingBoard = value; }
        }
        /// <summary>
        /// 这卡对其它卡的基本要求
        /// </summary>
        public string RequirementsDescription
        {
            get { return requirementsDescription; }
            set { requirementsDescription = value; }
        }
        /// <summary>
        /// 如果真，扩充子卡是必需的。
        /// </summary>
        public bool RequiresDaughterBoard
        {
            get { return requiresDaughterBoard; }
            set { requiresDaughterBoard = value; }
        }
        /// <summary>
        /// 对卡上槽的描述
        /// </summary>
        public string SlotLayout
        {
            get { return slotLayout; }
            set { slotLayout = value; }
        }
        /// <summary>
        /// 对槽的特殊要求
        /// </summary>
        public bool SpecialRequirements
        {
            get { return specialRequirements; }
            set { specialRequirements = value; }
        }        
    }
}
