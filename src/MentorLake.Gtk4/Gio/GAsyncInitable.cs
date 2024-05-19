using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gio;

public interface GAsyncInitableHandle
{
}

internal class GAsyncInitableHandleImpl : BaseSafeHandle, GAsyncInitableHandle
{
}

public static class GAsyncInitableHandleExtensions
{
	public static GAsyncInitableHandle InitAsync(this GAsyncInitableHandle initable, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GAsyncInitableExterns.g_async_initable_init_async(initable, io_priority, cancellable, callback, user_data);
		return initable;
	}

	public static bool InitFinish(this GAsyncInitableHandle initable, GAsyncResultHandle res, out GErrorHandle error)
	{
		return GAsyncInitableExterns.g_async_initable_init_finish(initable, res, out error);
	}

	public static GObjectHandle NewFinish(this GAsyncInitableHandle initable, GAsyncResultHandle res, out GErrorHandle error)
	{
		return GAsyncInitableExterns.g_async_initable_new_finish(initable, res, out error);
	}

}

internal class GAsyncInitableExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern void g_async_initable_init_async(GAsyncInitableHandle initable, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_async_initable_init_finish(GAsyncInitableHandle initable, GAsyncResultHandle res, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GObjectHandle g_async_initable_new_finish(GAsyncInitableHandle initable, GAsyncResultHandle res, out GErrorHandle error);

}
