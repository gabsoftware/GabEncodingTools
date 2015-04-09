namespace MultiLanguage
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security;

    [ComImport, TypeLibType((short) 2), ClassInterface((short) 0), Guid("275C23E2-3747-11D0-9FEA-00AA003F8646")]
    public class CMultiLanguageClass : IMultiLanguage, CMultiLanguage, IMLangFontLink, IMLangLineBreakConsole, IMLangFontLink2, IMultiLanguage3
    {

        /*
         * IUnknown implementation
         */
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern IntPtr QueryInterface(
            ref Guid riid
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [PreserveSig]
        public virtual extern UInt32 AddRef();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [PreserveSig]
        public virtual extern UInt32 Release();
        

        /*
         * IMLangLineBreakConsole implementation
         */
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern HRESULT BreakLineA(
            [In] uint locale, 
            [In] uint uCodePage, 
            [In] ref sbyte pszSrc, 
            [In] int cchSrc, 
            [In] int cMaxColumns, 
            out int pcchLine, 
            out int pcchSkip
            );
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern HRESULT BreakLineML(
            [In, MarshalAs(UnmanagedType.Interface)] CMLangString pSrcMLStr, 
            [In] int lSrcPos, 
            [In] int lSrcLen, 
            [In] int cMinColumns, 
            [In] int cMaxColumns, 
            out int plLineLen, 
            out int plSkipLen
            );
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern HRESULT BreakLineW(
            [In] uint locale, 
            [In] ref ushort pszSrc, 
            [In] int cchSrc, 
            [In] int cMaxColumns, 
            out int pcchLine, 
            out int pcchSkip
            );



        /*
         * IMLangCodePages implementation
         */
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern HRESULT CodePagesToCodePage(
            [In] uint dwCodePages, 
            [In] uint uDefaultCodePage, 
            out uint puCodePage
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern HRESULT CodePageToCodePages(
            [In] uint uCodePage, 
            out uint pdwCodePages
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT GetCharCodePages(
            [In] ushort chSrc, 
            out uint pdwCodePages
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT GetStrCodePages(
            [In] ref ushort pszSrc, 
            [In] int cchSrc, 
            [In] uint dwPriorityCodePages, 
            out uint pdwCodePages, 
            out int pcchCodePages
            );



        /*
         * IMultiLanguage2 implementation
         */
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT ConvertString(
            [In, Out] ref uint pdwMode,
            [In] uint dwSrcEncoding,
            [In] uint dwDstEncoding,
            [In] ref byte pSrcStr,
            [In, Out] ref uint pcSrcSize,
            [In] ref byte pDstStr,
            [In, Out] ref uint pcDstSize
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT ConvertStringFromUnicode(
            [In, Out] ref uint pdwMode,
            [In] uint dwEncoding,
            [In] ref ushort pSrcStr,
            [In, Out] ref uint pcSrcSize,
            [In] ref sbyte pDstStr,
            [In, Out] ref uint pcDstSize
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT ConvertStringFromUnicodeEx(
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
        public virtual extern HRESULT ConvertStringInIStream(
            [In, Out] ref uint pdwMode,
            [In] uint dwFlag,
            [In] ref ushort lpFallBack,
            [In] uint dwSrcEncoding,
            [In] uint dwDstEncoding,
            [In, MarshalAs(UnmanagedType.Interface)] IStream pstmIn,
            [In, MarshalAs(UnmanagedType.Interface)] IStream pstmOut
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT ConvertStringReset();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT ConvertStringToUnicode(
            [In, Out] ref uint pdwMode,
            [In] uint dwEncoding,
            [In] ref sbyte pSrcStr,
            [In, Out] ref uint pcSrcSize,
            [In] ref ushort pDstStr,
            [In, Out] ref uint pcDstSize
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT ConvertStringToUnicodeEx(
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
        public virtual extern HRESULT CreateConvertCharset(
            [In] uint uiSrcCodePage,
            [In] uint uiDstCodePage,
            [In] uint dwProperty,
            [MarshalAs(UnmanagedType.Interface)] out CMLangConvertCharset ppMLangConvertCharset
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT DetectCodepageInIStream(
            [In] MLDETECTCP flags,
            [In] uint dwPrefWinCodePage,
            [In, MarshalAs(UnmanagedType.Interface)] IStream pstmIn,
            [In, Out] ref DetectEncodingInfo lpEncoding,
            [In, Out] ref int pnScores
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT DetectInputCodepage(
            [In] MLDETECTCP flags,
            [In] uint dwPrefWinCodePage,
            [In] ref sbyte pSrcStr,
            [In, Out] ref int pcSrcSize,
            [In, Out] ref DetectEncodingInfo lpEncoding,
            [In, Out] ref int pnScores
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT EnumCodePages(
            [In] uint grfFlags,
            [In] ushort LangId,
            [MarshalAs(UnmanagedType.Interface)] out IEnumCodePage ppEnumCodePage
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT EnumRfc1766(
            [In] ushort LangId,
            [MarshalAs(UnmanagedType.Interface)] out IEnumRfc1766 ppEnumRfc1766
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT EnumScripts(
            [In] uint dwFlags,
            [In] ushort LangId,
            [MarshalAs(UnmanagedType.Interface)] out IEnumScript ppEnumScript
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT GetCharsetInfo(
            [In, MarshalAs(UnmanagedType.BStr)] string Charset,
            out tagMIMECSETINFO pCharsetInfo
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT GetCodePageDescription(
            [In] uint uiCodePage,
            [In] uint lcid,
            [In, Out, MarshalAs(UnmanagedType.LPWStr)] string lpWideCharStr,
            [In] int cchWideChar
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT GetCodePageInfo(
            [In] uint uiCodePage,
            [In] ushort LangId,
            out tagMIMECPINFO pCodePageInfo
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT GetFamilyCodePage(
            [In] uint uiCodePage,
            out uint puiFamilyCodePage
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT GetLcidFromRfc1766(
            out uint plocale,
            [In, MarshalAs(UnmanagedType.BStr)] string bstrRfc1766
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT GetNumberOfCodePageInfo(
            out uint pcCodePage
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT GetNumberOfScripts(
            out uint pnScripts
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT GetRfc1766FromLcid(
            [In] uint locale,
            [MarshalAs(UnmanagedType.BStr)] out string pbstrRfc1766
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT GetRfc1766Info(
            [In] uint locale,
            [In] ushort LangId,
            out tagRFC1766INFO pRfc1766Info
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT IsCodePageInstallable(
            [In] uint uiCodePage
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT IsConvertible(
            [In] uint dwSrcEncoding,
            [In] uint dwDstEncoding
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT SetMimeDBSource(
            [In] tagMIMECONTF dwSource
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT ValidateCodePage(
            [In] uint uiCodePage,
            [In, ComAliasName("MultiLanguage.wireHWND")] ref _RemotableHandle hwnd
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT ValidateCodePageEx(
            [In] uint uiCodePage,
            [In, ComAliasName("MultiLanguage.wireHWND")] ref _RemotableHandle hwnd,
            [In] uint dwfIODControl
            );



        /*
         * IMultiLanguage3 implementation
         */
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern HRESULT DetectOutboundCodePage(
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
        public virtual extern HRESULT DetectOutboundCodePageInIStream(
            [In] MLCPF dwFlags, 
            [In, MarshalAs(UnmanagedType.Interface)] IStream pStrIn, 
            [In] IntPtr puiPreferredCodePages, 
            [In] uint nPreferredCodePages, 
            [In] IntPtr puiDetectedCodePages, 
            [In, Out] ref uint pnDetectedCodePages, 
            [In] ref ushort lpSpecialChar
            );




        /*
         * IMultiLanguage implementation
         */
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT EnumCodePages(
            [In] uint grfFlags,
            [MarshalAs(UnmanagedType.Interface)] out IEnumCodePage ppEnumCodePage
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT EnumRfc1766(
            [MarshalAs(UnmanagedType.Interface)] out IEnumRfc1766 ppEnumRfc1766
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT GetCodePageInfo(
            [In] uint uiCodePage,
            out tagMIMECPINFO pCodePageInfo
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT GetRfc1766Info(
            [In] uint locale,
            out tagRFC1766INFO pRfc1766Info
            );



        /*
         * IMLangFontLink implementation
         */
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT MapFont(
            [In, ComAliasName("MultiLanguage.wireHDC")] ref _RemotableHandle hDC,
            [In] uint dwCodePages,
            [In, ComAliasName("MultiLanguage.wireHFONT")] ref _RemotableHandle hSrcFont,
            [Out, ComAliasName("MultiLanguage.wireHFONT")] IntPtr phDestFont
            );



        /*
         * IMLangFontLink2 implementation
         */
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT GetFontCodePages(
            [In, ComAliasName("MultiLanguage.wireHDC")] ref _RemotableHandle hDC,
            [In, ComAliasName("MultiLanguage.wireHFONT")] ref _RemotableHandle hFont,
            out uint pdwCodePages
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT ReleaseFont(
            [In, ComAliasName("MultiLanguage.wireHFONT")] ref _RemotableHandle hFont
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT ResetFontMapping();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT MapFont(
            [In, ComAliasName("MultiLanguage.wireHDC")] ref _RemotableHandle hDC,
            [In] uint dwCodePages,
            [In] ushort chSrc,
            [Out, ComAliasName("MultiLanguage.wireHFONT")] IntPtr pFont
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT GetFontUnicodeRanges(
            [In, ComAliasName("MultiLanguage.wireHDC")] ref _RemotableHandle hDC,
            [In, Out] ref uint puiRanges,
            out tagUNICODERANGE pUranges
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT GetScriptFontInfo(
            [In] byte sid,
            [In] uint dwFlags,
            [In, Out] ref uint puiFonts,
            out tagSCRIPFONTINFO pScriptFont
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT CodePageToScriptID(
            [In] uint uiCodePage,
            out byte pSid
            );

    }
}
