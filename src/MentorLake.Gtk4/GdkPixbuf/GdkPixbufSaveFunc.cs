namespace MentorLake.Gtk4.GdkPixbuf;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GdkPixbufSaveFunc(string buf, UIntPtr count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GErrorHandle>))] out GErrorHandle error, IntPtr data);
