namespace MultiLanguage
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security;

    [ComImport, Guid("275C23E1-3747-11D0-9FEA-00AA003F8646"), InterfaceType((short) 1)]
    public interface IMultiLanguage : IUnknown
    {

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT GetNumberOfCodePageInfo(
            out uint pcCodePage
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT GetCodePageInfo(
            [In] uint uiCodePage,
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
            [MarshalAs(UnmanagedType.Interface)] out IEnumRfc1766 ppEnumRfc1766
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT GetRfc1766Info(
            [In] uint locale,
            out tagRFC1766INFO pRfc1766Info
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT CreateConvertCharset(
            [In] uint uiSrcCodePage,
            [In] uint uiDstCodePage,
            [In] uint dwProperty,
            [MarshalAs(UnmanagedType.Interface)] out CMLangConvertCharset ppMLangConvertCharset
            );

    }
}
