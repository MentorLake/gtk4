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

public class GtkPanedHandle : GtkWidgetHandle
{
	public static GtkPanedHandle New(GtkOrientation orientation)
	{
		return GtkPanedExterns.gtk_paned_new(orientation);
	}
}

public class GtkPanedSignal
{
	public string Value { get; set; }
	public GtkPanedSignal(string value) => Value = value;
}

public static class GtkPanedSignals
{
	public static GtkPanedSignal AcceptPosition = new("accept-position");
	public static GtkPanedSignal CancelPosition = new("cancel-position");
	public static GtkPanedSignal CycleChildFocus = new("cycle-child-focus");
	public static GtkPanedSignal CycleHandleFocus = new("cycle-handle-focus");
	public static GtkPanedSignal MoveHandle = new("move-handle");
	public static GtkPanedSignal ToggleHandleFocus = new("toggle-handle-focus");
}

public static class GtkPanedHandleExtensions
{
	public static GtkWidgetHandle GetEndChild(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_end_child(paned);
	}

	public static int GetPosition(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_position(paned);
	}

	public static bool GetResizeEndChild(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_resize_end_child(paned);
	}

	public static bool GetResizeStartChild(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_resize_start_child(paned);
	}

	public static bool GetShrinkEndChild(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_shrink_end_child(paned);
	}

	public static bool GetShrinkStartChild(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_shrink_start_child(paned);
	}

	public static GtkWidgetHandle GetStartChild(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_start_child(paned);
	}

	public static bool GetWideHandle(this GtkPanedHandle paned)
	{
		return GtkPanedExterns.gtk_paned_get_wide_handle(paned);
	}

	public static GtkPanedHandle SetEndChild(this GtkPanedHandle paned, GtkWidgetHandle child)
	{
		GtkPanedExterns.gtk_paned_set_end_child(paned, child);
		return paned;
	}

	public static GtkPanedHandle SetPosition(this GtkPanedHandle paned, int position)
	{
		GtkPanedExterns.gtk_paned_set_position(paned, position);
		return paned;
	}

	public static GtkPanedHandle SetResizeEndChild(this GtkPanedHandle paned, bool resize)
	{
		GtkPanedExterns.gtk_paned_set_resize_end_child(paned, resize);
		return paned;
	}

	public static GtkPanedHandle SetResizeStartChild(this GtkPanedHandle paned, bool resize)
	{
		GtkPanedExterns.gtk_paned_set_resize_start_child(paned, resize);
		return paned;
	}

	public static GtkPanedHandle SetShrinkEndChild(this GtkPanedHandle paned, bool resize)
	{
		GtkPanedExterns.gtk_paned_set_shrink_end_child(paned, resize);
		return paned;
	}

	public static GtkPanedHandle SetShrinkStartChild(this GtkPanedHandle paned, bool resize)
	{
		GtkPanedExterns.gtk_paned_set_shrink_start_child(paned, resize);
		return paned;
	}

	public static GtkPanedHandle SetStartChild(this GtkPanedHandle paned, GtkWidgetHandle child)
	{
		GtkPanedExterns.gtk_paned_set_start_child(paned, child);
		return paned;
	}

	public static GtkPanedHandle SetWideHandle(this GtkPanedHandle paned, bool wide)
	{
		GtkPanedExterns.gtk_paned_set_wide_handle(paned, wide);
		return paned;
	}

	public static GtkPanedHandle Connect(this GtkPanedHandle instance, GtkPanedSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkPanedExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_paned_get_end_child(GtkPanedHandle paned);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_paned_get_position(GtkPanedHandle paned);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_paned_get_resize_end_child(GtkPanedHandle paned);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_paned_get_resize_start_child(GtkPanedHandle paned);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_paned_get_shrink_end_child(GtkPanedHandle paned);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_paned_get_shrink_start_child(GtkPanedHandle paned);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_paned_get_start_child(GtkPanedHandle paned);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_paned_get_wide_handle(GtkPanedHandle paned);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_paned_set_end_child(GtkPanedHandle paned, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_paned_set_position(GtkPanedHandle paned, int position);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_paned_set_resize_end_child(GtkPanedHandle paned, bool resize);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_paned_set_resize_start_child(GtkPanedHandle paned, bool resize);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_paned_set_shrink_end_child(GtkPanedHandle paned, bool resize);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_paned_set_shrink_start_child(GtkPanedHandle paned, bool resize);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_paned_set_start_child(GtkPanedHandle paned, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_paned_set_wide_handle(GtkPanedHandle paned, bool wide);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPanedHandle gtk_paned_new(GtkOrientation orientation);
}
