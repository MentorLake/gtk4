namespace MentorLake.Gtk4.Gtk4;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate GtkWidgetHandle GtkFlowBoxCreateWidgetFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GObjectHandle>))] GObjectHandle item, IntPtr user_data);
