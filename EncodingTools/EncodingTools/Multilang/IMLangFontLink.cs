#pragma warning disable 0108

namespace MultiLanguage
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security;

    [ComImport, InterfaceType((short) 1), ComConversionLoss, Guid("359F3441-BD4A-11D0-B188-00AA0038C969")]
    public interface IMLangFontLink : IMLangCodePages
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT GetFontCodePages(
            [In, ComAliasName("MultiLanguage.wireHDC")] ref _RemotableHandle hDC,
            [In, ComAliasName("MultiLanguage.wireHFONT")] ref _RemotableHandle hFont,
            out uint pdwCodePages
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT MapFont(
            [In, ComAliasName("MultiLanguage.wireHDC")] ref _RemotableHandle hDC,
            [In] uint dwCodePages,
            [In, ComAliasName("MultiLanguage.wireHFONT")] ref _RemotableHandle hSrcFont,
            [Out, ComAliasName("MultiLanguage.wireHFONT")] IntPtr phDestFont
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT ReleaseFont(
            [In, ComAliasName("MultiLanguage.wireHFONT")] ref _RemotableHandle hFont
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT ResetFontMapping();
    
    }
}
