namespace MentorLake.Gtk4.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GTestFixtureFunc(IntPtr fixture, IntPtr user_data);
