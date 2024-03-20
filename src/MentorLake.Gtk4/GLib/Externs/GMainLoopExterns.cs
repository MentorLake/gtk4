using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class GMainLoopExterns
{
	[DllImport(Libraries.GLib, EntryPoint = "g_main_loop_run")]
	internal static extern void g_main_loop_run(this GMainLoopHandle loop);

	[DllImport(Libraries.GLib, EntryPoint = "g_main_loop_quit")]
	internal static extern void g_main_loop_quit(this GMainLoopHandle loop);

	[DllImport(Libraries.GLib, EntryPoint = "g_main_loop_ref")]
	internal static extern GMainLoopHandle g_main_loop_ref(this GMainLoopHandle loop);

	[DllImport(Libraries.GLib, EntryPoint = "g_main_loop_unref")]
	internal static extern void g_main_loop_unref(this GMainLoopHandle loop);

	[DllImport(Libraries.GLib, EntryPoint = "g_main_loop_is_running")]
	internal static extern int g_main_loop_is_running(this GMainLoopHandle loop);

	[DllImport(Libraries.GLib, EntryPoint = "g_main_loop_get_context")]
	internal static extern GMainContextHandle g_main_loop_get_context(this GMainLoopHandle loop);
}
