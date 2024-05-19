namespace MentorLake.Gtk4.GLib;

public class GStrvBuilderHandle : BaseSafeHandle
{
	public static GStrvBuilderHandle New()
	{
		return GStrvBuilderExterns.g_strv_builder_new();
	}

}

internal class GStrvBuilderExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GStrvBuilderHandle g_strv_builder_new();

}

public struct GStrvBuilder
{
}
