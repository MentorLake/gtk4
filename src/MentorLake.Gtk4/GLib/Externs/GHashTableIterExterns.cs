using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class GHashTableIterExterns
{
	[DllImport(Libraries.GLib, EntryPoint = "g_hash_table_iter_init")]
	internal static extern void g_hash_table_iter_init(this GHashTableIterHandle iter, GHashTableHandle hash_table);

	[DllImport(Libraries.GLib, EntryPoint = "g_hash_table_iter_next")]
	internal static extern int g_hash_table_iter_next(this GHashTableIterHandle iter, out IntPtr key, out IntPtr value);

	[DllImport(Libraries.GLib, EntryPoint = "g_hash_table_iter_get_hash_table")]
	internal static extern GHashTableHandle g_hash_table_iter_get_hash_table(this GHashTableIterHandle iter);

	[DllImport(Libraries.GLib, EntryPoint = "g_hash_table_iter_remove")]
	internal static extern void g_hash_table_iter_remove(this GHashTableIterHandle iter);

	[DllImport(Libraries.GLib, EntryPoint = "g_hash_table_iter_replace")]
	internal static extern void g_hash_table_iter_replace(this GHashTableIterHandle iter, IntPtr value);

	[DllImport(Libraries.GLib, EntryPoint = "g_hash_table_iter_steal")]
	internal static extern void g_hash_table_iter_steal(this GHashTableIterHandle iter);
}
