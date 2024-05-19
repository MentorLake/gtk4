namespace MentorLake.Gtk4.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GHookCheckMarshaller([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GHookHandle>))] GHookHandle hook, IntPtr marshal_data);
