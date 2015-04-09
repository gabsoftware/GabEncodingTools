namespace MultiLanguage
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security;

    [ComImport, ClassInterface((short) 0), TypeLibType((short) 2), Guid("D66D6F99-CDAA-11D0-B822-00C04FC9B31F")]
    public class CMLangConvertCharsetClass : IMLangConvertCharset, CMLangConvertCharset
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
         * IMLangConvertCharset implementation
         */
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT DoConversion(
            [In] ref byte pSrcStr,
            [In, Out] ref uint pcSrcSize,
            [In] ref byte pDstStr,
            [In, Out] ref uint pcDstSize
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT DoConversionFromUnicode(
            [In] ref ushort pSrcStr,
            [In, Out] ref uint pcSrcSize,
            [In] ref sbyte pDstStr,
            [In, Out] ref uint pcDstSize
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT DoConversionToUnicode(
            [In] ref sbyte pSrcStr,
            [In, Out] ref uint pcSrcSize,
            [In] ref ushort pDstStr,
            [In, Out] ref uint pcDstSize
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT GetDestinationCodePage(
            out uint puiDstCodePage
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT GetProperty(
            out uint pdwProperty
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT GetSourceCodePage(
            out uint puiSrcCodePage
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT Initialize(
            [In] uint uiSrcCodePage,
            [In] uint uiDstCodePage,
            [In] uint dwProperty);

    }
}
