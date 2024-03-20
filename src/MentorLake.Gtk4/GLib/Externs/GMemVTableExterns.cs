using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class GMemVTableExterns
{
	[DllImport(Libraries.GLib, EntryPoint = "g_mem_set_vtable")]
	[Obsolete]
		internal static extern void g_mem_set_vtable(this GMemVTableHandle vtable);
}
