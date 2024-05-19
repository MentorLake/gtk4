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

public class GtkCenterLayoutHandle : GtkLayoutManagerHandle
{
	public static GtkCenterLayoutHandle New()
	{
		return GtkCenterLayoutExterns.gtk_center_layout_new();
	}

}

public static class GtkCenterLayoutHandleExtensions
{
	public static GtkBaselinePosition GetBaselinePosition(this GtkCenterLayoutHandle self)
	{
		return GtkCenterLayoutExterns.gtk_center_layout_get_baseline_position(self);
	}

	public static GtkWidgetHandle GetCenterWidget(this GtkCenterLayoutHandle self)
	{
		return GtkCenterLayoutExterns.gtk_center_layout_get_center_widget(self);
	}

	public static GtkWidgetHandle GetEndWidget(this GtkCenterLayoutHandle self)
	{
		return GtkCenterLayoutExterns.gtk_center_layout_get_end_widget(self);
	}

	public static GtkOrientation GetOrientation(this GtkCenterLayoutHandle self)
	{
		return GtkCenterLayoutExterns.gtk_center_layout_get_orientation(self);
	}

	public static bool GetShrinkCenterLast(this GtkCenterLayoutHandle self)
	{
		return GtkCenterLayoutExterns.gtk_center_layout_get_shrink_center_last(self);
	}

	public static GtkWidgetHandle GetStartWidget(this GtkCenterLayoutHandle self)
	{
		return GtkCenterLayoutExterns.gtk_center_layout_get_start_widget(self);
	}

	public static GtkCenterLayoutHandle SetBaselinePosition(this GtkCenterLayoutHandle self, GtkBaselinePosition baseline_position)
	{
		GtkCenterLayoutExterns.gtk_center_layout_set_baseline_position(self, baseline_position);
		return self;
	}

	public static GtkCenterLayoutHandle SetCenterWidget(this GtkCenterLayoutHandle self, GtkWidgetHandle widget)
	{
		GtkCenterLayoutExterns.gtk_center_layout_set_center_widget(self, widget);
		return self;
	}

	public static GtkCenterLayoutHandle SetEndWidget(this GtkCenterLayoutHandle self, GtkWidgetHandle widget)
	{
		GtkCenterLayoutExterns.gtk_center_layout_set_end_widget(self, widget);
		return self;
	}

	public static GtkCenterLayoutHandle SetOrientation(this GtkCenterLayoutHandle self, GtkOrientation orientation)
	{
		GtkCenterLayoutExterns.gtk_center_layout_set_orientation(self, orientation);
		return self;
	}

	public static GtkCenterLayoutHandle SetShrinkCenterLast(this GtkCenterLayoutHandle self, bool shrink_center_last)
	{
		GtkCenterLayoutExterns.gtk_center_layout_set_shrink_center_last(self, shrink_center_last);
		return self;
	}

	public static GtkCenterLayoutHandle SetStartWidget(this GtkCenterLayoutHandle self, GtkWidgetHandle widget)
	{
		GtkCenterLayoutExterns.gtk_center_layout_set_start_widget(self, widget);
		return self;
	}

}

internal class GtkCenterLayoutExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCenterLayoutHandle gtk_center_layout_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkBaselinePosition gtk_center_layout_get_baseline_position(GtkCenterLayoutHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_center_layout_get_center_widget(GtkCenterLayoutHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_center_layout_get_end_widget(GtkCenterLayoutHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkOrientation gtk_center_layout_get_orientation(GtkCenterLayoutHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_center_layout_get_shrink_center_last(GtkCenterLayoutHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_center_layout_get_start_widget(GtkCenterLayoutHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_center_layout_set_baseline_position(GtkCenterLayoutHandle self, GtkBaselinePosition baseline_position);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_center_layout_set_center_widget(GtkCenterLayoutHandle self, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_center_layout_set_end_widget(GtkCenterLayoutHandle self, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_center_layout_set_orientation(GtkCenterLayoutHandle self, GtkOrientation orientation);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_center_layout_set_shrink_center_last(GtkCenterLayoutHandle self, bool shrink_center_last);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_center_layout_set_start_widget(GtkCenterLayoutHandle self, GtkWidgetHandle widget);

}
