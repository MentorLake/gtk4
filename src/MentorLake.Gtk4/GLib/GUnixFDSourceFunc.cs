namespace MentorLake.Gtk4.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GUnixFDSourceFunc(int fd, GIOCondition condition, IntPtr user_data);
