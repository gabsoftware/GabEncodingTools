namespace MultiLanguage
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security;

    [ComImport, Guid("359F3443-BD4A-11D0-B188-00AA0038C969"), InterfaceType((short) 1)]
    public interface IMLangCodePages : IUnknown
    {

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT GetCharCodePages(
            [In] ushort chSrc,
            out uint pdwCodePages
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT GetStrCodePages(
            [In] ref ushort pszSrc,
            [In] int cchSrc,
            [In] uint dwPriorityCodePages,
            out uint pdwCodePages,
            out int pcchCodePages
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT CodePageToCodePages(
            [In] uint uCodePage,
            out uint pdwCodePages
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT CodePagesToCodePage(
            [In] uint dwCodePages,
            [In] uint uDefaultCodePage,
            out uint puCodePage
            );
    
    }
}
