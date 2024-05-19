namespace MentorLake.Gtk4.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate GLogWriterOutput GLogWriterFunc(GLogLevelFlags log_level, GLogField[] fields, int n_fields, IntPtr user_data);
