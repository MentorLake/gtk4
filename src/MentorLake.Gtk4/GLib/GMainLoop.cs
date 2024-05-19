namespace MentorLake.Gtk4.GLib;

public class GMainLoopHandle : BaseSafeHandle
{
	public static GMainLoopHandle New(GMainContextHandle context, bool is_running)
	{
		return GMainLoopExterns.g_main_loop_new(context, is_running);
	}

}

internal class GMainLoopExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GMainLoopHandle g_main_loop_new(GMainContextHandle context, bool is_running);

}

public struct GMainLoop
{
}
