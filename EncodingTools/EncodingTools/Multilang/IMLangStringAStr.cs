#pragma warning disable 0108

namespace MultiLanguage
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security;

    [ComImport, Guid("C04D65D2-B70D-11D0-B188-00AA0038C969"), ComConversionLoss, InterfaceType((short) 1)]
    public interface IMLangStringAStr : IMLangString
    {

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT SetAStr(
            [In] int lDestPos,
            [In] int lDestLen,
            [In] uint uCodePage,
            [In] ref sbyte pszSrc,
            [In] int cchSrc,
            out int pcchActual,
            out int plActualLen
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT SetStrBufA(
            [In] int lDestPos,
            [In] int lDestLen,
            [In] uint uCodePage,
            [In, MarshalAs(UnmanagedType.Interface)] IMLangStringBufA pSrcBuf,
            out int pcchActual,
            out int plActualLen
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT GetAStr(
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
        HRESULT GetStrBufA(
            [In] int lSrcPos,
            [In] int lSrcMaxLen,
            out uint puDestCodePage,
            [MarshalAs(UnmanagedType.Interface)] out IMLangStringBufA ppDestBuf,
            out int plDestLen
            );

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        HRESULT LockAStr(
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
        HRESULT UnlockAStr(
            [In] ref sbyte pszSrc,
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