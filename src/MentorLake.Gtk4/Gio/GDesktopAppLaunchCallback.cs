namespace MentorLake.Gtk4.Gio;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GDesktopAppLaunchCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GDesktopAppInfoHandle>))] GDesktopAppInfoHandle appinfo, GPid pid, IntPtr user_data);
