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

namespace MentorLake.Gtk4.Gtk4;

public class GtkViewportHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkScrollableHandle
{
	public static GtkViewportHandle New(GtkAdjustmentHandle hadjustment, GtkAdjustmentHandle vadjustment)
	{
		return GtkViewportExterns.gtk_viewport_new(hadjustment, vadjustment);
	}

}

public static class GtkViewportHandleExtensions
{
	public static GtkWidgetHandle GetChild(this GtkViewportHandle viewport)
	{
		return GtkViewportExterns.gtk_viewport_get_child(viewport);
	}

	public static bool GetScrollToFocus(this GtkViewportHandle viewport)
	{
		return GtkViewportExterns.gtk_viewport_get_scroll_to_focus(viewport);
	}

	public static GtkViewportHandle ScrollTo(this GtkViewportHandle viewport, GtkWidgetHandle descendant, GtkScrollInfoHandle scroll)
	{
		GtkViewportExterns.gtk_viewport_scroll_to(viewport, descendant, scroll);
		return viewport;
	}

	public static GtkViewportHandle SetChild(this GtkViewportHandle viewport, GtkWidgetHandle child)
	{
		GtkViewportExterns.gtk_viewport_set_child(viewport, child);
		return viewport;
	}

	public static GtkViewportHandle SetScrollToFocus(this GtkViewportHandle viewport, bool scroll_to_focus)
	{
		GtkViewportExterns.gtk_viewport_set_scroll_to_focus(viewport, scroll_to_focus);
		return viewport;
	}

}

internal class GtkViewportExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkViewportHandle gtk_viewport_new(GtkAdjustmentHandle hadjustment, GtkAdjustmentHandle vadjustment);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_viewport_get_child(GtkViewportHandle viewport);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_viewport_get_scroll_to_focus(GtkViewportHandle viewport);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_viewport_scroll_to(GtkViewportHandle viewport, GtkWidgetHandle descendant, GtkScrollInfoHandle scroll);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_viewport_set_child(GtkViewportHandle viewport, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_viewport_set_scroll_to_focus(GtkViewportHandle viewport, bool scroll_to_focus);

}
