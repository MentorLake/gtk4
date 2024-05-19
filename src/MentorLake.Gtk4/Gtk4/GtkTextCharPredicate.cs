namespace MentorLake.Gtk4.Gtk4;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GtkTextCharPredicate(char ch, IntPtr user_data);
