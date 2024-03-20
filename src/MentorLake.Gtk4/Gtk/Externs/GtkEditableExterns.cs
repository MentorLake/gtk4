using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkEditableExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_editable_get_text")]
	internal static extern string gtk_editable_get_text(this GtkEditableHandle editable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_editable_set_text")]
	internal static extern void gtk_editable_set_text(this GtkEditableHandle editable, string text);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_editable_get_chars")]
	internal static extern string gtk_editable_get_chars(this GtkEditableHandle editable, int start_pos, int end_pos);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_editable_insert_text")]
	internal static extern void gtk_editable_insert_text(this GtkEditableHandle editable, string text, int length, ref int position);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_editable_delete_text")]
	internal static extern void gtk_editable_delete_text(this GtkEditableHandle editable, int start_pos, int end_pos);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_editable_get_selection_bounds")]
	internal static extern int gtk_editable_get_selection_bounds(this GtkEditableHandle editable, out int start_pos, out int end_pos);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_editable_delete_selection")]
	internal static extern void gtk_editable_delete_selection(this GtkEditableHandle editable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_editable_select_region")]
	internal static extern void gtk_editable_select_region(this GtkEditableHandle editable, int start_pos, int end_pos);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_editable_set_position")]
	internal static extern void gtk_editable_set_position(this GtkEditableHandle editable, int position);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_editable_get_position")]
	internal static extern int gtk_editable_get_position(this GtkEditableHandle editable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_editable_get_editable")]
	internal static extern int gtk_editable_get_editable(this GtkEditableHandle editable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_editable_set_editable")]
	internal static extern void gtk_editable_set_editable(this GtkEditableHandle editable, int is_editable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_editable_get_alignment")]
	internal static extern float gtk_editable_get_alignment(this GtkEditableHandle editable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_editable_set_alignment")]
	internal static extern void gtk_editable_set_alignment(this GtkEditableHandle editable, float xalign);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_editable_get_width_chars")]
	internal static extern int gtk_editable_get_width_chars(this GtkEditableHandle editable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_editable_set_width_chars")]
	internal static extern void gtk_editable_set_width_chars(this GtkEditableHandle editable, int n_chars);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_editable_get_max_width_chars")]
	internal static extern int gtk_editable_get_max_width_chars(this GtkEditableHandle editable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_editable_set_max_width_chars")]
	internal static extern void gtk_editable_set_max_width_chars(this GtkEditableHandle editable, int n_chars);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_editable_get_enable_undo")]
	internal static extern int gtk_editable_get_enable_undo(this GtkEditableHandle editable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_editable_set_enable_undo")]
	internal static extern void gtk_editable_set_enable_undo(this GtkEditableHandle editable, int enable_undo);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_editable_get_delegate")]
	internal static extern GtkEditableHandle gtk_editable_get_delegate(this GtkEditableHandle editable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_editable_init_delegate")]
	internal static extern void gtk_editable_init_delegate(this GtkEditableHandle editable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_editable_finish_delegate")]
	internal static extern void gtk_editable_finish_delegate(this GtkEditableHandle editable);
}
