namespace MentorLake.Gtk4.Gio;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GFileProgressCallback(int current_num_bytes, int total_num_bytes, IntPtr data);
