namespace MultiLanguage
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security;

    [ComImport, Guid("C04D65CE-B70D-11D0-B188-00AA0038C969"), InterfaceType((short) 1)]
    public interface IMLangString : IUnknown
    {

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        HRESULT Sync(
            [In] int fNoAccess
            );
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        HRESULT GetLength(
            out int plLen
            );
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        HRESULT SetMLStr(
            [In] int lDestPos, 
            [In] int lDestLen, 
            [In, MarshalAs(UnmanagedType.IUnknown)] object pSrcMLStr, 
            [In] int lSrcPos, 
            [In] int lSrcLen
            );
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        HRESULT GetMLStr(
            [In] int lSrcPos, 
            [In] int lSrcLen, 
            [In, MarshalAs(UnmanagedType.IUnknown)] object pUnkOuter, 
            [In] uint dwClsContext, 
            [In] ref Guid piid, 
            [MarshalAs(UnmanagedType.IUnknown)] out object ppDestMLStr, 
            out int plDestPos, 
            out int plDestLen
            );
 
    }
}
