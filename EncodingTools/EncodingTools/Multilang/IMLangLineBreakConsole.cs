namespace MultiLanguage
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security;

    [ComImport, InterfaceType((short) 1), Guid("F5BE2EE1-BFD7-11D0-B188-00AA0038C969")]
    public interface IMLangLineBreakConsole : IUnknown
    {

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        HRESULT BreakLineML(
            [In, MarshalAs(UnmanagedType.Interface)] CMLangString pSrcMLStr, 
            [In] int lSrcPos, 
            [In] int lSrcLen, 
            [In] int cMinColumns, 
            [In] int cMaxColumns, 
            out int plLineLen, 
            out int plSkipLen
            );
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        HRESULT BreakLineW(
            [In] uint locale, 
            [In] ref ushort pszSrc, 
            [In] int cchSrc, 
            [In] int cMaxColumns, 
            out int pcchLine, 
            out int pcchSkip
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT BreakLineA(
            [In] uint locale,
            [In] uint uCodePage,
            [In] ref sbyte pszSrc,
            [In] int cchSrc,
            [In] int cMaxColumns,
            out int pcchLine,
            out int pcchSkip
            );

    }
}
