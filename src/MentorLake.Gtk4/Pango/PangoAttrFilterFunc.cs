namespace MentorLake.Gtk4.Pango;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool PangoAttrFilterFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<PangoAttributeHandle>))] PangoAttributeHandle attribute, IntPtr user_data);
