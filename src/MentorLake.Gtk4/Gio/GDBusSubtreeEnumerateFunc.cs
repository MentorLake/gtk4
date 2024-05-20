namespace MentorLake.Gtk4.Gio;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GDBusSubtreeEnumerateFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GDBusConnectionHandle>))] GDBusConnectionHandle connection, string sender, string object_path, IntPtr user_data);
