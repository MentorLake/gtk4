using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;

public static class GtkShortcutControllerExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_shortcut_controller_set_mnemonics_modifiers")]
	internal static extern void gtk_shortcut_controller_set_mnemonics_modifiers(this GtkShortcutControllerHandle self, GdkModifierType modifiers);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_shortcut_controller_get_mnemonics_modifiers")]
	internal static extern GdkModifierType gtk_shortcut_controller_get_mnemonics_modifiers(this GtkShortcutControllerHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_shortcut_controller_set_scope")]
	internal static extern void gtk_shortcut_controller_set_scope(this GtkShortcutControllerHandle self, GtkShortcutScope scope);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_shortcut_controller_get_scope")]
	internal static extern GtkShortcutScope gtk_shortcut_controller_get_scope(this GtkShortcutControllerHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_shortcut_controller_add_shortcut")]
	internal static extern void gtk_shortcut_controller_add_shortcut(this GtkShortcutControllerHandle self, GtkShortcutHandle shortcut);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_shortcut_controller_remove_shortcut")]
	internal static extern void gtk_shortcut_controller_remove_shortcut(this GtkShortcutControllerHandle self, GtkShortcutHandle shortcut);
}
