namespace MentorLake.Gtk4.Gio;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate GType GDBusProxyTypeFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GDBusObjectManagerClientHandle>))] GDBusObjectManagerClientHandle manager, string object_path, string interface_name, IntPtr data);
