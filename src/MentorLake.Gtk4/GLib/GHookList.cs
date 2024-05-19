namespace MentorLake.Gtk4.GLib;

public class GHookListHandle : BaseSafeHandle
{
}

internal class GHookListExterns
{
}

public struct GHookList
{
	public ulong seq_id;
	public uint hook_size;
	public uint is_setup;
	public GHookHandle hooks;
	public IntPtr dummy3;
	public GHookFinalizeFunc finalize_hook;
	public None dummy;
}
