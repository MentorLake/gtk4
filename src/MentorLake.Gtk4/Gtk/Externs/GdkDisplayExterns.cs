using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;

public static class GdkDisplayExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_accelerator_name_with_keycode")]
	internal static extern string gtk_accelerator_name_with_keycode(this GdkDisplayHandle display, uint accelerator_key, uint keycode, GdkModifierType accelerator_mods);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_accelerator_get_label_with_keycode")]
	internal static extern string gtk_accelerator_get_label_with_keycode(this GdkDisplayHandle display, uint accelerator_key, uint keycode, GdkModifierType accelerator_mods);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_icon_theme_get_for_display")]
	internal static extern GtkIconThemeHandle gtk_icon_theme_get_for_display(this GdkDisplayHandle display);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_settings_get_for_display")]
	internal static extern GtkSettingsHandle gtk_settings_get_for_display(this GdkDisplayHandle display);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_style_context_add_provider_for_display")]
	internal static extern void gtk_style_context_add_provider_for_display(this GdkDisplayHandle display, GtkStyleProviderHandle provider, uint priority);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_style_context_remove_provider_for_display")]
	internal static extern void gtk_style_context_remove_provider_for_display(this GdkDisplayHandle display, GtkStyleProviderHandle provider);
}
