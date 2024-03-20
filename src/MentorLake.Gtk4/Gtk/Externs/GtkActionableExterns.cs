using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;

public static class GtkActionableExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_actionable_get_action_name")]
	internal static extern string gtk_actionable_get_action_name(this GtkActionableHandle actionable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_actionable_set_action_name")]
	internal static extern void gtk_actionable_set_action_name(this GtkActionableHandle actionable, string action_name);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_actionable_get_action_target_value")]
	internal static extern GVariantHandle gtk_actionable_get_action_target_value(this GtkActionableHandle actionable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_actionable_set_action_target_value")]
	internal static extern void gtk_actionable_set_action_target_value(this GtkActionableHandle actionable, GVariantHandle target_value);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_actionable_set_action_target")]
	internal static extern void gtk_actionable_set_action_target(this GtkActionableHandle actionable, string format_string, IntPtr @__argList);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_actionable_set_detailed_action_name")]
	internal static extern void gtk_actionable_set_detailed_action_name(this GtkActionableHandle actionable, string detailed_action_name);
}
