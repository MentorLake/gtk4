namespace MentorLake.Gtk4.Gtk4;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkPrintSettingsFunc(string key, string value, IntPtr user_data);
