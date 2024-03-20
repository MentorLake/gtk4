using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkBoxLayoutExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_box_layout_set_homogeneous")]
	internal static extern void gtk_box_layout_set_homogeneous(this GtkBoxLayoutHandle box_layout, int homogeneous);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_box_layout_get_homogeneous")]
	internal static extern int gtk_box_layout_get_homogeneous(this GtkBoxLayoutHandle box_layout);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_box_layout_set_spacing")]
	internal static extern void gtk_box_layout_set_spacing(this GtkBoxLayoutHandle box_layout, uint spacing);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_box_layout_get_spacing")]
	internal static extern uint gtk_box_layout_get_spacing(this GtkBoxLayoutHandle box_layout);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_box_layout_set_baseline_position")]
	internal static extern void gtk_box_layout_set_baseline_position(this GtkBoxLayoutHandle box_layout, GtkBaselinePosition position);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_box_layout_get_baseline_position")]
	internal static extern GtkBaselinePosition gtk_box_layout_get_baseline_position(this GtkBoxLayoutHandle box_layout);
}
