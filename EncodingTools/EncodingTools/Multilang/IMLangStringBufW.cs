namespace MultiLanguage
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security;

    [ComImport, InterfaceType((short) 1), Guid("D24ACD21-BA72-11D0-B188-00AA0038C969"), ComConversionLoss]
    public interface IMLangStringBufW : IUnknown
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        HRESULT GetStatus(
            out int plFlags, 
            out int pcchBuf
            );
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        HRESULT LockBuf(
            [In] int cchOffset, 
            [In] int cchMaxLock, 
            [Out] IntPtr ppszBuf, 
            out int pcchBuf
            );
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        HRESULT UnlockBuf(
            [In] ref ushort pszBuf, 
            [In] int cchOffset, 
            [In] int cchWrite
            );
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        HRESULT Insert(
            [In] int cchOffset, 
            [In] int cchMaxInsert, 
            out int pcchActual
            );
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        HRESULT Delete(
            [In] int cchOffset, 
            [In] int cchDelete
            );
    }
}
