using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class GDirExterns
{
	[DllImport(Libraries.GLib, EntryPoint = "g_dir_read_name")]
	internal static extern string g_dir_read_name(this GDirHandle dir);

	[DllImport(Libraries.GLib, EntryPoint = "g_dir_rewind")]
	internal static extern void g_dir_rewind(this GDirHandle dir);

	[DllImport(Libraries.GLib, EntryPoint = "g_dir_close")]
	internal static extern void g_dir_close(this GDirHandle dir);
}
