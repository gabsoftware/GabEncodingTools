namespace MultiLanguage
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security;

    [ComImport, Guid("C04D65CF-B70D-11D0-B188-00AA0038C969"), ComConversionLoss, ClassInterface((short) 0), TypeLibType((short) 2)]
    public class CMLangStringClass : IMLangString, CMLangString, IMLangStringWStr, IMLangStringAStr
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
         * IMLangString implementation
         */
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT Sync(
            [In] int fNoAccess
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT GetLength(
            out int plLen
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT SetMLStr(
            [In] int lDestPos,
            [In] int lDestLen,
            [In, MarshalAs(UnmanagedType.IUnknown)] object pSrcMLStr,
            [In] int lSrcPos,
            [In] int lSrcLen
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT GetMLStr(
            [In] int lSrcPos,
            [In] int lSrcLen,
            [In, MarshalAs(UnmanagedType.IUnknown)] object pUnkOuter,
            [In] uint dwClsContext,
            [In] ref Guid piid,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppDestMLStr,
            out int plDestPos,
            out int plDestLen);




        /*
         * IMLangStringWStr implementation
         */
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT SetWStr(
            [In] int lDestPos,
            [In] int lDestLen,
            [In] ref ushort pszSrc,
            [In] int cchSrc,
            out int pcchActual,
            out int plActualLen
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT SetStrBufW(
            [In] int lDestPos,
            [In] int lDestLen,
            [In, MarshalAs(UnmanagedType.Interface)] IMLangStringBufW pSrcBuf,
            out int pcchActual,
            out int plActualLen
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT GetWStr(
            [In] int lSrcPos,
            [In] int lSrcLen,
            out ushort pszDest,
            [In] int cchDest,
            out int pcchActual,
            out int plActualLen
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT GetStrBufW(
            [In] int lSrcPos,
            [In] int lSrcMaxLen,
            [MarshalAs(UnmanagedType.Interface)] out IMLangStringBufW ppDestBuf,
            out int plDestLen
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT LockWStr(
            [In] int lSrcPos,
            [In] int lSrcLen,
            [In] int lFlags,
            [In] int cchRequest,
            [Out] IntPtr ppszDest,
            out int pcchDest,
            out int plDestLen
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT UnlockWStr(
            [In] ref ushort pszSrc,
            [In] int cchSrc,
            out int pcchActual,
            out int plActualLen
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT SetLocale(
            [In] int lDestPos,
            [In] int lDestLen,
            [In] uint locale
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT GetLocale(
            [In] int lSrcPos,
            [In] int lSrcMaxLen,
            out uint plocale,
            out int plLocalePos,
            out int plLocaleLen
            );




        /*
         * IMLangStringAStr implementation
         */
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT SetAStr(
            [In] int lDestPos,
            [In] int lDestLen,
            [In] uint uCodePage,
            [In] ref sbyte pszSrc,
            [In] int cchSrc,
            out int pcchActual,
            out int plActualLen
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT SetStrBufA(
            [In] int lDestPos,
            [In] int lDestLen,
            [In] uint uCodePage,
            [In, MarshalAs(UnmanagedType.Interface)] IMLangStringBufA pSrcBuf,
            out int pcchActual,
            out int plActualLen
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT GetAStr(
            [In] int lSrcPos,
            [In] int lSrcLen,
            [In] uint uCodePageIn,
            out uint puCodePageOut,
            out sbyte pszDest,
            [In] int cchDest,
            out int pcchActual,
            out int plActualLen
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT GetStrBufA(
            [In] int lSrcPos,
            [In] int lSrcMaxLen,
            out uint puDestCodePage,
            [MarshalAs(UnmanagedType.Interface)] out IMLangStringBufA ppDestBuf,
            out int plDestLen
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT LockAStr(
            [In] int lSrcPos,
            [In] int lSrcLen,
            [In] int lFlags,
            [In] uint uCodePageIn,
            [In] int cchRequest,
            out uint puCodePageOut,
            [Out] IntPtr ppszDest,
            out int pcchDest,
            out int plDestLen
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public virtual extern HRESULT UnlockAStr(
            [In] ref sbyte pszSrc,
            [In] int cchSrc,
            out int pcchActual,
            out int plActualLen
            );

    }
}
