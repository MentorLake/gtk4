namespace MentorLake.Gtk4.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GTraverseFunc(IntPtr key, IntPtr value, IntPtr data);
