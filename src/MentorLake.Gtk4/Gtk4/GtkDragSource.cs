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

public class GtkDragSourceHandle : GtkGestureSingleHandle
{
	public static GtkDragSourceHandle New()
	{
		return GtkDragSourceExterns.gtk_drag_source_new();
	}

}

public class GtkDragSourceSignal
{
	public string Value { get; set; }
	public GtkDragSourceSignal(string value) => Value = value;
}

public static class GtkDragSourceSignals
{
	public static GtkDragSourceSignal DragBegin = new("drag-begin");
	public static GtkDragSourceSignal DragCancel = new("drag-cancel");
	public static GtkDragSourceSignal DragEnd = new("drag-end");
	public static GtkDragSourceSignal Prepare = new("prepare");
}

public static class GtkDragSourceHandleExtensions
{
	public static GtkDragSourceHandle DragCancel(this GtkDragSourceHandle source)
	{
		GtkDragSourceExterns.gtk_drag_source_drag_cancel(source);
		return source;
	}

	public static GdkDragAction GetActions(this GtkDragSourceHandle source)
	{
		return GtkDragSourceExterns.gtk_drag_source_get_actions(source);
	}

	public static GdkContentProviderHandle GetContent(this GtkDragSourceHandle source)
	{
		return GtkDragSourceExterns.gtk_drag_source_get_content(source);
	}

	public static GdkDragHandle GetDrag(this GtkDragSourceHandle source)
	{
		return GtkDragSourceExterns.gtk_drag_source_get_drag(source);
	}

	public static GtkDragSourceHandle SetActions(this GtkDragSourceHandle source, GdkDragAction actions)
	{
		GtkDragSourceExterns.gtk_drag_source_set_actions(source, actions);
		return source;
	}

	public static GtkDragSourceHandle SetContent(this GtkDragSourceHandle source, GdkContentProviderHandle content)
	{
		GtkDragSourceExterns.gtk_drag_source_set_content(source, content);
		return source;
	}

	public static GtkDragSourceHandle SetIcon(this GtkDragSourceHandle source, GdkPaintableHandle paintable, int hot_x, int hot_y)
	{
		GtkDragSourceExterns.gtk_drag_source_set_icon(source, paintable, hot_x, hot_y);
		return source;
	}

	public static GtkDragSourceHandle Connect(this GtkDragSourceHandle instance, GtkDragSourceSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkDragSourceExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkDragSourceHandle gtk_drag_source_new();
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drag_source_drag_cancel(GtkDragSourceHandle source);
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkDragAction gtk_drag_source_get_actions(GtkDragSourceHandle source);
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkContentProviderHandle gtk_drag_source_get_content(GtkDragSourceHandle source);
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkDragHandle gtk_drag_source_get_drag(GtkDragSourceHandle source);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drag_source_set_actions(GtkDragSourceHandle source, GdkDragAction actions);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drag_source_set_content(GtkDragSourceHandle source, GdkContentProviderHandle content);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drag_source_set_icon(GtkDragSourceHandle source, GdkPaintableHandle paintable, int hot_x, int hot_y);
}
