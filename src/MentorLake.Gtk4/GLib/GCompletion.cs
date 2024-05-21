namespace MentorLake.Gtk4.GLib;

public class GCompletionHandle : BaseSafeHandle
{
}


public static class GCompletionHandleExtensions
{
	public static GCompletionHandle AddItems(this GCompletionHandle cmp, GListHandle items)
	{
		GCompletionExterns.g_completion_add_items(cmp, items);
		return cmp;
	}

	public static GCompletionHandle ClearItems(this GCompletionHandle cmp)
	{
		GCompletionExterns.g_completion_clear_items(cmp);
		return cmp;
	}

	public static GListHandle Complete(this GCompletionHandle cmp, string prefix, ref string new_prefix)
	{
		return GCompletionExterns.g_completion_complete(cmp, prefix, ref new_prefix);
	}

	public static GListHandle CompleteUtf8(this GCompletionHandle cmp, string prefix, ref string new_prefix)
	{
		return GCompletionExterns.g_completion_complete_utf8(cmp, prefix, ref new_prefix);
	}

	public static GCompletionHandle Free(this GCompletionHandle cmp)
	{
		GCompletionExterns.g_completion_free(cmp);
		return cmp;
	}

	public static GCompletionHandle RemoveItems(this GCompletionHandle cmp, GListHandle items)
	{
		GCompletionExterns.g_completion_remove_items(cmp, items);
		return cmp;
	}

	public static GCompletionHandle SetCompare(this GCompletionHandle cmp, GCompletionStrncmpFunc strncmp_func)
	{
		GCompletionExterns.g_completion_set_compare(cmp, strncmp_func);
		return cmp;
	}

}
internal class GCompletionExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_completion_add_items(GCompletionHandle cmp, GListHandle items);

	[DllImport(Libraries.GLib)]
	internal static extern void g_completion_clear_items(GCompletionHandle cmp);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_completion_complete(GCompletionHandle cmp, string prefix, ref string new_prefix);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_completion_complete_utf8(GCompletionHandle cmp, string prefix, ref string new_prefix);

	[DllImport(Libraries.GLib)]
	internal static extern void g_completion_free(GCompletionHandle cmp);

	[DllImport(Libraries.GLib)]
	internal static extern void g_completion_remove_items(GCompletionHandle cmp, GListHandle items);

	[DllImport(Libraries.GLib)]
	internal static extern void g_completion_set_compare(GCompletionHandle cmp, GCompletionStrncmpFunc strncmp_func);

}

public struct GCompletion
{
	public GListHandle items;
	public GCompletionFunc func;
	public string prefix;
	public GListHandle cache;
	public GCompletionStrncmpFunc strncmp_func;
}
