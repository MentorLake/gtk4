namespace MentorLake.Gtk4.Gtk4;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GtkFlowBoxSortFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFlowBoxChildHandle>))] GtkFlowBoxChildHandle child1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFlowBoxChildHandle>))] GtkFlowBoxChildHandle child2, IntPtr user_data);
