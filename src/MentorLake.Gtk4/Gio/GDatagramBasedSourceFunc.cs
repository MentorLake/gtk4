namespace MentorLake.Gtk4.Gio;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GDatagramBasedSourceFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GDatagramBasedHandleImpl>))] GDatagramBasedHandle datagram_based, GIOCondition condition, IntPtr data);
