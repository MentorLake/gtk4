using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;

public static class GtkConstraintLayoutExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_constraint_layout_add_constraint")]
	internal static extern void gtk_constraint_layout_add_constraint(this GtkConstraintLayoutHandle layout, GtkConstraintHandle constraint);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_constraint_layout_remove_constraint")]
	internal static extern void gtk_constraint_layout_remove_constraint(this GtkConstraintLayoutHandle layout, GtkConstraintHandle constraint);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_constraint_layout_add_guide")]
	internal static extern void gtk_constraint_layout_add_guide(this GtkConstraintLayoutHandle layout, GtkConstraintGuideHandle guide);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_constraint_layout_remove_guide")]
	internal static extern void gtk_constraint_layout_remove_guide(this GtkConstraintLayoutHandle layout, GtkConstraintGuideHandle guide);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_constraint_layout_remove_all_constraints")]
	internal static extern void gtk_constraint_layout_remove_all_constraints(this GtkConstraintLayoutHandle layout);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_constraint_layout_add_constraints_from_description")]
	internal static extern GListHandle gtk_constraint_layout_add_constraints_from_description(this GtkConstraintLayoutHandle layout, string[] lines, nuint n_lines, int hspacing, int vspacing, out GErrorHandle error, string first_view, IntPtr @__argList);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_constraint_layout_add_constraints_from_descriptionv")]
	internal static extern GListHandle gtk_constraint_layout_add_constraints_from_descriptionv(this GtkConstraintLayoutHandle layout, string[] lines, nuint n_lines, int hspacing, int vspacing, GHashTableHandle views, out GErrorHandle error);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_constraint_layout_observe_constraints")]
	internal static extern GListModelHandle gtk_constraint_layout_observe_constraints(this GtkConstraintLayoutHandle layout);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_constraint_layout_observe_guides")]
	internal static extern GListModelHandle gtk_constraint_layout_observe_guides(this GtkConstraintLayoutHandle layout);
}
