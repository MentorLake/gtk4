namespace MentorLake.Gtk4.Pango;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool PangoFontsetForeachFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<PangoFontsetHandle>))] PangoFontsetHandle fontset, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<PangoFontHandle>))] PangoFontHandle font, IntPtr user_data);
