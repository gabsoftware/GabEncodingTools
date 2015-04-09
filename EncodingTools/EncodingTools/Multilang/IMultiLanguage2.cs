namespace MultiLanguage
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security;

    [ComImport, InterfaceType((short) 1), Guid("DCCFC164-2B38-11D2-B7EC-00C04F8F5D9A")]
    public interface IMultiLanguage2 : IUnknown
    {

        /*
         * IMultiLanguage2 methods
         */
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT GetNumberOfCodePageInfo(
            out uint pcCodePage
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT GetCodePageInfo(
            [In] uint uiCodePage,
            [In] ushort LangId,
            out tagMIMECPINFO pCodePageInfo
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT GetFamilyCodePage(
            [In] uint uiCodePage,
            out uint puiFamilyCodePage
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT EnumCodePages(
            [In] uint grfFlags,
            [In] ushort LangId,
            [MarshalAs(UnmanagedType.Interface)] out IEnumCodePage ppEnumCodePage
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT GetCharsetInfo(
            [In, MarshalAs(UnmanagedType.BStr)] string Charset,
            out tagMIMECSETINFO pCharsetInfo
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT IsConvertible(
            [In] uint dwSrcEncoding,
            [In] uint dwDstEncoding
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT ConvertString(
            [In, Out] ref uint pdwMode,
            [In] uint dwSrcEncoding,
            [In] uint dwDstEncoding,
            [In] ref byte pSrcStr,
            [In, Out] ref uint pcSrcSize,
            [In] ref byte pDstStr,
            [In, Out] ref uint pcDstSize
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT ConvertStringToUnicode(
            [In, Out] ref uint pdwMode,
            [In] uint dwEncoding,
            [In] ref sbyte pSrcStr,
            [In, Out] ref uint pcSrcSize,
            [In] ref ushort pDstStr,
            [In, Out] ref uint pcDstSize
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT ConvertStringFromUnicode(
            [In, Out] ref uint pdwMode,
            [In] uint dwEncoding,
            [In] ref ushort pSrcStr,
            [In, Out] ref uint pcSrcSize,
            [In] ref sbyte pDstStr,
            [In, Out] ref uint pcDstSize
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT ConvertStringReset();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT GetRfc1766FromLcid(
            [In] uint locale,
            [MarshalAs(UnmanagedType.BStr)] out string pbstrRfc1766
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT GetLcidFromRfc1766(
            out uint plocale,
            [In, MarshalAs(UnmanagedType.BStr)] string bstrRfc1766
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT EnumRfc1766(
            [In] ushort LangId,
            [MarshalAs(UnmanagedType.Interface)] out IEnumRfc1766 ppEnumRfc1766
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT GetRfc1766Info(
            [In] uint locale,
            [In] ushort LangId,
            out tagRFC1766INFO pRfc1766Info
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT CreateConvertCharset(
            [In] uint uiSrcCodePage,
            [In] uint uiDstCodePage,
            [In] uint dwProperty,
            [MarshalAs(UnmanagedType.Interface)] out CMLangConvertCharset ppMLangConvertCharset
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT ConvertStringInIStream(
            [In, Out] ref uint pdwMode,
            [In] uint dwFlag,
            [In] ref ushort lpFallBack,
            [In] uint dwSrcEncoding,
            [In] uint dwDstEncoding,
            [In, MarshalAs(UnmanagedType.Interface)] IStream pstmIn,
            [In, MarshalAs(UnmanagedType.Interface)] IStream pstmOut
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT ConvertStringToUnicodeEx(
            [In, Out] ref uint pdwMode,
            [In] uint dwEncoding,
            [In] ref sbyte pSrcStr,
            [In, Out] ref uint pcSrcSize,
            [In] ref ushort pDstStr,
            [In, Out] ref uint pcDstSize,
            [In] uint dwFlag,
            [In] ref ushort lpFallBack
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT ConvertStringFromUnicodeEx(
            [In, Out] ref uint pdwMode,
            [In] uint dwEncoding,
            [In] ref ushort pSrcStr,
            [In, Out] ref uint pcSrcSize,
            [In] ref sbyte pDstStr,
            [In, Out] ref uint pcDstSize,
            [In] uint dwFlag,
            [In] ref ushort lpFallBack
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT DetectCodepageInIStream(
            [In] MLDETECTCP flags,
            [In] uint dwPrefWinCodePage,
            [In, MarshalAs(UnmanagedType.Interface)] IStream pstmIn,
            [In, Out] ref DetectEncodingInfo lpEncoding,
            [In, Out] ref int pnScores
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT DetectInputCodepage(
            [In] MLDETECTCP flags,
            [In] uint dwPrefWinCodePage,
            [In] ref sbyte pSrcStr,
            [In, Out] ref int pcSrcSize,
            [In, Out] ref DetectEncodingInfo lpEncoding,
            [In, Out] ref int pnScores
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT ValidateCodePage(
            [In] uint uiCodePage,
            [In, ComAliasName("MultiLanguage.wireHWND")] ref _RemotableHandle hwnd
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT GetCodePageDescription(
            [In] uint uiCodePage,
            [In] uint lcid,
            [In, Out, MarshalAs(UnmanagedType.LPWStr)] string lpWideCharStr,
            [In] int cchWideChar
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT IsCodePageInstallable(
            [In] uint uiCodePage
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT SetMimeDBSource(
            [In] tagMIMECONTF dwSource
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT GetNumberOfScripts(
            out uint pnScripts
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT EnumScripts(
            [In] uint dwFlags,
            [In] ushort LangId,
            [MarshalAs(UnmanagedType.Interface)] out IEnumScript ppEnumScript
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT ValidateCodePageEx(
            [In] uint uiCodePage,
            [In, ComAliasName("MultiLanguage.wireHWND")] ref _RemotableHandle hwnd,
            [In] uint dwfIODControl
            );

    }
}
