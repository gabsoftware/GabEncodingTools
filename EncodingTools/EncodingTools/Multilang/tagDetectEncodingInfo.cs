namespace MultiLanguage
{
    using System;
    using System.Runtime.InteropServices;
    using System.Security;

    ////*** Avant c'�tait invers�, fix pour syst�mes 64bits
    //[StructLayout(LayoutKind.Sequential)]
    [StructLayout(LayoutKind.Sequential, Pack=4)]
    //[StructLayout(LayoutKind.Explicit)]
    public struct DetectEncodingInfo
    {
        //[FieldOffset(0)]
        public uint nLangID;
        
        //[FieldOffset(4)]
        public uint nCodePage;
        
        //[FieldOffset(8)]
        public int nDocPercent;
        
        //[FieldOffset(12)]
        public int nConfidence;
    }

}
