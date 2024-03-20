using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class GSourceFuncsExterns
{
	[DllImport(Libraries.GLib, EntryPoint = "g_source_remove_by_funcs_user_data")]
	internal static extern int g_source_remove_by_funcs_user_data(this GSourceFuncsHandle funcs, IntPtr user_data);
}
