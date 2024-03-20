using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkSelectionFilterModelExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_selection_filter_model_set_model")]
	internal static extern void gtk_selection_filter_model_set_model(this GtkSelectionFilterModelHandle self, GtkSelectionModelHandle model);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_selection_filter_model_get_model")]
	internal static extern GtkSelectionModelHandle gtk_selection_filter_model_get_model(this GtkSelectionFilterModelHandle self);
}
