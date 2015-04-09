namespace MultiLanguage
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security;

    [ComImport, Guid("275C23E3-3747-11D0-9FEA-00AA003F8646"), InterfaceType((short) 1)]
    public interface IEnumCodePage : IUnknown
    {
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        HRESULT Clone(
            [MarshalAs(UnmanagedType.Interface)] out IEnumCodePage ppEnum
            );
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        HRESULT Next(
            [In] uint celt, 
            out tagMIMECPINFO rgelt, 
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
