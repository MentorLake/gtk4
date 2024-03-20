using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;
public static class GdkDisplayAdaptors
{
    public static string GtkAcceleratorNameWithKeycode(this GdkDisplayHandle display, uint accelerator_key, uint keycode, GdkModifierType accelerator_mods)
    {
        return GdkDisplayExterns.gtk_accelerator_name_with_keycode(display, accelerator_key, keycode, accelerator_mods);
    }

    public static string GtkAcceleratorGetLabelWithKeycode(this GdkDisplayHandle display, uint accelerator_key, uint keycode, GdkModifierType accelerator_mods)
    {
        return GdkDisplayExterns.gtk_accelerator_get_label_with_keycode(display, accelerator_key, keycode, accelerator_mods);
    }

    public static GtkIconThemeHandle GtkIconThemeGetForDisplay(this GdkDisplayHandle display)
    {
        return GdkDisplayExterns.gtk_icon_theme_get_for_display(display);
    }

    public static GtkSettingsHandle GtkSettingsGetForDisplay(this GdkDisplayHandle display)
    {
        return GdkDisplayExterns.gtk_settings_get_for_display(display);
    }

    public static GdkDisplayHandle GtkStyleContextAddProviderForDisplay(this GdkDisplayHandle display, GtkStyleProviderHandle provider, uint priority)
    {
        GdkDisplayExterns.gtk_style_context_add_provider_for_display(display, provider, priority);
        return display;
    }

    public static GdkDisplayHandle GtkStyleContextRemoveProviderForDisplay(this GdkDisplayHandle display, GtkStyleProviderHandle provider)
    {
        GdkDisplayExterns.gtk_style_context_remove_provider_for_display(display, provider);
        return display;
    }
}
