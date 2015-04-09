namespace MultiLanguage
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security;

    [ComImport, Guid("AE5F1430-388B-11D2-8380-00C04F8F5DA1"), InterfaceType((short) 1)]
    public interface IEnumScript : IUnknown
    {
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        HRESULT Clone(
            [MarshalAs(UnmanagedType.Interface)] out IEnumScript ppEnum
            );
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        HRESULT Next(
            [In] uint celt, 
            out tagSCRIPTINFO rgelt, 
            out uint pceltFetched
            );
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        HRESULT Reset();
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        HRESULT Skip(
            [In] uint celt
            );
    
    }
}
