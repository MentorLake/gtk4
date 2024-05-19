namespace MentorLake.Gtk4.Gio;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GTaskThreadFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GTaskHandle>))] GTaskHandle task, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GObjectHandle>))] GObjectHandle source_object, IntPtr task_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GCancellableHandle>))] GCancellableHandle cancellable);
