namespace MentorLake.Gtk4.GdkPixbuf;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GdkPixbufModuleBeginLoadFunc(GdkPixbufModuleSizeFunc size_func, GdkPixbufModulePreparedFunc prepared_func, GdkPixbufModuleUpdatedFunc updated_func, IntPtr user_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GErrorHandle>))] out GErrorHandle error);
