namespace MentorLake.Gtk4.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GDataForeachFunc(GQuark key_id, IntPtr data, IntPtr user_data);
