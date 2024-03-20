using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GPatternSpecAdaptors
{
	public static GPatternSpecHandle Free(this GPatternSpecHandle pspec)
	{
		GPatternSpecExterns.g_pattern_spec_free(pspec);
		return pspec;
	}

	public static GPatternSpecHandle Copy(this GPatternSpecHandle pspec)
	{
		return GPatternSpecExterns.g_pattern_spec_copy(pspec);
	}

	public static int Equal(this GPatternSpecHandle pspec1, GPatternSpecHandle pspec2)
	{
		return GPatternSpecExterns.g_pattern_spec_equal(pspec1, pspec2);
	}

	public static int Match(this GPatternSpecHandle pspec, nuint string_length, string @string, string string_reversed)
	{
		return GPatternSpecExterns.g_pattern_spec_match(pspec, string_length, @string, string_reversed);
	}

	public static int MatchString(this GPatternSpecHandle pspec, string @string)
	{
		return GPatternSpecExterns.g_pattern_spec_match_string(pspec, @string);
	}

	public static int GPatternMatch(this GPatternSpecHandle pspec, uint string_length, string @string, string string_reversed)
	{
		return GPatternSpecExterns.g_pattern_match(pspec, string_length, @string, string_reversed);
	}

	public static int GPatternMatchString(this GPatternSpecHandle pspec, string @string)
	{
		return GPatternSpecExterns.g_pattern_match_string(pspec, @string);
	}
}
