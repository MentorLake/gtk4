using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;

public static class GtkRangeExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_range_set_adjustment")]
	internal static extern void gtk_range_set_adjustment(this GtkRangeHandle range, GtkAdjustmentHandle adjustment);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_range_get_adjustment")]
	internal static extern GtkAdjustmentHandle gtk_range_get_adjustment(this GtkRangeHandle range);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_range_set_inverted")]
	internal static extern void gtk_range_set_inverted(this GtkRangeHandle range, int setting);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_range_get_inverted")]
	internal static extern int gtk_range_get_inverted(this GtkRangeHandle range);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_range_set_flippable")]
	internal static extern void gtk_range_set_flippable(this GtkRangeHandle range, int flippable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_range_get_flippable")]
	internal static extern int gtk_range_get_flippable(this GtkRangeHandle range);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_range_set_slider_size_fixed")]
	internal static extern void gtk_range_set_slider_size_fixed(this GtkRangeHandle range, int size_fixed);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_range_get_slider_size_fixed")]
	internal static extern int gtk_range_get_slider_size_fixed(this GtkRangeHandle range);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_range_get_range_rect")]
	internal static extern void gtk_range_get_range_rect(this GtkRangeHandle range, GdkRectangleHandle range_rect);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_range_get_slider_range")]
	internal static extern void gtk_range_get_slider_range(this GtkRangeHandle range, out int slider_start, out int slider_end);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_range_set_increments")]
	internal static extern void gtk_range_set_increments(this GtkRangeHandle range, double step, double page);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_range_set_range")]
	internal static extern void gtk_range_set_range(this GtkRangeHandle range, double min, double max);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_range_set_value")]
	internal static extern void gtk_range_set_value(this GtkRangeHandle range, double value);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_range_get_value")]
	internal static extern double gtk_range_get_value(this GtkRangeHandle range);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_range_set_show_fill_level")]
	internal static extern void gtk_range_set_show_fill_level(this GtkRangeHandle range, int show_fill_level);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_range_get_show_fill_level")]
	internal static extern int gtk_range_get_show_fill_level(this GtkRangeHandle range);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_range_set_restrict_to_fill_level")]
	internal static extern void gtk_range_set_restrict_to_fill_level(this GtkRangeHandle range, int restrict_to_fill_level);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_range_get_restrict_to_fill_level")]
	internal static extern int gtk_range_get_restrict_to_fill_level(this GtkRangeHandle range);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_range_set_fill_level")]
	internal static extern void gtk_range_set_fill_level(this GtkRangeHandle range, double fill_level);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_range_get_fill_level")]
	internal static extern double gtk_range_get_fill_level(this GtkRangeHandle range);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_range_set_round_digits")]
	internal static extern void gtk_range_set_round_digits(this GtkRangeHandle range, int round_digits);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_range_get_round_digits")]
	internal static extern int gtk_range_get_round_digits(this GtkRangeHandle range);
}
