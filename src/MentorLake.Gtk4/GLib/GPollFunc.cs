namespace MentorLake.Gtk4.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GPollFunc(GPollFD[] ufds, uint nfsd, int timeout_);
