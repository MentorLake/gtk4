namespace MentorLake.Gtk4.Gio;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GFileMeasureProgressCallback(bool reporting, ulong current_size, ulong num_dirs, ulong num_files, IntPtr data);
