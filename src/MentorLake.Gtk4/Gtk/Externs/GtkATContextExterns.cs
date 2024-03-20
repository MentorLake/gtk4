using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkATContextExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_at_context_get_accessible")]
	internal static extern GtkAccessibleHandle gtk_at_context_get_accessible(this GtkATContextHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_at_context_get_accessible_role")]
	internal static extern GtkAccessibleRole gtk_at_context_get_accessible_role(this GtkATContextHandle self);
}
