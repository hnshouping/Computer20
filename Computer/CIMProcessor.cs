using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters;
using System.IO;

namespace Computer
{
    public abstract class CIMProcessor : CIMLogicalDevice
    {
        private UInt16 addressWidth;
        private UInt32 currentClockSpeed;
        private UInt16 dataWidth;
        private UInt16 family;
        private UInt16 loadPercentage;
        private UInt32 maxClockSpeed;
        private string otherFamilyDescription;
        private string role;
        private string stepping;
        private string uniqueId;
        private UInt16 upgradeMethod;

        private Dictionary<ushort, string> dictionUpgradeMethod;
        private Dictionary<ushort, string> dictionFamily;


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
            51,52,101,48,56,57,93,93,91,93,55,
            0,0,0,9,2,0,0,0,89,0,0,
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
            0,0,0,0,1,0,0,0,55,0,0,
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
            1,0,6,5,0,0,0,5,79,116,104,
            101,114,1,250,255,255,255,252,255,255,255,
            2,0,6,7,0,0,0,7,85,110,107,
            110,111,119,110,1,248,255,255,255,252,255,
            255,255,3,0,6,9,0,0,0,4,56,
            48,56,54,1,246,255,255,255,252,255,255,
            255,4,0,6,11,0,0,0,5,56,48,
            50,56,54,1,244,255,255,255,252,255,255,
            255,5,0,6,13,0,0,0,5,56,48,
            51,56,54,1,242,255,255,255,252,255,255,
            255,6,0,6,15,0,0,0,5,56,48,
            52,56,54,1,240,255,255,255,252,255,255,
            255,7,0,6,17,0,0,0,4,56,48,
            56,55,1,238,255,255,255,252,255,255,255,
            8,0,6,19,0,0,0,5,56,48,50,
            56,55,1,236,255,255,255,252,255,255,255,
            9,0,6,21,0,0,0,5,56,48,51,
            56,55,1,234,255,255,255,252,255,255,255,
            10,0,6,23,0,0,0,5,56,48,52,
            56,55,1,232,255,255,255,252,255,255,255,
            11,0,6,25,0,0,0,14,80,101,110,
            116,105,117,109,32,70,97,109,105,108,121,
            1,230,255,255,255,252,255,255,255,12,0,
            6,27,0,0,0,11,80,101,110,116,105,
            117,109,32,80,114,111,1,228,255,255,255,
            252,255,255,255,13,0,6,29,0,0,0,
            10,80,101,110,116,105,117,109,32,73,73,
            1,226,255,255,255,252,255,255,255,14,0,
            6,31,0,0,0,11,80,101,110,116,105,
            117,109,32,77,77,88,1,224,255,255,255,
            252,255,255,255,15,0,6,33,0,0,0,
            7,67,101,108,101,114,111,110,1,222,255,
            255,255,252,255,255,255,16,0,6,35,0,
            0,0,15,80,101,110,116,105,117,109,32,
            73,73,32,88,101,111,110,1,220,255,255,
            255,252,255,255,255,17,0,6,37,0,0,
            0,11,80,101,110,116,105,117,109,32,73,
            73,73,1,218,255,255,255,252,255,255,255,
            18,0,6,39,0,0,0,9,77,49,32,
            70,97,109,105,108,121,1,216,255,255,255,
            252,255,255,255,19,0,6,41,0,0,0,
            9,77,50,32,70,97,109,105,108,121,1,
            214,255,255,255,252,255,255,255,25,0,6,
            43,0,0,0,9,75,53,32,70,97,109,
            105,108,121,1,212,255,255,255,252,255,255,
            255,26,0,6,45,0,0,0,9,75,54,
            32,70,97,109,105,108,121,1,210,255,255,
            255,252,255,255,255,27,0,6,47,0,0,
            0,4,75,54,45,50,1,208,255,255,255,
            252,255,255,255,28,0,6,49,0,0,0,
            6,75,54,45,73,73,73,1,206,255,255,
            255,252,255,255,255,29,0,6,51,0,0,
            0,6,65,116,104,108,111,110,1,204,255,
            255,255,252,255,255,255,32,0,6,53,0,
            0,0,15,80,111,119,101,114,32,80,67,
            32,70,97,109,105,108,121,1,202,255,255,
            255,252,255,255,255,33,0,6,55,0,0,
            0,12,80,111,119,101,114,32,80,67,32,
            54,48,49,1,200,255,255,255,252,255,255,
            255,34,0,6,57,0,0,0,12,80,111,
            119,101,114,32,80,67,32,54,48,51,1,
            198,255,255,255,252,255,255,255,35,0,6,
            59,0,0,0,13,80,111,119,101,114,32,
            80,67,32,54,48,51,43,1,196,255,255,
            255,252,255,255,255,36,0,6,61,0,0,
            0,12,80,111,119,101,114,32,80,67,32,
            54,48,52,1,194,255,255,255,252,255,255,
            255,48,0,6,63,0,0,0,12,65,108,
            112,104,97,32,70,97,109,105,108,121,1,
            192,255,255,255,252,255,255,255,64,0,6,
            65,0,0,0,11,77,73,80,83,32,70,
            97,109,105,108,121,1,190,255,255,255,252,
            255,255,255,80,0,6,67,0,0,0,12,
            83,80,65,82,67,32,70,97,109,105,108,
            121,1,188,255,255,255,252,255,255,255,96,
            0,6,69,0,0,0,5,54,56,48,52,
            48,1,186,255,255,255,252,255,255,255,97,
            0,6,71,0,0,0,12,54,56,120,120,
            120,32,70,97,109,105,108,121,1,184,255,
            255,255,252,255,255,255,98,0,6,73,0,
            0,0,5,54,56,48,48,48,1,182,255,
            255,255,252,255,255,255,99,0,6,75,0,
            0,0,5,54,56,48,49,48,1,180,255,
            255,255,252,255,255,255,100,0,6,77,0,
            0,0,5,54,56,48,50,48,1,178,255,
            255,255,252,255,255,255,101,0,6,79,0,
            0,0,5,54,56,48,51,48,1,176,255,
            255,255,252,255,255,255,112,0,6,81,0,
            0,0,13,72,111,98,98,105,116,32,70,
            97,109,105,108,121,1,174,255,255,255,252,
            255,255,255,128,0,6,83,0,0,0,6,
            87,101,105,116,101,107,1,172,255,255,255,
            252,255,255,255,144,0,6,85,0,0,0,
            14,80,65,45,82,73,83,67,32,70,97,
            109,105,108,121,1,170,255,255,255,252,255,
            255,255,160,0,6,87,0,0,0,10,86,
            51,48,32,70,97,109,105,108,121,1,168,
            255,255,255,252,255,255,255,176,0,6,89,
            0,0,0,16,80,101,110,116,105,117,109,
            32,73,73,73,32,88,101,111,110,1,166,
            255,255,255,252,255,255,255,180,0,6,91,
            0,0,0,12,65,83,52,48,48,32,70,
            97,109,105,108,121,1,164,255,255,255,252,
            255,255,255,200,0,6,93,0,0,0,13,
            73,66,77,51,57,48,32,70,97,109,105,
            108,121,1,162,255,255,255,252,255,255,255,
            250,0,6,95,0,0,0,4,105,56,54,
            48,1,160,255,255,255,252,255,255,255,251,
            0,6,97,0,0,0,4,105,57,54,48,
            1,158,255,255,255,252,255,255,255,4,1,
            6,99,0,0,0,4,83,72,45,51,1,
            156,255,255,255,252,255,255,255,5,1,6,
            101,0,0,0,4,83,72,45,52,1,154,
            255,255,255,252,255,255,255,24,1,6,103,
            0,0,0,3,65,82,77,1,152,255,255,
            255,252,255,255,255,25,1,6,105,0,0,
            0,9,83,116,114,111,110,103,65,82,77,
            1,150,255,255,255,252,255,255,255,44,1,
            6,107,0,0,0,4,54,120,56,54,1,
            148,255,255,255,252,255,255,255,45,1,6,
            109,0,0,0,7,77,101,100,105,97,71,
            88,1,146,255,255,255,252,255,255,255,46,
            1,6,111,0,0,0,3,77,73,73,1,
            144,255,255,255,252,255,255,255,64,1,6,
            113,0,0,0,7,87,105,110,67,104,105,
            112,11,0,1,0,0,0,255,255,255,255,
            1,0,0,0,0,0,0,0,4,1,0,
            0,0,226,1,83,121,115,116,101,109,46,
            67,111,108,108,101,99,116,105,111,110,115,
            46,71,101,110,101,114,105,99,46,68,105,
            99,116,105,111,110,97,114,121,96,50,91,
            91,83,121,115,116,101,109,46,85,73,110,
            116,49,54,44,32,109,115,99,111,114,108,
            105,98,44,32,86,101,114,115,105,111,110,
            61,50,46,48,46,48,46,48,44,32,67,
            117,108,116,117,114,101,61,110,101,117,116,
            114,97,108,44,32,80,117,98,108,105,99,
            75,101,121,84,111,107,101,110,61,98,55,
            55,97,53,99,53,54,49,57,51,52,101,
            48,56,57,93,44,91,83,121,115,116,101,
            109,46,83,116,114,105,110,103,44,32,109,
            115,99,111,114,108,105,98,44,32,86,101,
            114,115,105,111,110,61,50,46,48,46,48,
            46,48,44,32,67,117,108,116,117,114,101,
            61,110,101,117,116,114,97,108,44,32,80,
            117,98,108,105,99,75,101,121,84,111,107,
            101,110,61,98,55,55,97,53,99,53,54,
            49,57,51,52,101,48,56,57,93,93,4,
            0,0,0,7,86,101,114,115,105,111,110,
            8,67,111,109,112,97,114,101,114,8,72,
            97,115,104,83,105,122,101,13,75,101,121,
            86,97,108,117,101,80,97,105,114,115,0,
            3,0,3,8,146,1,83,121,115,116,101,
            109,46,67,111,108,108,101,99,116,105,111,
            110,115,46,71,101,110,101,114,105,99,46,
            71,101,110,101,114,105,99,69,113,117,97,
            108,105,116,121,67,111,109,112,97,114,101,
            114,96,49,91,91,83,121,115,116,101,109,
            46,85,73,110,116,49,54,44,32,109,115,
            99,111,114,108,105,98,44,32,86,101,114,
            115,105,111,110,61,50,46,48,46,48,46,
            48,44,32,67,117,108,116,117,114,101,61,
            110,101,117,116,114,97,108,44,32,80,117,
            98,108,105,99,75,101,121,84,111,107,101,
            110,61,98,55,55,97,53,99,53,54,49,
            57,51,52,101,48,56,57,93,93,8,230,
            1,83,121,115,116,101,109,46,67,111,108,
            108,101,99,116,105,111,110,115,46,71,101,
            110,101,114,105,99,46,75,101,121,86,97,
            108,117,101,80,97,105,114,96,50,91,91,
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
            57,51,52,101,48,56,57,93,93,91,93,
            12,0,0,0,9,2,0,0,0,17,0,
            0,0,9,3,0,0,0,4,2,0,0,
            0,146,1,83,121,115,116,101,109,46,67,
            111,108,108,101,99,116,105,111,110,115,46,
            71,101,110,101,114,105,99,46,71,101,110,
            101,114,105,99,69,113,117,97,108,105,116,
            121,67,111,109,112,97,114,101,114,96,49,
            91,91,83,121,115,116,101,109,46,85,73,
            110,116,49,54,44,32,109,115,99,111,114,
            108,105,98,44,32,86,101,114,115,105,111,
            110,61,50,46,48,46,48,46,48,44,32,
            67,117,108,116,117,114,101,61,110,101,117,
            116,114,97,108,44,32,80,117,98,108,105,
            99,75,101,121,84,111,107,101,110,61,98,
            55,55,97,53,99,53,54,49,57,51,52,
            101,48,56,57,93,93,0,0,0,0,7,
            3,0,0,0,0,1,0,0,0,12,0,
            0,0,3,228,1,83,121,115,116,101,109,
            46,67,111,108,108,101,99,116,105,111,110,
            115,46,71,101,110,101,114,105,99,46,75,
            101,121,86,97,108,117,101,80,97,105,114,
            96,50,91,91,83,121,115,116,101,109,46,
            85,73,110,116,49,54,44,32,109,115,99,
            111,114,108,105,98,44,32,86,101,114,115,
            105,111,110,61,50,46,48,46,48,46,48,
            44,32,67,117,108,116,117,114,101,61,110,
            101,117,116,114,97,108,44,32,80,117,98,
            108,105,99,75,101,121,84,111,107,101,110,
            61,98,55,55,97,53,99,53,54,49,57,
            51,52,101,48,56,57,93,44,91,83,121,
            115,116,101,109,46,83,116,114,105,110,103,
            44,32,109,115,99,111,114,108,105,98,44,
            32,86,101,114,115,105,111,110,61,50,46,
            48,46,48,46,48,44,32,67,117,108,116,
            117,114,101,61,110,101,117,116,114,97,108,
            44,32,80,117,98,108,105,99,75,101,121,
            84,111,107,101,110,61,98,55,55,97,53,
            99,53,54,49,57,51,52,101,48,56,57,
            93,93,4,252,255,255,255,228,1,83,121,
            115,116,101,109,46,67,111,108,108,101,99,
            116,105,111,110,115,46,71,101,110,101,114,
            105,99,46,75,101,121,86,97,108,117,101,
            80,97,105,114,96,50,91,91,83,121,115,
            116,101,109,46,85,73,110,116,49,54,44,
            32,109,115,99,111,114,108,105,98,44,32,
            86,101,114,115,105,111,110,61,50,46,48,
            46,48,46,48,44,32,67,117,108,116,117,
            114,101,61,110,101,117,116,114,97,108,44,
            32,80,117,98,108,105,99,75,101,121,84,
            111,107,101,110,61,98,55,55,97,53,99,
            53,54,49,57,51,52,101,48,56,57,93,
            44,91,83,121,115,116,101,109,46,83,116,
            114,105,110,103,44,32,109,115,99,111,114,
            108,105,98,44,32,86,101,114,115,105,111,
            110,61,50,46,48,46,48,46,48,44,32,
            67,117,108,116,117,114,101,61,110,101,117,
            116,114,97,108,44,32,80,117,98,108,105,
            99,75,101,121,84,111,107,101,110,61,98,
            55,55,97,53,99,53,54,49,57,51,52,
            101,48,56,57,93,93,2,0,0,0,3,
            107,101,121,5,118,97,108,117,101,0,1,
            14,1,0,6,5,0,0,0,5,79,116,
            104,101,114,1,250,255,255,255,252,255,255,
            255,2,0,6,7,0,0,0,7,85,110,
            107,110,111,119,110,1,248,255,255,255,252,
            255,255,255,3,0,6,9,0,0,0,14,
            68,97,117,103,104,116,101,114,32,98,111,
            97,114,100,1,246,255,255,255,252,255,255,
            255,4,0,6,11,0,0,0,10,90,73,
            70,32,115,111,99,107,101,116,1,244,255,
            255,255,252,255,255,255,5,0,6,13,0,
            0,0,22,82,101,112,108,97,99,101,109,
            101,110,116,47,112,105,103,103,121,32,98,
            97,99,107,1,242,255,255,255,252,255,255,
            255,6,0,6,15,0,0,0,4,78,111,
            110,101,1,240,255,255,255,252,255,255,255,
            7,0,6,17,0,0,0,10,76,73,70,
            32,115,111,99,107,101,116,1,238,255,255,
            255,252,255,255,255,8,0,6,19,0,0,
            0,6,83,108,111,116,32,49,1,236,255,
            255,255,252,255,255,255,9,0,6,21,0,
            0,0,6,83,108,111,116,32,50,1,234,
            255,255,255,252,255,255,255,10,0,6,23,
            0,0,0,14,51,55,48,32,80,105,110,
            32,115,111,99,107,101,116,1,232,255,255,
            255,252,255,255,255,11,0,6,25,0,0,
            0,6,83,108,111,116,32,65,1,230,255,
            255,255,252,255,255,255,12,0,6,27,0,
            0,0,6,83,108,111,116,32,77,11,0
        };



        /// <summary>
        /// ��������ַ����
        /// </summary>
        public UInt16 AddressWidth
        {
            get { return addressWidth; }
            set { addressWidth = value; }
        }
        /// <summary>
        /// ��������ǰ�ٶ�
        /// </summary>
        public UInt32 CurrentClockSpeed
        {
            get { return currentClockSpeed; }
            set { currentClockSpeed = value; }
        }
        /// <summary>
        /// ���������ݵĿ���
        /// </summary>
        public UInt16 DataWidth
        {
            get { return dataWidth; }
            set { dataWidth = value; }
        }
        /// <summary>
        /// ��������������
        /// </summary>
        public UInt16 Family
        {
            get { return family; }
            set { family = value; }
        }
        /// <summary>
        /// ��������װ�ص���ϸ΢��ƽ���İٷ���
        /// </summary>
        public UInt16 LoadPercentage
        {
            get { return loadPercentage; }
            set { loadPercentage = value; }
        }
        /// <summary>
        /// ������������ٶ�
        /// </summary>
        public UInt32 MaxClockSpeed
        {
            get { return maxClockSpeed; }
            set { maxClockSpeed = value; }
        }
        /// <summary>
        /// �������������͵�˵��
        /// </summary>
        public string OtherFamilyDescription
        {
            get { return otherFamilyDescription; }
            set { otherFamilyDescription = value; }
        }
        /// <summary>
        /// ��������ɫ����������
        /// </summary>
        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        /// <summary>
        /// �����������ڲ��Ĵ��������ַ���ʾ�İ汾����
        /// </summary>
        public string Stepping
        {
            get { return stepping; }
            set { stepping = value; }
        }
        /// <summary>
        /// ȫ��Դ�������Ψһ����
        /// </summary>
        public string UniqueId
        {
            get { return uniqueId; }
            set { uniqueId = value; }
        }
        /// <summary> 
        /// CPU������Ϣ,������������������
        /// </summary>
        public UInt16 UpgradeMethod
        {
            get { return upgradeMethod; }
            set { upgradeMethod = value; }
        }
        private void GetParser()
        {
            MemoryStream stream1 = new MemoryStream(this.arr);
            BinaryFormatter formatter1 = new BinaryFormatter();
            //			formatter1.set_AssemblyFormat(0);
            formatter1.AssemblyFormat = FormatterAssemblyStyle.Simple;
            dictionFamily = (Dictionary<ushort, string>)formatter1.Deserialize(stream1);
            dictionUpgradeMethod = (Dictionary<ushort, string>)formatter1.Deserialize(stream1);
        }
        private Dictionary<ushort, string> YxDictionUpgradeMethod
        {
            get 
            {
                GetParser();
                return dictionUpgradeMethod;
            }
        }
        private Dictionary<ushort, string> YxDictionFamily
        {
            get
            {
                GetParser();
                return dictionFamily;
            }
        }
        /// <summary>
        /// �õ�UpgradeMethod����˼ͨ��key
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>����</returns>
        public string GetUpgradeMethodbyInt(ushort key)
        {
            string dic;
            bool a = YxDictionUpgradeMethod.TryGetValue(key, out dic);
            if (a)
            {
                return dic;
            }
            else
            {
                throw new Exception("û���ҵ��������ֵ");
            }
        }
        /// <summary>
        /// �õ�Family����˼ͨ��key
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>����</returns>
        public string GetFamilybyInt(ushort key)
        {
            string dic;
            bool a = YxDictionFamily.TryGetValue(key, out dic);
            if (a)
            {
                return dic;
            }
            else
            {
                throw new Exception("û���ҵ��������ֵ");
            }
        }

    }
}