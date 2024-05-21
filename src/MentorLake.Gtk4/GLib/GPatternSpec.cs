namespace MentorLake.Gtk4.GLib;

public class GPatternSpecHandle : BaseSafeHandle
{
	public static GPatternSpecHandle New(string pattern)
	{
		return GPatternSpecExterns.g_pattern_spec_new(pattern);
	}

}


public static class GPatternSpecHandleExtensions
{
	public static GPatternSpecHandle Copy(this GPatternSpecHandle pspec)
	{
		return GPatternSpecExterns.g_pattern_spec_copy(pspec);
	}

	public static bool Equal(this GPatternSpecHandle pspec1, GPatternSpecHandle pspec2)
	{
		return GPatternSpecExterns.g_pattern_spec_equal(pspec1, pspec2);
	}

	public static GPatternSpecHandle Free(this GPatternSpecHandle pspec)
	{
		GPatternSpecExterns.g_pattern_spec_free(pspec);
		return pspec;
	}

	public static bool Match(this GPatternSpecHandle pspec, UIntPtr string_length, string @string, string string_reversed)
	{
		return GPatternSpecExterns.g_pattern_spec_match(pspec, string_length, @string, string_reversed);
	}

	public static bool MatchString(this GPatternSpecHandle pspec, string @string)
	{
		return GPatternSpecExterns.g_pattern_spec_match_string(pspec, @string);
	}

}
internal class GPatternSpecExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GPatternSpecHandle g_pattern_spec_new(string pattern);

	[DllImport(Libraries.GLib)]
	internal static extern GPatternSpecHandle g_pattern_spec_copy(GPatternSpecHandle pspec);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_pattern_spec_equal(GPatternSpecHandle pspec1, GPatternSpecHandle pspec2);

	[DllImport(Libraries.GLib)]
	internal static extern void g_pattern_spec_free(GPatternSpecHandle pspec);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_pattern_spec_match(GPatternSpecHandle pspec, UIntPtr string_length, string @string, string string_reversed);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_pattern_spec_match_string(GPatternSpecHandle pspec, string @string);

}

public struct GPatternSpec
{
}
