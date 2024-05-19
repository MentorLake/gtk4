namespace MentorLake.Gtk4.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GCompareFunc(IntPtr a, IntPtr b);
