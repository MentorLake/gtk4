namespace MentorLake.Gtk4.GObject;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate string GTypeValueLCopyFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GValueHandle>))] GValueHandle value, uint n_collect_values, GTypeCValue[] collect_values, uint collect_flags);
