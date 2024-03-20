using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkAlternativeTriggerExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_alternative_trigger_get_first")]
	internal static extern GtkShortcutTriggerHandle gtk_alternative_trigger_get_first(this GtkAlternativeTriggerHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_alternative_trigger_get_second")]
	internal static extern GtkShortcutTriggerHandle gtk_alternative_trigger_get_second(this GtkAlternativeTriggerHandle self);
}
