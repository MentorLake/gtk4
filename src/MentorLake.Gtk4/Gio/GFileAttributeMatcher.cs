namespace MentorLake.Gtk4.Gio;

public class GFileAttributeMatcherHandle : BaseSafeHandle
{
	public static GFileAttributeMatcherHandle New(string attributes)
	{
		return GFileAttributeMatcherExterns.g_file_attribute_matcher_new(attributes);
	}

}


public static class GFileAttributeMatcherHandleExtensions
{
	public static bool EnumerateNamespace(this GFileAttributeMatcherHandle matcher, string ns)
	{
		return GFileAttributeMatcherExterns.g_file_attribute_matcher_enumerate_namespace(matcher, ns);
	}

	public static string EnumerateNext(this GFileAttributeMatcherHandle matcher)
	{
		return GFileAttributeMatcherExterns.g_file_attribute_matcher_enumerate_next(matcher);
	}

	public static bool Matches(this GFileAttributeMatcherHandle matcher, string attribute)
	{
		return GFileAttributeMatcherExterns.g_file_attribute_matcher_matches(matcher, attribute);
	}

	public static bool MatchesOnly(this GFileAttributeMatcherHandle matcher, string attribute)
	{
		return GFileAttributeMatcherExterns.g_file_attribute_matcher_matches_only(matcher, attribute);
	}

	public static GFileAttributeMatcherHandle Ref(this GFileAttributeMatcherHandle matcher)
	{
		return GFileAttributeMatcherExterns.g_file_attribute_matcher_ref(matcher);
	}

	public static GFileAttributeMatcherHandle Subtract(this GFileAttributeMatcherHandle matcher, GFileAttributeMatcherHandle subtract)
	{
		return GFileAttributeMatcherExterns.g_file_attribute_matcher_subtract(matcher, subtract);
	}

	public static string ToString(this GFileAttributeMatcherHandle matcher)
	{
		return GFileAttributeMatcherExterns.g_file_attribute_matcher_to_string(matcher);
	}

	public static GFileAttributeMatcherHandle Unref(this GFileAttributeMatcherHandle matcher)
	{
		GFileAttributeMatcherExterns.g_file_attribute_matcher_unref(matcher);
		return matcher;
	}

}
internal class GFileAttributeMatcherExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GFileAttributeMatcherHandle g_file_attribute_matcher_new(string attributes);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_attribute_matcher_enumerate_namespace(GFileAttributeMatcherHandle matcher, string ns);

	[DllImport(Libraries.Gio)]
	internal static extern string g_file_attribute_matcher_enumerate_next(GFileAttributeMatcherHandle matcher);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_attribute_matcher_matches(GFileAttributeMatcherHandle matcher, string attribute);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_attribute_matcher_matches_only(GFileAttributeMatcherHandle matcher, string attribute);

	[DllImport(Libraries.Gio)]
	internal static extern GFileAttributeMatcherHandle g_file_attribute_matcher_ref(GFileAttributeMatcherHandle matcher);

	[DllImport(Libraries.Gio)]
	internal static extern GFileAttributeMatcherHandle g_file_attribute_matcher_subtract(GFileAttributeMatcherHandle matcher, GFileAttributeMatcherHandle subtract);

	[DllImport(Libraries.Gio)]
	internal static extern string g_file_attribute_matcher_to_string(GFileAttributeMatcherHandle matcher);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_attribute_matcher_unref(GFileAttributeMatcherHandle matcher);

}

public struct GFileAttributeMatcher
{
}
