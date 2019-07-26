using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters;
using System.IO;

namespace Computer
{
    public class CIMChip : CIMPhysicalComponent
    {
        private UInt16 formFactor;


        private Dictionary<ushort, string> dictionFormFactor;

        private byte[] arr ={
            0,1,0,0,0,255,255,255,255,1,
            0,0,0,0,0,0,0,4,1,0,0,
            0,226,1,83,121,115,116,101,109,46,67,
            111,108,108,101,99,116,105,111,110,115,46,
            71,101,110,101,114,105,99,46,68,105,99,
            116,105,111,110,97,114,121,96,50,91,91,
            83,121,115,116,101,109,46,85,73,110,116,
            49,54,44,32,109,115,99,111,114,108,105,
            98,44,32,86,101,114,115,105,111,110,61,
            50,46,48,46,48,46,48,44,32,67,117,
            108,116,117,114,101,61,110,101,117,116,114,
            97,108,44,32,80,117,98,108,105,99,75,
            101,121,84,111,107,101,110,61,98,55,55,
            97,53,99,53,54,49,57,51,52,101,48,
            56,57,93,44,91,83,121,115,116,101,109,
            46,83,116,114,105,110,103,44,32,109,115,
            99,111,114,108,105,98,44,32,86,101,114,
            115,105,111,110,61,50,46,48,46,48,46,
            48,44,32,67,117,108,116,117,114,101,61,
            110,101,117,116,114,97,108,44,32,80,117,
            98,108,105,99,75,101,121,84,111,107,101,
            110,61,98,55,55,97,53,99,53,54,49,
            57,51,52,101,48,56,57,93,93,4,0,
            0,0,7,86,101,114,115,105,111,110,8,
            67,111,109,112,97,114,101,114,8,72,97,
            115,104,83,105,122,101,13,75,101,121,86,
            97,108,117,101,80,97,105,114,115,0,3,
            0,3,8,146,1,83,121,115,116,101,109,
            46,67,111,108,108,101,99,116,105,111,110,
            115,46,71,101,110,101,114,105,99,46,71,
            101,110,101,114,105,99,69,113,117,97,108,
            105,116,121,67,111,109,112,97,114,101,114,
            96,49,91,91,83,121,115,116,101,109,46,
            85,73,110,116,49,54,44,32,109,115,99,
            111,114,108,105,98,44,32,86,101,114,115,
            105,111,110,61,50,46,48,46,48,46,48,
            44,32,67,117,108,116,117,114,101,61,110,
            101,117,116,114,97,108,44,32,80,117,98,
            108,105,99,75,101,121,84,111,107,101,110,
            61,98,55,55,97,53,99,53,54,49,57,
            51,52,101,48,56,57,93,93,8,230,1,
            83,121,115,116,101,109,46,67,111,108,108,
            101,99,116,105,111,110,115,46,71,101,110,
            101,114,105,99,46,75,101,121,86,97,108,
            117,101,80,97,105,114,96,50,91,91,83,
            121,115,116,101,109,46,85,73,110,116,49,
            54,44,32,109,115,99,111,114,108,105,98,
            44,32,86,101,114,115,105,111,110,61,50,
            46,48,46,48,46,48,44,32,67,117,108,
            116,117,114,101,61,110,101,117,116,114,97,
            108,44,32,80,117,98,108,105,99,75,101,
            121,84,111,107,101,110,61,98,55,55,97,
            53,99,53,54,49,57,51,52,101,48,56,
            57,93,44,91,83,121,115,116,101,109,46,
            83,116,114,105,110,103,44,32,109,115,99,
            111,114,108,105,98,44,32,86,101,114,115,
            105,111,110,61,50,46,48,46,48,46,48,
            44,32,67,117,108,116,117,114,101,61,110,
            101,117,116,114,97,108,44,32,80,117,98,
            108,105,99,75,101,121,84,111,107,101,110,
            61,98,55,55,97,53,99,53,54,49,57,
            51,52,101,48,56,57,93,93,91,93,24,
            0,0,0,9,2,0,0,0,37,0,0,
            0,9,3,0,0,0,4,2,0,0,0,
            146,1,83,121,115,116,101,109,46,67,111,
            108,108,101,99,116,105,111,110,115,46,71,
            101,110,101,114,105,99,46,71,101,110,101,
            114,105,99,69,113,117,97,108,105,116,121,
            67,111,109,112,97,114,101,114,96,49,91,
            91,83,121,115,116,101,109,46,85,73,110,
            116,49,54,44,32,109,115,99,111,114,108,
            105,98,44,32,86,101,114,115,105,111,110,
            61,50,46,48,46,48,46,48,44,32,67,
            117,108,116,117,114,101,61,110,101,117,116,
            114,97,108,44,32,80,117,98,108,105,99,
            75,101,121,84,111,107,101,110,61,98,55,
            55,97,53,99,53,54,49,57,51,52,101,
            48,56,57,93,93,0,0,0,0,7,3,
            0,0,0,0,1,0,0,0,24,0,0,
            0,3,228,1,83,121,115,116,101,109,46,
            67,111,108,108,101,99,116,105,111,110,115,
            46,71,101,110,101,114,105,99,46,75,101,
            121,86,97,108,117,101,80,97,105,114,96,
            50,91,91,83,121,115,116,101,109,46,85,
            73,110,116,49,54,44,32,109,115,99,111,
            114,108,105,98,44,32,86,101,114,115,105,
            111,110,61,50,46,48,46,48,46,48,44,
            32,67,117,108,116,117,114,101,61,110,101,
            117,116,114,97,108,44,32,80,117,98,108,
            105,99,75,101,121,84,111,107,101,110,61,
            98,55,55,97,53,99,53,54,49,57,51,
            52,101,48,56,57,93,44,91,83,121,115,
            116,101,109,46,83,116,114,105,110,103,44,
            32,109,115,99,111,114,108,105,98,44,32,
            86,101,114,115,105,111,110,61,50,46,48,
            46,48,46,48,44,32,67,117,108,116,117,
            114,101,61,110,101,117,116,114,97,108,44,
            32,80,117,98,108,105,99,75,101,121,84,
            111,107,101,110,61,98,55,55,97,53,99,
            53,54,49,57,51,52,101,48,56,57,93,
            93,4,252,255,255,255,228,1,83,121,115,
            116,101,109,46,67,111,108,108,101,99,116,
            105,111,110,115,46,71,101,110,101,114,105,
            99,46,75,101,121,86,97,108,117,101,80,
            97,105,114,96,50,91,91,83,121,115,116,
            101,109,46,85,73,110,116,49,54,44,32,
            109,115,99,111,114,108,105,98,44,32,86,
            101,114,115,105,111,110,61,50,46,48,46,
            48,46,48,44,32,67,117,108,116,117,114,
            101,61,110,101,117,116,114,97,108,44,32,
            80,117,98,108,105,99,75,101,121,84,111,
            107,101,110,61,98,55,55,97,53,99,53,
            54,49,57,51,52,101,48,56,57,93,44,
            91,83,121,115,116,101,109,46,83,116,114,
            105,110,103,44,32,109,115,99,111,114,108,
            105,98,44,32,86,101,114,115,105,111,110,
            61,50,46,48,46,48,46,48,44,32,67,
            117,108,116,117,114,101,61,110,101,117,116,
            114,97,108,44,32,80,117,98,108,105,99,
            75,101,121,84,111,107,101,110,61,98,55,
            55,97,53,99,53,54,49,57,51,52,101,
            48,56,57,93,93,2,0,0,0,3,107,
            101,121,5,118,97,108,117,101,0,1,14,
            0,0,6,5,0,0,0,7,85,110,107,
            110,111,119,110,1,250,255,255,255,252,255,
            255,255,1,0,6,7,0,0,0,5,79,
            116,104,101,114,1,248,255,255,255,252,255,
            255,255,2,0,6,9,0,0,0,3,83,
            73,80,1,246,255,255,255,252,255,255,255,
            3,0,6,11,0,0,0,3,68,73,80,
            1,244,255,255,255,252,255,255,255,4,0,
            6,13,0,0,0,3,90,73,80,1,242,
            255,255,255,252,255,255,255,5,0,6,15,
            0,0,0,3,83,79,74,1,240,255,255,
            255,252,255,255,255,6,0,6,17,0,0,
            0,11,80,114,111,112,114,105,101,116,97,
            114,121,1,238,255,255,255,252,255,255,255,
            7,0,6,19,0,0,0,4,83,73,77,
            77,1,236,255,255,255,252,255,255,255,8,
            0,6,21,0,0,0,4,68,73,77,77,
            1,234,255,255,255,252,255,255,255,9,0,
            6,23,0,0,0,4,84,83,79,80,1,
            232,255,255,255,252,255,255,255,10,0,6,
            25,0,0,0,3,80,71,65,1,230,255,
            255,255,252,255,255,255,11,0,6,27,0,
            0,0,4,82,73,77,77,1,228,255,255,
            255,252,255,255,255,12,0,6,29,0,0,
            0,6,83,79,68,73,77,77,1,226,255,
            255,255,252,255,255,255,13,0,6,31,0,
            0,0,5,83,82,73,77,77,1,224,255,
            255,255,252,255,255,255,14,0,6,33,0,
            0,0,3,83,77,68,1,222,255,255,255,
            252,255,255,255,15,0,6,35,0,0,0,
            4,83,83,77,80,1,220,255,255,255,252,
            255,255,255,16,0,6,37,0,0,0,3,
            81,70,80,1,218,255,255,255,252,255,255,
            255,17,0,6,39,0,0,0,4,84,81,
            70,80,1,216,255,255,255,252,255,255,255,
            18,0,6,41,0,0,0,4,83,79,73,
            67,1,214,255,255,255,252,255,255,255,19,
            0,6,43,0,0,0,3,76,67,67,1,
            212,255,255,255,252,255,255,255,20,0,6,
            45,0,0,0,4,80,76,67,67,1,210,
            255,255,255,252,255,255,255,21,0,6,47,
            0,0,0,3,66,71,65,1,208,255,255,
            255,252,255,255,255,22,0,6,49,0,0,
            0,5,70,80,66,71,65,1,206,255,255,
            255,252,255,255,255,23,0,6,51,0,0,
            0,3,76,71,65,11,0
        };


        /// <summary>
        /// 对芯片的执行要素
        /// </summary>
        public UInt16 FormFactor
        {
            get { return formFactor; }
            set { formFactor = value; }
        }
        public Dictionary<ushort, string> YxDictionFormFactor
        {
            get 
            {
                GetParser();
                return dictionFormFactor; 
            }
        }
        private void GetParser()
        {
            MemoryStream stream1 = new MemoryStream(this.arr);
            BinaryFormatter formatter1 = new BinaryFormatter();
            //			formatter1.set_AssemblyFormat(0);
            formatter1.AssemblyFormat = FormatterAssemblyStyle.Simple;
            this.dictionFormFactor = (Dictionary<ushort, string>)formatter1.Deserialize(stream1);
        }
        /// <summary>
        /// 得到FormFactor的意思通过key
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>解释</returns>
        public string GetFormFactorbyInt(ushort key)
        {
            string dic;
            bool a = YxDictionFormFactor.TryGetValue(key, out dic);
            if (a)
            {
                return dic;
            }
            else
            {
                throw new Exception("没有找到这个键的值");
            }
        }
    }
}
