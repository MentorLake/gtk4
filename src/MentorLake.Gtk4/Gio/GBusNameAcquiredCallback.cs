namespace MentorLake.Gtk4.Gio;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GBusNameAcquiredCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GDBusConnectionHandle>))] GDBusConnectionHandle connection, string name, IntPtr user_data);
