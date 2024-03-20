using System.Runtime.InteropServices;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;

public static class GtkCellAreaClassExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_class_install_cell_property")]
	internal static extern void gtk_cell_area_class_install_cell_property(this GtkCellAreaClassHandle aclass, uint property_id, GParamSpecHandle pspec);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_class_find_cell_property")]
	internal static extern GParamSpecHandle gtk_cell_area_class_find_cell_property(this GtkCellAreaClassHandle aclass, string property_name);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_cell_area_class_list_cell_properties")]
	internal static extern GParamSpecHandle[] gtk_cell_area_class_list_cell_properties(this GtkCellAreaClassHandle aclass, out uint n_properties);
}
