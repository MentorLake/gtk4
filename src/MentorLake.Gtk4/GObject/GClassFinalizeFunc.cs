namespace MentorLake.Gtk4.GObject;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GClassFinalizeFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GTypeClassHandle>))] GTypeClassHandle g_class, IntPtr class_data);
