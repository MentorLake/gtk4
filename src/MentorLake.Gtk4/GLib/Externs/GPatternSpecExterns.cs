using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GPatternSpecExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_pattern_spec_free")]
    internal static extern void g_pattern_spec_free(this GPatternSpecHandle pspec);
    [DllImport(Libraries.GLib, EntryPoint = "g_pattern_spec_copy")]
    internal static extern GPatternSpecHandle g_pattern_spec_copy(this GPatternSpecHandle pspec);
    [DllImport(Libraries.GLib, EntryPoint = "g_pattern_spec_equal")]
    internal static extern int g_pattern_spec_equal(this GPatternSpecHandle pspec1, GPatternSpecHandle pspec2);
    [DllImport(Libraries.GLib, EntryPoint = "g_pattern_spec_match")]
    internal static extern int g_pattern_spec_match(this GPatternSpecHandle pspec, nuint string_length, string @string, string string_reversed);
    [DllImport(Libraries.GLib, EntryPoint = "g_pattern_spec_match_string")]
    internal static extern int g_pattern_spec_match_string(this GPatternSpecHandle pspec, string @string);
    [DllImport(Libraries.GLib, EntryPoint = "g_pattern_match")]
    [Obsolete]
    internal static extern int g_pattern_match(this GPatternSpecHandle pspec, uint string_length, string @string, string string_reversed);
    [DllImport(Libraries.GLib, EntryPoint = "g_pattern_match_string")]
    [Obsolete]
    internal static extern int g_pattern_match_string(this GPatternSpecHandle pspec, string @string);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GPatternSpecHandle g_pattern_spec_new(string pattern);
}
