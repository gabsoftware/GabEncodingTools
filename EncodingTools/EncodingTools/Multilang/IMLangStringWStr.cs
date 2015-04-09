#pragma warning disable 0108

namespace MultiLanguage
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security;

    [ComImport, InterfaceType((short) 1), ComConversionLoss, Guid("C04D65D0-B70D-11D0-B188-00AA0038C969")]
    public interface IMLangStringWStr : IMLangString
    {

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT SetWStr(
            [In] int lDestPos,
            [In] int lDestLen,
            [In] ref ushort pszSrc,
            [In] int cchSrc,
            out int pcchActual,
            out int plActualLen
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT SetStrBufW(
            [In] int lDestPos,
            [In] int lDestLen,
            [In, MarshalAs(UnmanagedType.Interface)] IMLangStringBufW pSrcBuf,
            out int pcchActual,
            out int plActualLen
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT GetWStr(
            [In] int lSrcPos,
            [In] int lSrcLen,
            out ushort pszDest,
            [In] int cchDest,
            out int pcchActual,
            out int plActualLen
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT GetStrBufW(
            [In] int lSrcPos,
            [In] int lSrcMaxLen,
            [MarshalAs(UnmanagedType.Interface)] out IMLangStringBufW ppDestBuf,
            out int plDestLen
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT LockWStr(
            [In] int lSrcPos,
            [In] int lSrcLen,
            [In] int lFlags,
            [In] int cchRequest,
            [Out] IntPtr ppszDest,
            out int pcchDest,
            out int plDestLen
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT UnlockWStr(
            [In] ref ushort pszSrc,
            [In] int cchSrc,
            out int pcchActual,
            out int plActualLen
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT SetLocale(
            [In] int lDestPos,
            [In] int lDestLen,
            [In] uint locale
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT GetLocale(
            [In] int lSrcPos,
            [In] int lSrcMaxLen,
            out uint plocale,
            out int plLocalePos,
            out int plLocaleLen
            );     

    }
}

#pragma warning restore 0108