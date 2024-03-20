using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class GStaticPrivateExterns
{
	[DllImport(Libraries.GLib, EntryPoint = "g_static_private_init")]
	[Obsolete]
		internal static extern void g_static_private_init(this GStaticPrivateHandle private_key);

	[DllImport(Libraries.GLib, EntryPoint = "g_static_private_get")]
	internal static extern IntPtr g_static_private_get(this GStaticPrivateHandle private_key);

	[DllImport(Libraries.GLib, EntryPoint = "g_static_private_set")]
	[Obsolete]
		internal static extern void g_static_private_set(this GStaticPrivateHandle private_key, IntPtr data, GDestroyNotify notify);

	[DllImport(Libraries.GLib, EntryPoint = "g_static_private_free")]
	[Obsolete]
		internal static extern void g_static_private_free(this GStaticPrivateHandle private_key);
}
