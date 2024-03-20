using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class GHookExterns
{
	[DllImport(Libraries.GLib, EntryPoint = "g_hook_compare_ids")]
	internal static extern int g_hook_compare_ids(this GHookHandle new_hook, GHookHandle sibling);
}
