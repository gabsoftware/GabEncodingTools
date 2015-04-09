namespace MultiLanguage
{
    using System;
    using System.Runtime.InteropServices;
    using System.Security;

    [StructLayout(LayoutKind.Sequential, Pack=2)]
    //[StructLayout(LayoutKind.Sequential)]
    public struct tagUNICODERANGE
    {
        public ushort wcFrom;
        public ushort wcTo;
    }
}
