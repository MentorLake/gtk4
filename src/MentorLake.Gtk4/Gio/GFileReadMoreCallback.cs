namespace MentorLake.Gtk4.Gio;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GFileReadMoreCallback(string file_contents, int file_size, IntPtr callback_data);
