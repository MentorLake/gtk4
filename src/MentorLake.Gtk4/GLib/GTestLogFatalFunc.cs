namespace MentorLake.Gtk4.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GTestLogFatalFunc(string log_domain, GLogLevelFlags log_level, string message, IntPtr user_data);
