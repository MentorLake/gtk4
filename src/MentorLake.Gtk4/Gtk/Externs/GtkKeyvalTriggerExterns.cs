using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;

public static class GtkKeyvalTriggerExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_keyval_trigger_get_modifiers")]
	internal static extern GdkModifierType gtk_keyval_trigger_get_modifiers(this GtkKeyvalTriggerHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_keyval_trigger_get_keyval")]
	internal static extern uint gtk_keyval_trigger_get_keyval(this GtkKeyvalTriggerHandle self);
}
