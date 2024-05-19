namespace MentorLake.Gtk4.GLib;

public class GPatternSpecHandle : BaseSafeHandle
{
	public static GPatternSpecHandle New(string pattern)
	{
		return GPatternSpecExterns.g_pattern_spec_new(pattern);
	}

}

internal class GPatternSpecExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GPatternSpecHandle g_pattern_spec_new(string pattern);

}

public struct GPatternSpec
{
}
