using System;
using System.Collections.Generic;
using System.Text;

namespace Computer
{
    public class Win32ProcessStartup : Win32MethodParameterClass
    {
        private UInt32 createFlags;
        private string[] environmentVariables;
        private UInt16 errorMode;
        private UInt32 fillAttribute;
        private UInt32 priorityClass;
        private UInt16 showWindow;
        private string title;
        private string winstationDesktop;
        private UInt32 x;
        private UInt32 xCountChars;
        private UInt32 xSize;
        private UInt32 y;
        private UInt32 yCountChars;
        private UInt32 ySize;


        public UInt32 CreateFlags
        {
            get { return createFlags; }
            set { createFlags = value; }
        }
        public string[] EnvironmentVariables
        {
            get { return environmentVariables; }
            set { environmentVariables = value; }
        }
        public UInt16 ErrorMode
        {
            get { return errorMode; }
            set { errorMode = value; }
        }
        public UInt32 FillAttribute
        {
            get { return fillAttribute; }
            set { fillAttribute = value; }
        }
        public UInt32 PriorityClass
        {
            get { return priorityClass; }
            set { priorityClass = value; }
        }
        public UInt16 ShowWindow
        {
            get { return showWindow; }
            set { showWindow = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string WinstationDesktop
        {
            get { return winstationDesktop; }
            set { winstationDesktop = value; }
        }
        public UInt32 X
        {
            get { return x; }
            set { x = value; }
        }
        public UInt32 XCountChars
        {
            get { return xCountChars; }
            set { xCountChars = value; }
        }
        public UInt32 XSize
        {
            get { return xSize; }
            set { xSize = value; }
        }
        public UInt32 Y
        {
            get { return y; }
            set { y = value; }
        }
        public UInt32 YCountChars
        {
            get { return yCountChars; }
            set { yCountChars = value; }
        }
        public UInt32 YSize
        {
            get { return ySize; }
            set { ySize = value; }
        }
    }
}
