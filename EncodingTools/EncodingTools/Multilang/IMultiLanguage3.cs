#pragma warning disable 0108

namespace MultiLanguage
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security;

    [ComImport, InterfaceType((short) 1), Guid("4E5868AB-B157-4623-9ACC-6A1D9CAEBE04")]
    public interface IMultiLanguage3 : IMultiLanguage2
    {

        /*
         * IMultiLanguage3 methods
         */         
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        HRESULT DetectOutboundCodePage(
            [In] MLCPF dwFlags,
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpWideCharStr, 
            [In] uint cchWideChar,
            [In] IntPtr puiPreferredCodePages, 
            [In] uint nPreferredCodePages, 
            [In] IntPtr puiDetectedCodePages, 
            [In, Out] ref uint pnDetectedCodePages, 
            [In] ref ushort lpSpecialChar
            );
        
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        HRESULT DetectOutboundCodePageInIStream(
            [In] MLCPF dwFlags, 
            [In, MarshalAs(UnmanagedType.Interface)] IStream pStrIn, 
            [In] IntPtr puiPreferredCodePages, 
            [In] uint nPreferredCodePages, 
            [In] IntPtr puiDetectedCodePages, 
            [In, Out] ref uint pnDetectedCodePages, 
            [In] ref ushort lpSpecialChar
            );

    }
}

#pragma warning restore 0108