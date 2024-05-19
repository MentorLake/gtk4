namespace MentorLake.Gtk4.GLib;

public class GMainContextHandle : BaseSafeHandle
{
	public static GMainContextHandle New()
	{
		return GMainContextExterns.g_main_context_new();
	}

	public static GMainContextHandle NewWithFlags(GMainContextFlags flags)
	{
		return GMainContextExterns.g_main_context_new_with_flags(flags);
	}

}

internal class GMainContextExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GMainContextHandle g_main_context_new();

	[DllImport(Libraries.GLib)]
	internal static extern GMainContextHandle g_main_context_new_with_flags(GMainContextFlags flags);

}

public struct GMainContext
{
}
