namespace MultiLanguage
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security;

    [ComImport, Guid("D66D6F98-CDAA-11D0-B822-00C04FC9B31F"), InterfaceType((short) 1)]
    public interface IMLangConvertCharset : IUnknown
    {

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT Initialize(
            [In] uint uiSrcCodePage,
            [In] uint uiDstCodePage,
            [In] uint dwProperty);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT GetSourceCodePage(
            out uint puiSrcCodePage
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT GetDestinationCodePage(
            out uint puiDstCodePage
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT GetProperty(
            out uint pdwProperty
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT DoConversion(
            [In] ref byte pSrcStr,
            [In, Out] ref uint pcSrcSize,
            [In] ref byte pDstStr,
            [In, Out] ref uint pcDstSize
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT DoConversionToUnicode(
            [In] ref sbyte pSrcStr,
            [In, Out] ref uint pcSrcSize,
            [In] ref ushort pDstStr,
            [In, Out] ref uint pcDstSize
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT DoConversionFromUnicode(
            [In] ref ushort pSrcStr,
            [In, Out] ref uint pcSrcSize,
            [In] ref sbyte pDstStr,
            [In, Out] ref uint pcDstSize
            );
    
    }
}
