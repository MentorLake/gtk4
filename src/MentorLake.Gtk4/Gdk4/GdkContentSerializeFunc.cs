namespace MentorLake.Gtk4.Gdk4;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GdkContentSerializeFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkContentSerializerHandle>))] GdkContentSerializerHandle serializer);
