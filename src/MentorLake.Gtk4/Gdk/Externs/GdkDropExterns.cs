using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gdk;

public static class GdkDropExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_drop_get_display")]
	internal static extern GdkDisplayHandle gdk_drop_get_display(this GdkDropHandle self);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_drop_get_device")]
	internal static extern GdkDeviceHandle gdk_drop_get_device(this GdkDropHandle self);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_drop_get_surface")]
	internal static extern GdkSurfaceHandle gdk_drop_get_surface(this GdkDropHandle self);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_drop_get_formats")]
	internal static extern GdkContentFormatsHandle gdk_drop_get_formats(this GdkDropHandle self);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_drop_get_actions")]
	internal static extern GdkDragAction gdk_drop_get_actions(this GdkDropHandle self);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_drop_get_drag")]
	internal static extern GdkDragHandle gdk_drop_get_drag(this GdkDropHandle self);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_drop_status")]
	internal static extern void gdk_drop_status(this GdkDropHandle self, GdkDragAction actions, GdkDragAction preferred);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_drop_finish")]
	internal static extern void gdk_drop_finish(this GdkDropHandle self, GdkDragAction action);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_drop_read_async")]
	internal static extern void gdk_drop_read_async(this GdkDropHandle self, string[] mime_types, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_drop_read_finish")]
	internal static extern GInputStreamHandle gdk_drop_read_finish(this GdkDropHandle self, GAsyncResultHandle result, out string out_mime_type, out GErrorHandle error);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_drop_read_value_async")]
	internal static extern void gdk_drop_read_value_async(this GdkDropHandle self, GType type, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_drop_read_value_finish")]
	internal static extern GValueHandle gdk_drop_read_value_finish(this GdkDropHandle self, GAsyncResultHandle result, out GErrorHandle error);
}
