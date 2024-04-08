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

public class GtkScrollbarHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkOrientableHandle
{
	public static GtkScrollbarHandle New(GtkOrientation orientation, GtkAdjustmentHandle adjustment)
	{
		return GtkScrollbarExterns.gtk_scrollbar_new(orientation, adjustment);
	}

}

public static class GtkScrollbarHandleExtensions
{
	public static GtkAdjustmentHandle GetAdjustment(this GtkScrollbarHandle self)
	{
		return GtkScrollbarExterns.gtk_scrollbar_get_adjustment(self);
	}

	public static GtkScrollbarHandle SetAdjustment(this GtkScrollbarHandle self, GtkAdjustmentHandle adjustment)
	{
		GtkScrollbarExterns.gtk_scrollbar_set_adjustment(self, adjustment);
		return self;
	}

}

internal class GtkScrollbarExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkScrollbarHandle gtk_scrollbar_new(GtkOrientation orientation, GtkAdjustmentHandle adjustment);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAdjustmentHandle gtk_scrollbar_get_adjustment(GtkScrollbarHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scrollbar_set_adjustment(GtkScrollbarHandle self, GtkAdjustmentHandle adjustment);
}
