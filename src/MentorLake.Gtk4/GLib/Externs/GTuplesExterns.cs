using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class GTuplesExterns
{
	[DllImport(Libraries.GLib, EntryPoint = "g_tuples_destroy")]
	[Obsolete]
		internal static extern void g_tuples_destroy(this GTuplesHandle tuples);

	[DllImport(Libraries.GLib, EntryPoint = "g_tuples_index")]
	internal static extern IntPtr g_tuples_index(this GTuplesHandle tuples, int index_, int field);
}
