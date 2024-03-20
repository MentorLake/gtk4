using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class GTimeValExterns
{
	[DllImport(Libraries.GLib, EntryPoint = "g_get_current_time")]
	[Obsolete]
		internal static extern void g_get_current_time(this GTimeValHandle result);

	[DllImport(Libraries.GLib, EntryPoint = "g_time_val_add")]
	[Obsolete]
		internal static extern void g_time_val_add(this GTimeValHandle time_, nint microseconds);

	[DllImport(Libraries.GLib, EntryPoint = "g_time_val_to_iso8601")]
	internal static extern string g_time_val_to_iso8601(this GTimeValHandle time_);
}
