namespace MentorLake.Gtk4.Gsk4;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GskParseErrorFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GskParseLocationHandle>))] GskParseLocationHandle start, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GskParseLocationHandle>))] GskParseLocationHandle end, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GErrorHandle>))] GErrorHandle error, IntPtr user_data);
