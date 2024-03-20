using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GdkContentDeserializeFunc(GdkContentDeserializerHandle deserializer);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GdkContentSerializeFunc(GdkContentSerializerHandle serializer);
