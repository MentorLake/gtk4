using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.GObject;

public static class GSourceExterns
{
	[DllImport(Libraries.GObject, EntryPoint = "g_source_set_closure")]
	internal static extern void g_source_set_closure(this GSourceHandle source, GClosureHandle closure);

	[DllImport(Libraries.GObject, EntryPoint = "g_source_set_dummy_callback")]
	internal static extern void g_source_set_dummy_callback(this GSourceHandle source);
}
