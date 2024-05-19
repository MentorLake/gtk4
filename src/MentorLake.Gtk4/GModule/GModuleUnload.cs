namespace MentorLake.Gtk4.GModule;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GModuleUnload([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GModuleHandle>))] GModuleHandle module);
