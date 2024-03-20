using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkNamedActionExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_named_action_get_action_name")]
	internal static extern string gtk_named_action_get_action_name(this GtkNamedActionHandle self);
}
