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

public class GtkCenterBoxHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkOrientableHandle
{
	public static GtkCenterBoxHandle New()
	{
		return GtkCenterBoxExterns.gtk_center_box_new();
	}

}

public static class GtkCenterBoxHandleExtensions
{
	public static GtkBaselinePosition GetBaselinePosition(this GtkCenterBoxHandle self)
	{
		return GtkCenterBoxExterns.gtk_center_box_get_baseline_position(self);
	}

	public static GtkWidgetHandle GetCenterWidget(this GtkCenterBoxHandle self)
	{
		return GtkCenterBoxExterns.gtk_center_box_get_center_widget(self);
	}

	public static GtkWidgetHandle GetEndWidget(this GtkCenterBoxHandle self)
	{
		return GtkCenterBoxExterns.gtk_center_box_get_end_widget(self);
	}

	public static bool GetShrinkCenterLast(this GtkCenterBoxHandle self)
	{
		return GtkCenterBoxExterns.gtk_center_box_get_shrink_center_last(self);
	}

	public static GtkWidgetHandle GetStartWidget(this GtkCenterBoxHandle self)
	{
		return GtkCenterBoxExterns.gtk_center_box_get_start_widget(self);
	}

	public static GtkCenterBoxHandle SetBaselinePosition(this GtkCenterBoxHandle self, GtkBaselinePosition position)
	{
		GtkCenterBoxExterns.gtk_center_box_set_baseline_position(self, position);
		return self;
	}

	public static GtkCenterBoxHandle SetCenterWidget(this GtkCenterBoxHandle self, GtkWidgetHandle child)
	{
		GtkCenterBoxExterns.gtk_center_box_set_center_widget(self, child);
		return self;
	}

	public static GtkCenterBoxHandle SetEndWidget(this GtkCenterBoxHandle self, GtkWidgetHandle child)
	{
		GtkCenterBoxExterns.gtk_center_box_set_end_widget(self, child);
		return self;
	}

	public static GtkCenterBoxHandle SetShrinkCenterLast(this GtkCenterBoxHandle self, bool shrink_center_last)
	{
		GtkCenterBoxExterns.gtk_center_box_set_shrink_center_last(self, shrink_center_last);
		return self;
	}

	public static GtkCenterBoxHandle SetStartWidget(this GtkCenterBoxHandle self, GtkWidgetHandle child)
	{
		GtkCenterBoxExterns.gtk_center_box_set_start_widget(self, child);
		return self;
	}

}

internal class GtkCenterBoxExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCenterBoxHandle gtk_center_box_new();
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkBaselinePosition gtk_center_box_get_baseline_position(GtkCenterBoxHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_center_box_get_center_widget(GtkCenterBoxHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_center_box_get_end_widget(GtkCenterBoxHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_center_box_get_shrink_center_last(GtkCenterBoxHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_center_box_get_start_widget(GtkCenterBoxHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_center_box_set_baseline_position(GtkCenterBoxHandle self, GtkBaselinePosition position);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_center_box_set_center_widget(GtkCenterBoxHandle self, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_center_box_set_end_widget(GtkCenterBoxHandle self, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_center_box_set_shrink_center_last(GtkCenterBoxHandle self, bool shrink_center_last);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_center_box_set_start_widget(GtkCenterBoxHandle self, GtkWidgetHandle child);
}
