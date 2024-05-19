namespace MentorLake.Gtk4.GdkPixbuf;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate GdkPixbufAnimationHandle GdkPixbufModuleLoadAnimationFunc(IntPtr f, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GErrorHandle>))] out GErrorHandle error);
