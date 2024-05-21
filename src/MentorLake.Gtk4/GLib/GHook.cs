namespace MentorLake.Gtk4.GLib;

public class GHookHandle : BaseSafeHandle
{
}


public static class GHookHandleExtensions
{
	public static int CompareIds(this GHookHandle new_hook, GHookHandle sibling)
	{
		return GHookExterns.g_hook_compare_ids(new_hook, sibling);
	}

}
internal class GHookExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern int g_hook_compare_ids(GHookHandle new_hook, GHookHandle sibling);

}

public struct GHook
{
	public IntPtr data;
	public GHookHandle next;
	public GHookHandle prev;
	public uint ref_count;
	public ulong hook_id;
	public uint flags;
	public IntPtr func;
	public GDestroyNotify destroy;
}
