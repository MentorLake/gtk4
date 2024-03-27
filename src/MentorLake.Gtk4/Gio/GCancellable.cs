using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gio;

public class GCancellableHandle : GObjectHandle
{
	public static GCancellableHandle New()
	{
		return GCancellableExterns.g_cancellable_new();
	}
}

public class GCancellableSignal
{
	public string Value { get; set; }
	public GCancellableSignal(string value) => Value = value;
}

public static class GCancellableSignals
{
	public static GCancellableSignal Cancelled = new("cancelled");
}

public static class GCancellableHandleExtensions
{
	public static GCancellableHandle Cancel(this GCancellableHandle cancellable)
	{
		GCancellableExterns.g_cancellable_cancel(cancellable);
		return cancellable;
	}

	public static ulong Connect(this GCancellableHandle cancellable, GCallback callback, IntPtr data, GDestroyNotify data_destroy_func)
	{
		return GCancellableExterns.g_cancellable_connect(cancellable, callback, data, data_destroy_func);
	}

	public static GCancellableHandle Disconnect(this GCancellableHandle cancellable, ulong handler_id)
	{
		GCancellableExterns.g_cancellable_disconnect(cancellable, handler_id);
		return cancellable;
	}

	public static int GetFd(this GCancellableHandle cancellable)
	{
		return GCancellableExterns.g_cancellable_get_fd(cancellable);
	}

	public static bool IsCancelled(this GCancellableHandle cancellable)
	{
		return GCancellableExterns.g_cancellable_is_cancelled(cancellable);
	}

	public static bool MakePollfd(this GCancellableHandle cancellable, GPollFDHandle pollfd)
	{
		return GCancellableExterns.g_cancellable_make_pollfd(cancellable, pollfd);
	}

	public static GCancellableHandle PopCurrent(this GCancellableHandle cancellable)
	{
		GCancellableExterns.g_cancellable_pop_current(cancellable);
		return cancellable;
	}

	public static GCancellableHandle PushCurrent(this GCancellableHandle cancellable)
	{
		GCancellableExterns.g_cancellable_push_current(cancellable);
		return cancellable;
	}

	public static GCancellableHandle ReleaseFd(this GCancellableHandle cancellable)
	{
		GCancellableExterns.g_cancellable_release_fd(cancellable);
		return cancellable;
	}

	public static GCancellableHandle Reset(this GCancellableHandle cancellable)
	{
		GCancellableExterns.g_cancellable_reset(cancellable);
		return cancellable;
	}

	public static bool SetErrorIfCancelled(this GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GCancellableExterns.g_cancellable_set_error_if_cancelled(cancellable, out error);
	}

	public static GSourceHandle SourceNew(this GCancellableHandle cancellable)
	{
		return GCancellableExterns.g_cancellable_source_new(cancellable);
	}

	public static GCancellableHandle Connect(this GCancellableHandle instance, GCancellableSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GCancellableExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern void g_cancellable_cancel(GCancellableHandle cancellable);
	[DllImport(Libraries.Gio)]
	internal static extern ulong g_cancellable_connect(GCancellableHandle cancellable, GCallback callback, IntPtr data, GDestroyNotify data_destroy_func);
	[DllImport(Libraries.Gio)]
	internal static extern void g_cancellable_disconnect(GCancellableHandle cancellable, ulong handler_id);
	[DllImport(Libraries.Gio)]
	internal static extern int g_cancellable_get_fd(GCancellableHandle cancellable);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_cancellable_is_cancelled(GCancellableHandle cancellable);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_cancellable_make_pollfd(GCancellableHandle cancellable, GPollFDHandle pollfd);
	[DllImport(Libraries.Gio)]
	internal static extern void g_cancellable_pop_current(GCancellableHandle cancellable);
	[DllImport(Libraries.Gio)]
	internal static extern void g_cancellable_push_current(GCancellableHandle cancellable);
	[DllImport(Libraries.Gio)]
	internal static extern void g_cancellable_release_fd(GCancellableHandle cancellable);
	[DllImport(Libraries.Gio)]
	internal static extern void g_cancellable_reset(GCancellableHandle cancellable);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_cancellable_set_error_if_cancelled(GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GSourceHandle g_cancellable_source_new(GCancellableHandle cancellable);
	[DllImport(Libraries.Gio)]
	internal static extern GCancellableHandle g_cancellable_new();
}
