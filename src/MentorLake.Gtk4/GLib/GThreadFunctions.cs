namespace MentorLake.Gtk4.GLib;

public class GThreadFunctionsHandle : BaseSafeHandle
{
}

internal class GThreadFunctionsExterns
{
}

public struct GThreadFunctions
{
	public IntPtr mutex_new;
	public IntPtr mutex_lock;
	public IntPtr mutex_trylock;
	public IntPtr mutex_unlock;
	public IntPtr mutex_free;
	public IntPtr cond_new;
	public IntPtr cond_signal;
	public IntPtr cond_broadcast;
	public IntPtr cond_wait;
	public IntPtr cond_timed_wait;
	public IntPtr cond_free;
	public IntPtr private_new;
	public IntPtr private_get;
	public IntPtr private_set;
	public IntPtr thread_create;
	public IntPtr thread_yield;
	public IntPtr thread_join;
	public IntPtr thread_exit;
	public IntPtr thread_set_priority;
	public IntPtr thread_self;
	public IntPtr thread_equal;
}
