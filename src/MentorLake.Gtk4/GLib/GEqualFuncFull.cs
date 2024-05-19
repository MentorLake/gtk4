namespace MentorLake.Gtk4.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GEqualFuncFull(IntPtr a, IntPtr b, IntPtr user_data);
