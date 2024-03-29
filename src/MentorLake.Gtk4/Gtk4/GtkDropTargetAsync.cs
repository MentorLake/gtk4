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

namespace MentorLake.Gtk4.Gtk4;

public class GtkDropTargetAsyncHandle : GtkEventControllerHandle
{
	public static GtkDropTargetAsyncHandle New(GdkContentFormatsHandle formats, GdkDragAction actions)
	{
		return GtkDropTargetAsyncExterns.gtk_drop_target_async_new(formats, actions);
	}

}

public class GtkDropTargetAsyncSignal
{
	public string Value { get; set; }
	public GtkDropTargetAsyncSignal(string value) => Value = value;
}

public static class GtkDropTargetAsyncSignals
{
	public static GtkDropTargetAsyncSignal Accept = new("accept");
	public static GtkDropTargetAsyncSignal DragEnter = new("drag-enter");
	public static GtkDropTargetAsyncSignal DragLeave = new("drag-leave");
	public static GtkDropTargetAsyncSignal DragMotion = new("drag-motion");
	public static GtkDropTargetAsyncSignal Drop = new("drop");
}

public static class GtkDropTargetAsyncHandleExtensions
{
	public static GdkDragAction GetActions(this GtkDropTargetAsyncHandle self)
	{
		return GtkDropTargetAsyncExterns.gtk_drop_target_async_get_actions(self);
	}

	public static GdkContentFormatsHandle GetFormats(this GtkDropTargetAsyncHandle self)
	{
		return GtkDropTargetAsyncExterns.gtk_drop_target_async_get_formats(self);
	}

	public static GtkDropTargetAsyncHandle RejectDrop(this GtkDropTargetAsyncHandle self, GdkDropHandle drop)
	{
		GtkDropTargetAsyncExterns.gtk_drop_target_async_reject_drop(self, drop);
		return self;
	}

	public static GtkDropTargetAsyncHandle SetActions(this GtkDropTargetAsyncHandle self, GdkDragAction actions)
	{
		GtkDropTargetAsyncExterns.gtk_drop_target_async_set_actions(self, actions);
		return self;
	}

	public static GtkDropTargetAsyncHandle SetFormats(this GtkDropTargetAsyncHandle self, GdkContentFormatsHandle formats)
	{
		GtkDropTargetAsyncExterns.gtk_drop_target_async_set_formats(self, formats);
		return self;
	}

	public static GtkDropTargetAsyncHandle Connect(this GtkDropTargetAsyncHandle instance, GtkDropTargetAsyncSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkDropTargetAsyncExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkDropTargetAsyncHandle gtk_drop_target_async_new(GdkContentFormatsHandle formats, GdkDragAction actions);
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkDragAction gtk_drop_target_async_get_actions(GtkDropTargetAsyncHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkContentFormatsHandle gtk_drop_target_async_get_formats(GtkDropTargetAsyncHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drop_target_async_reject_drop(GtkDropTargetAsyncHandle self, GdkDropHandle drop);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drop_target_async_set_actions(GtkDropTargetAsyncHandle self, GdkDragAction actions);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drop_target_async_set_formats(GtkDropTargetAsyncHandle self, GdkContentFormatsHandle formats);
}
