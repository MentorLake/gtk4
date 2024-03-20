using System.Runtime.InteropServices;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;

public static class GValueExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_value_set_expression")]
	internal static extern void gtk_value_set_expression(this GValueHandle value, GtkExpressionHandle expression);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_value_take_expression")]
	internal static extern void gtk_value_take_expression(this GValueHandle value, GtkExpressionHandle expression);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_value_get_expression")]
	internal static extern GtkExpressionHandle gtk_value_get_expression(this GValueHandle value);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_value_dup_expression")]
	internal static extern GtkExpressionHandle gtk_value_dup_expression(this GValueHandle value);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_drag_icon_create_widget_for_value")]
	internal static extern GtkWidgetHandle gtk_drag_icon_create_widget_for_value(this GValueHandle value);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_get_row_drag_data")]
	internal static extern int gtk_tree_get_row_drag_data(this GValueHandle value, out GtkTreeModelHandle tree_model, out GtkTreePathHandle path);
}
