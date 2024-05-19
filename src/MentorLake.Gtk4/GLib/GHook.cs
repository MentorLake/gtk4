namespace MentorLake.Gtk4.GLib;

public class GHookHandle : BaseSafeHandle
{
}

internal class GHookExterns
{
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
