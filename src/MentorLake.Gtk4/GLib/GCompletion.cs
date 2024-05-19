namespace MentorLake.Gtk4.GLib;

public class GCompletionHandle : BaseSafeHandle
{
}

internal class GCompletionExterns
{
}

public struct GCompletion
{
	public GListHandle items;
	public GCompletionFunc func;
	public string prefix;
	public GListHandle cache;
	public GCompletionStrncmpFunc strncmp_func;
}
