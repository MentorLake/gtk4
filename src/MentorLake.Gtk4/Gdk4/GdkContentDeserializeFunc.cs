namespace MentorLake.Gtk4.Gdk4;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GdkContentDeserializeFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkContentDeserializerHandle>))] GdkContentDeserializerHandle deserializer);
