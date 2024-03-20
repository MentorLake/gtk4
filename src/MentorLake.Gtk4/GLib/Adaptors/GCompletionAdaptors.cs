using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GCompletionAdaptors
{
	public static GCompletionHandle AddItems(this GCompletionHandle cmp, GListHandle items)
	{
		GCompletionExterns.g_completion_add_items(cmp, items);
		return cmp;
	}

	public static GCompletionHandle RemoveItems(this GCompletionHandle cmp, GListHandle items)
	{
		GCompletionExterns.g_completion_remove_items(cmp, items);
		return cmp;
	}

	public static GCompletionHandle ClearItems(this GCompletionHandle cmp)
	{
		GCompletionExterns.g_completion_clear_items(cmp);
		return cmp;
	}

	public static GListHandle Complete(this GCompletionHandle cmp, string prefix, string[] new_prefix)
	{
		return GCompletionExterns.g_completion_complete(cmp, prefix, new_prefix);
	}

	public static GListHandle CompleteUtf8(this GCompletionHandle cmp, string prefix, string[] new_prefix)
	{
		return GCompletionExterns.g_completion_complete_utf8(cmp, prefix, new_prefix);
	}

	public static GCompletionHandle SetCompare(this GCompletionHandle cmp, GCompletionStrncmpFunc strncmp_func)
	{
		GCompletionExterns.g_completion_set_compare(cmp, strncmp_func);
		return cmp;
	}

	public static GCompletionHandle Free(this GCompletionHandle cmp)
	{
		GCompletionExterns.g_completion_free(cmp);
		return cmp;
	}
}
