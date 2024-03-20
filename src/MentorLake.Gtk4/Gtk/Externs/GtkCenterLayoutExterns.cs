using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkCenterLayoutExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_center_layout_set_orientation")]
	internal static extern void gtk_center_layout_set_orientation(this GtkCenterLayoutHandle self, GtkOrientation orientation);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_center_layout_get_orientation")]
	internal static extern GtkOrientation gtk_center_layout_get_orientation(this GtkCenterLayoutHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_center_layout_set_baseline_position")]
	internal static extern void gtk_center_layout_set_baseline_position(this GtkCenterLayoutHandle self, GtkBaselinePosition baseline_position);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_center_layout_get_baseline_position")]
	internal static extern GtkBaselinePosition gtk_center_layout_get_baseline_position(this GtkCenterLayoutHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_center_layout_set_start_widget")]
	internal static extern void gtk_center_layout_set_start_widget(this GtkCenterLayoutHandle self, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_center_layout_get_start_widget")]
	internal static extern GtkWidgetHandle gtk_center_layout_get_start_widget(this GtkCenterLayoutHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_center_layout_set_center_widget")]
	internal static extern void gtk_center_layout_set_center_widget(this GtkCenterLayoutHandle self, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_center_layout_get_center_widget")]
	internal static extern GtkWidgetHandle gtk_center_layout_get_center_widget(this GtkCenterLayoutHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_center_layout_set_end_widget")]
	internal static extern void gtk_center_layout_set_end_widget(this GtkCenterLayoutHandle self, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_center_layout_get_end_widget")]
	internal static extern GtkWidgetHandle gtk_center_layout_get_end_widget(this GtkCenterLayoutHandle self);
}
