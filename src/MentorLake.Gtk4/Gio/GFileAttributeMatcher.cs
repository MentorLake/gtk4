namespace MentorLake.Gtk4.Gio;

public class GFileAttributeMatcherHandle : BaseSafeHandle
{
	public static GFileAttributeMatcherHandle New(string attributes)
	{
		return GFileAttributeMatcherExterns.g_file_attribute_matcher_new(attributes);
	}

}

internal class GFileAttributeMatcherExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GFileAttributeMatcherHandle g_file_attribute_matcher_new(string attributes);

}

public struct GFileAttributeMatcher
{
}
